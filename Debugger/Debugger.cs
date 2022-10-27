using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
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

        public Debugger()
        {
            InitializeComponent();
            // Will create settings on load if loaded from file
        }

        private void Browse_button_click(object sender, EventArgs e)
        {
            var result = open_file_dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                class_combo_box.Items.Clear();
                class_combo_box.SelectedItem = null;
                class_combo_box.Text = string.Empty;

                // Analyze file ?
                path_text_box.Text = open_file_dialog.FileName;
                try
                {
                    var assembly = Assembly.LoadFile(open_file_dialog.FileName);
                    var classes = assembly.GetTypes();

                    for (int index = 0; index < classes.Length; index++)
                    {
                        class_combo_box.Items.Add(classes[index]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Assembly load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    var method = type.GetMethod("CustomMethod");

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
            else
            {
                throw new NotImplementedException();
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
    }
}