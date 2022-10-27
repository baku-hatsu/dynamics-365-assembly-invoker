using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Forms;

namespace Debugger
{
    public partial class ObjectCreatorForm : Form
    {
        public object _result = null;

        private const int NameIndex = 0;
        private const int TypeIndex = 1;
        private const int ValueIndex = 2;

        public ObjectCreatorForm(ExpandoObject defaultValue = null)
        {
            InitializeComponent();
            SetUpTypesComboBox(TypeIndex);

            if (defaultValue != null)
            {
                SetUpDefaultValues(defaultValue);
            }
        }

        private void SetUpDefaultValues(ExpandoObject existingExpandoObject)
        {
            foreach (KeyValuePair<string, object> property in existingExpandoObject)
            {
                var rowIndex = object_data_grid_view.Rows.Add();
                object_data_grid_view.Rows[rowIndex].Cells[NameIndex].Value = property.Key;
                object_data_grid_view.Rows[rowIndex].Cells[TypeIndex].Value = property.Value?.GetType();
                object_data_grid_view.Rows[rowIndex].Cells[ValueIndex].Value = property.Value;
            }
        }

        private void SetUpTypesComboBox(int columnIndex)
        {
            if (object_data_grid_view.Columns[columnIndex] is DataGridViewComboBoxColumn typeColumn)
            {
                typeColumn.DisplayMember = "Name";
                typeColumn.ValueMember = "Value";
                typeColumn.Items.Add(new { Name = typeof(object).FullName, Value = typeof(object) });
                typeColumn.Items.Add(new { Name = typeof(Guid).FullName, Value = typeof(Guid) });
                typeColumn.Items.Add(new { Name = typeof(string).FullName, Value = typeof(string) });
                typeColumn.Items.Add(new { Name = typeof(int).FullName, Value = typeof(int) });
                typeColumn.Items.Add(new { Name = typeof(bool).FullName, Value = typeof(bool) });
                typeColumn.Items.Add(new { Name = typeof(DateTime).FullName, Value = typeof(DateTime) });
            }
        }

        private void Ok_button_click(object sender, EventArgs e)
        {
            var result = new ExpandoObject();

            for (int index = 0; index < object_data_grid_view.RowCount - 1; index++)
            {
                if (object_data_grid_view.Rows[index].Cells[TypeIndex].Value is Type type)
                {
                    var name = object_data_grid_view.Rows[index].Cells[NameIndex].Value as string;
                    var value = object_data_grid_view.Rows[index].Cells[ValueIndex].Value;

                    if (type.FullName.Equals(typeof(object).FullName))
                    {
                        result.AddProperty(name, value);
                    }
                    else
                    {
                        result.AddProperty(name, TypeHelper.Cast(type, value.ToString()));
                    }
                }
            }

            _result = result;
        }

        private void Object_data_grid_view_cell_mouse_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == ValueIndex)
            {
                if (object_data_grid_view.Rows[e.RowIndex].Cells[TypeIndex].Value is Type item && item.FullName.Equals(typeof(object).FullName))
                {
                    var form = new ObjectCreatorForm(object_data_grid_view.Rows[e.RowIndex].Cells[ValueIndex].Value as ExpandoObject);

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