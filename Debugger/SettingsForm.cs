using System;
using System.Windows.Forms;

namespace Debugger
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeNamespacesList();
        }

        private void InitializeNamespacesList()
        {
            var namespaces = Properties.Settings.Default.Namespaces;

            for (int index = 0; index < namespaces.Count; index++)
            {
                namespaces_list_box.Items.Add(namespaces[index]);
            }
        }

        private void Namespace_add_button_click(object sender, EventArgs e)
        {
            var text = namespace_add_text_box.Text;

            if (!string.IsNullOrEmpty(text) && !namespaces_list_box.Items.Contains(text))
            {
                namespaces_list_box.Items.Add(text);
                Properties.Settings.Default.Namespaces.Add(text);
                namespace_add_text_box.Clear();
            }
        }

        private void Namespace_remove_button_click(object sender, EventArgs e)
        {
            var selectedIndex = namespaces_list_box.SelectedIndex;

            if (selectedIndex > -1)
            {
                namespaces_list_box.Items.RemoveAt(selectedIndex);
                Properties.Settings.Default.Namespaces.RemoveAt(selectedIndex);
            }
        }

        private void Save_button_click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}