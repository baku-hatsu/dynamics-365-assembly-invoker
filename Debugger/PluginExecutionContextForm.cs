using System;
using System.Linq;
using System.Windows.Forms;

namespace Debugger
{
    public partial class PluginExecutionContextForm : Form
    {
        public DPluginContext _context = null;

        public PluginExecutionContextForm()
        {
            InitializeComponent();
            LoadFields();
        }

        private void LoadFields()
        {
            var properties = typeof(DPluginContext)
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
            var obj = new DPluginContext();
            var data = data_grid_view.DataSource as BindingSource;

            for (int index = 0; index < data.List.Count; index++)
            {
                var item = data.List[index] as DataRow;

                if (item.DataEnabled)
                {
                    var name = item.DataTitle;
                    var value = item.DataValue;

                    obj.GetType().GetProperty(name).SetValue(obj, value, null);
                }
            }

            _context = obj;
        }

        private void Cancel_button_click(object sender, EventArgs e)
        {
            Close();
        }
    }
}