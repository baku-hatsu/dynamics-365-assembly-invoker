using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Debugger
{
    public partial class WorkflowContextForm : Form
    {
        private DataGridViewCellEventArgs mouseLocation;

        public DWorkflowContext _context = null;

        public WorkflowContextForm()
        {
            InitializeComponent();
            LoadFields();
        }

        private void LoadFields()
        {
            var properties = typeof(DWorkflowContext)
                .GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(NotImplementedAttribute), true).FirstOrDefault() == null)
                .ToList();

            var bindingSource = new BindingSource();

            for (int index = 0; index < properties.Count; index++)
            {
                bindingSource.Add(new DataRow
                {
                    DataEnabled = true,
                    DataTitle = properties[index].Name,
                    DataValue = null,
                    DataType = properties[index].PropertyType
                });
            }

            data_grid_view.DataSource = bindingSource;
        }

        private void Ok_button_click(object sender, EventArgs e)
        {
            var obj = new DWorkflowContext();
            var data = data_grid_view.DataSource as BindingSource;

            for (int index = 0; index < data.List.Count; index++)
            {
                var item = data.List[index] as DataRow;

                if (item.DataEnabled)
                {
                    obj.GetType().GetProperty(item.DataTitle).SetValue(obj, TypeHelper.Cast(item.DataType, item.DataValue));
                }
            }

            _context = obj;
        }

        private void Cancel_button_click(object sender, EventArgs e)
        {
            Close();
        }

        private void Default_value_tool_strip_menu_item_click(object sender, EventArgs e)
        {
            if (mouseLocation.RowIndex > -1 && mouseLocation.ColumnIndex > -1)
            {
                if (data_grid_view.Rows[mouseLocation.RowIndex].DataBoundItem is DataRow item)
                {
                    data_grid_view.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value = TypeHelper.DefaultOf(item.DataType);
                }
            }
        }

        private void New_value_tool_strip_menu_item_click(object sender, EventArgs e)
        {
            if (mouseLocation.RowIndex > -1 && mouseLocation.ColumnIndex > -1)
            {
                if (data_grid_view.Rows[mouseLocation.RowIndex].DataBoundItem is DataRow item)
                {
                    data_grid_view.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value = TypeHelper.NewOf(item.DataType);
                }
            }
        }

        private void Data_grid_view_cell_mouse_enter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void Context_menu_strip_opening(object sender, CancelEventArgs e)
        {
            if (mouseLocation.RowIndex < 0 || mouseLocation.ColumnIndex != 2)
            {
                e.Cancel = true;
            }
        }
    }
}