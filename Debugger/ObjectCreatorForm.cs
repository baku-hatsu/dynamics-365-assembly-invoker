using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Debugger
{
    public partial class ObjectCreatorForm : Form
    {
        public object _result = null;

        private readonly bool _isBaseForm = false;
        private readonly Type _type;
        private Assembly _assembly = null;

        private const int NameIndex = 0;
        private const int TypeIndex = 1;
        private const int ValueIndex = 2;

        public ObjectCreatorForm(bool isBaseForm, Assembly assembly, Type selectedType = null, object defaultObj = null)
        {
            _isBaseForm = isBaseForm;
            _type = selectedType;
            _assembly = assembly;

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
                var propertyName = properties[index].Name;
                var propertyType = properties[index].PropertyType;

                object_data_grid_view.Rows[rowIndex].Cells[NameIndex].Value = propertyName;
                object_data_grid_view.Rows[rowIndex].Cells[TypeIndex].Value = propertyType.GetUnderlyingType();
                object_data_grid_view.Rows[rowIndex].Cells[ValueIndex].Value = null;
            }
        }

        private void FillObjectCreatorWithDefaultValues(object obj)
        {
            for (int index = 0; index < object_data_grid_view.RowCount - 1; index++)
            {
                var property = obj.GetType().GetProperty(object_data_grid_view.Rows[index].Cells[NameIndex].Value.ToString());
                object_data_grid_view.Rows[index].Cells[ValueIndex].Value = property.GetValue(obj);
            }
        }

        private void SetUpTypesComboBox(int columnIndex)
        {
            if (object_data_grid_view.Columns[columnIndex] is DataGridViewComboBoxColumn typeColumn)
            {
                var loadedNamespaces = new List<string>();
                if (_assembly != null)
                {
                    loadedNamespaces = _assembly.GetTypes().Select(t => t.Namespace).Distinct().ToList();
                }

                var customeTypes = AppDomain.CurrentDomain
                    .GetAssemblies()
                    .SelectMany(t => t.GetTypes())
                    .Where(t => Properties.Settings.Default.Namespaces.Contains(t.Namespace) || loadedNamespaces.Contains(t.Namespace))
                    .OrderBy(t => t.FullName)
                    .ToArray();

                typeColumn.DropDownWidth = 500;
                typeColumn.DisplayMember = "Name";
                typeColumn.ValueMember = "Value";

                for (int index = 0; index < customeTypes.Length; index++)
                {
                    typeColumn.Items.Add(new { Name = customeTypes[index].FullName, Value = customeTypes[index] });
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
                    var form = new ObjectCreatorForm(false, _assembly, type, object_data_grid_view.Rows[e.RowIndex].Cells[ValueIndex].Value);

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