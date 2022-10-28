using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Debugger
{
    public partial class ObjectCreatorForm : Form
    {
        public object _result = null;

        private readonly bool _isBaseForm = false;
        private readonly List<Type> _types;
        private readonly Type _type;

        private const int NameIndex = 0;
        private const int TypeIndex = 1;
        private const int ValueIndex = 2;

        public ObjectCreatorForm(bool isBaseForm, List<Type> types, Type selectedType = null, object defaultObj = null)
        {
            _isBaseForm = isBaseForm;
            _types = types;
            _type = selectedType;

            InitializeComponent();
            SetUpTypesComboBox(TypeIndex);

            if (selectedType != null)
            {
                PopulateObjectCreator(selectedType);
            }

            if (defaultObj != null)
            {
                FillObjectCreatorWithDefaultValues(defaultObj);
            }
        }

        private void PopulateObjectCreator(Type type)
        {
            var properties = type.GetProperties();

            for (int index = 0; index < properties.Length; index++)
            {
                var rowIndex = object_data_grid_view.Rows.Add();
                object_data_grid_view.Rows[rowIndex].Cells[NameIndex].Value = properties[index].Name;
                object_data_grid_view.Rows[rowIndex].Cells[TypeIndex].Value = properties[index].PropertyType;
                object_data_grid_view.Rows[rowIndex].Cells[ValueIndex].Value = null;
            }
        }

        private void FillObjectCreatorWithDefaultValues(object obj)
        {
            var type = obj.GetType();

            for (int index = 0; index < object_data_grid_view.RowCount - 1; index++)
            {
                var property = type.GetProperty(object_data_grid_view.Rows[index].Cells[NameIndex].Value.ToString());
                object_data_grid_view.Rows[index].Cells[ValueIndex].Value = property.GetValue(obj);
            }
        }

        private void SetUpTypesComboBox(int columnIndex)
        {
            if (object_data_grid_view.Columns[columnIndex] is DataGridViewComboBoxColumn typeColumn)
            {
                typeColumn.DisplayMember = "Name";
                typeColumn.ValueMember = "Value";
                typeColumn.Items.Add(new { Name = typeof(Guid).FullName, Value = typeof(Guid) });
                typeColumn.Items.Add(new { Name = typeof(string).FullName, Value = typeof(string) });
                typeColumn.Items.Add(new { Name = typeof(int).FullName, Value = typeof(int) });
                typeColumn.Items.Add(new { Name = typeof(bool).FullName, Value = typeof(bool) });
                typeColumn.Items.Add(new { Name = typeof(DateTime).FullName, Value = typeof(DateTime) });

                for (int index = 0; index < _types.Count; index++)
                {
                    typeColumn.Items.Add(new { Name = _types[index].FullName, Value = _types[index] });
                }
            }
        }

        private void Ok_button_click(object sender, EventArgs e)
        {
            if (_isBaseForm)
            {
                var result = new Dictionary<string, object>();

                for (int index = 0; index < object_data_grid_view.RowCount - 1; index++)
                {
                    if (object_data_grid_view.Rows[index].Cells[TypeIndex].Value is Type type)
                    {
                        var name = object_data_grid_view.Rows[index].Cells[NameIndex].Value;
                        var value = object_data_grid_view.Rows[index].Cells[ValueIndex].Value;

                        if (type.IsNotApplicationPrimitive())
                        {
                            result.Add(name.ToString(), value);
                        }
                        else
                        {
                            result.Add(name.ToString(), TypeHelper.Cast(type, value));
                        }
                    }
                }

                _result = result;
            }
            else
            {
                var result = Activator.CreateInstance(_type);

                for (int index = 0; index < object_data_grid_view.RowCount - 1; index++)
                {
                    if (object_data_grid_view.Rows[index].Cells[TypeIndex].Value is Type type)
                    {
                        var name = object_data_grid_view.Rows[index].Cells[NameIndex].Value;
                        var value = object_data_grid_view.Rows[index].Cells[ValueIndex].Value;

                        if (type.IsNotApplicationPrimitive())
                        {
                            _type.GetProperty(name.ToString()).SetValue(result, value);
                        }
                        else
                        {
                            _type.GetProperty(name.ToString()).SetValue(result, TypeHelper.Cast(type, value));
                        }
                    }
                }

                _result = result;
            }
        }

        private void Object_data_grid_view_cell_enter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == ValueIndex)
            {
                if (object_data_grid_view.Rows[e.RowIndex].Cells[TypeIndex].Value is Type type && type.IsNotApplicationPrimitive())
                {
                    var form = new ObjectCreatorForm(false, _types, type, object_data_grid_view.Rows[e.RowIndex].Cells[ValueIndex].Value);

                    var result = form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        object_data_grid_view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = form._result;
                    }
                }
            }
        }
    }
}