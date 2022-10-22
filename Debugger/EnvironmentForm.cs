using System;
using System.Windows.Forms;

namespace Debugger
{
    public partial class EnvironmentForm : Form
    {
        public Environment _environment = null;

        public EnvironmentForm()
        {
            InitializeComponent();
        }

        private void Token_cache_path_text_box_click(object sender, EventArgs e)
        {
            var result = folder_browser_dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folder_browser_dialog.SelectedPath = token_cache_path_text_box.Text;
            }
        }

        private void Ok_button_click(object sender, EventArgs e)
        {
            _environment = new Environment
            {
                Instance = new Uri(instance_text_box.Text),
                ClientId = client_id_text_box.Text,
                ClientSecret = client_secret_text_box.Text,
                UseUniqueInstance = use_unique_instance_check_box.Checked,
                TokenCachePath = folder_browser_dialog.SelectedPath
            };
        }
    }
}