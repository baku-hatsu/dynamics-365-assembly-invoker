namespace Debugger
{
    partial class PluginExecutionContextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.DataEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context_menu_strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.default_value_tool_strip_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.new_value_tool_strip_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.context_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(705, 434);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(624, 434);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_click);
            // 
            // data_grid_view
            // 
            this.data_grid_view.AllowUserToAddRows = false;
            this.data_grid_view.AllowUserToDeleteRows = false;
            this.data_grid_view.AllowUserToOrderColumns = true;
            this.data_grid_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataEnabled,
            this.DataTitle,
            this.DataValue,
            this.DataType});
            this.data_grid_view.ContextMenuStrip = this.context_menu_strip;
            this.data_grid_view.Location = new System.Drawing.Point(4, 4);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.Size = new System.Drawing.Size(776, 424);
            this.data_grid_view.TabIndex = 0;
            this.data_grid_view.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_grid_view_cell_mouse_enter);
            // 
            // DataEnabled
            // 
            this.DataEnabled.DataPropertyName = "DataEnabled";
            this.DataEnabled.FalseValue = "false";
            this.DataEnabled.Frozen = true;
            this.DataEnabled.HeaderText = "";
            this.DataEnabled.MinimumWidth = 25;
            this.DataEnabled.Name = "DataEnabled";
            this.DataEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataEnabled.ToolTipText = "Enabled";
            this.DataEnabled.TrueValue = "true";
            this.DataEnabled.Width = 25;
            // 
            // DataTitle
            // 
            this.DataTitle.DataPropertyName = "DataTitle";
            this.DataTitle.HeaderText = "Title";
            this.DataTitle.MaxInputLength = 20;
            this.DataTitle.MinimumWidth = 200;
            this.DataTitle.Name = "DataTitle";
            this.DataTitle.ReadOnly = true;
            this.DataTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTitle.ToolTipText = "Tirle";
            this.DataTitle.Width = 200;
            // 
            // DataValue
            // 
            this.DataValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataValue.DataPropertyName = "DataValue";
            this.DataValue.HeaderText = "Value";
            this.DataValue.Name = "DataValue";
            this.DataValue.ToolTipText = "Value";
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "Type";
            this.DataType.MaxInputLength = 100;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataType.Visible = false;
            this.DataType.Width = 5;
            // 
            // context_menu_strip
            // 
            this.context_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.default_value_tool_strip_menu_item,
            this.new_value_tool_strip_menu_item});
            this.context_menu_strip.Name = "context_menu_strip";
            this.context_menu_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.context_menu_strip.Size = new System.Drawing.Size(144, 48);
            this.context_menu_strip.Opening += new System.ComponentModel.CancelEventHandler(this.Context_menu_strip_opening);
            // 
            // default_value_tool_strip_menu_item
            // 
            this.default_value_tool_strip_menu_item.Name = "default_value_tool_strip_menu_item";
            this.default_value_tool_strip_menu_item.Size = new System.Drawing.Size(143, 22);
            this.default_value_tool_strip_menu_item.Text = "Default value";
            this.default_value_tool_strip_menu_item.Click += new System.EventHandler(this.Default_value_tool_strip_menu_item_click);
            // 
            // new_value_tool_strip_menu_item
            // 
            this.new_value_tool_strip_menu_item.Name = "new_value_tool_strip_menu_item";
            this.new_value_tool_strip_menu_item.Size = new System.Drawing.Size(143, 22);
            this.new_value_tool_strip_menu_item.Text = "New value";
            this.new_value_tool_strip_menu_item.Click += new System.EventHandler(this.New_value_tool_strip_menu_item_click);
            // 
            // PluginExecutionContextForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.data_grid_view);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PluginExecutionContextForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Plugin Execution Context";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.context_menu_strip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DataGridView data_grid_view;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.ContextMenuStrip context_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem default_value_tool_strip_menu_item;
        private System.Windows.Forms.ToolStripMenuItem new_value_tool_strip_menu_item;
    }
}