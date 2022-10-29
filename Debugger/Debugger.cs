using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Debugger
{
    public partial class Debugger : Form
    {
        private DPluginContext _pluginContext = new DPluginContext();
        private DWorkflowContext _workflowContext = new DWorkflowContext();
        private DSettings _settings = null;
        private Dictionary<string, object> _inputs = new Dictionary<string, object>();
        private Assembly _assembly = null;

        public Debugger()
        {
            InitializeComponent();
        }

        private void Browse_button_click(object sender, EventArgs e)
        {
            open_file_dialog.ShowDialog();
        }

        private void Path_text_box_mouse_click(object sender, MouseEventArgs e)
        {
            open_file_dialog.ShowDialog();
        }

        private void Execute_button_click(object sender, EventArgs e)
        {
            try
            {
                var type = (Type)class_combo_box.SelectedItem;
                var isPlugin = type.GetInterfaces().Where(x => x.Name.Equals(nameof(IPlugin))).FirstOrDefault() != null;

                if (type.BaseType.Name.Equals(nameof(CodeActivity)))
                {
                    var invoker = new WorkflowInvoker((CodeActivity)Activator.CreateInstance(type));
                    invoker.Extensions.Add<IWorkflowContext>(() => _workflowContext);
                    invoker.Extensions.Add<ITracingService>(() => new DTracingService());
                    invoker.Extensions.Add<IOrganizationServiceFactory>(() => new DOrganizationServiceFactory(_settings));

                    var outputs = invoker.Invoke(_inputs);
                }
                else if (isPlugin)
                {
                    var plugin = (IPlugin)Activator.CreateInstance(type);

                    plugin.Execute(new DServiceProvider(_settings, _pluginContext));
                }
                else
                {
                    var method = type.GetMethod("CustomMethod2");

                    var outputs = method.Invoke(Activator.CreateInstance(type), _inputs.Select(x => x.Value).ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Execution error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_button_click(object sender, EventArgs e)
        {
            Close();
        }

        private void Inputs_button_click(object sender, EventArgs e)
        {
            var form = new ObjectCreatorForm(true, _assembly);

            var result = form.ShowDialog();

            if (result == DialogResult.OK && form._result is Dictionary<string, object> dictionary)
            {
                _inputs = dictionary;
            }
        }

        private void Properties_button_click(object sender, EventArgs e)
        {
            var type = (Type)class_combo_box.SelectedItem;
            var isPlugin = type.GetInterfaces().Where(x => x.Name.Equals(nameof(IPlugin))).FirstOrDefault() != null;

            if (type.BaseType.Name.Equals(nameof(CodeActivity)))
            {
                var form = new WorkflowContextForm();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _workflowContext = form._context;
                }
            }
            else if (isPlugin)
            {
                var form = new PluginExecutionContextForm();

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _pluginContext = form._context;
                }
            }
        }

        private void Environment_tool_strip_menu_Item_click(object sender, EventArgs e)
        {
            var form = new EnvironmentForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _settings = new DSettings
                {
                    Environment = form._environment
                };
            }
        }

        private void Settings_tool_Strip_menu_item_click(object sender, EventArgs e)
        {
            var form = new SettingsForm();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
            }
        }

        private void Open_file_dialog_file_ok(object sender, CancelEventArgs e)
        {
            class_combo_box.Items.Clear();
            class_combo_box.SelectedItem = null;
            class_combo_box.Text = string.Empty;

            try
            {
                _assembly = Assembly.LoadFile(open_file_dialog.FileName);
                var types = _assembly.GetTypes();

                for (int index = 0; index < types.Length; index++)
                {
                    class_combo_box.Items.Add(types[index]);
                }

                path_text_box.Text = open_file_dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Assembly load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Debugger_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}