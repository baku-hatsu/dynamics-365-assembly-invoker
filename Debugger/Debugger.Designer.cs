namespace Debugger
{
    partial class Debugger
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
            this.browse_button = new System.Windows.Forms.Button();
            this.properties_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.execute_button = new System.Windows.Forms.Button();
            this.class_combo_box = new System.Windows.Forms.ComboBox();
            this.path_text_box = new System.Windows.Forms.TextBox();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputs_button = new System.Windows.Forms.Button();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(12, 27);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 0;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.Browse_button_click);
            // 
            // properties_button
            // 
            this.properties_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.properties_button.Location = new System.Drawing.Point(447, 83);
            this.properties_button.Name = "properties_button";
            this.properties_button.Size = new System.Drawing.Size(75, 23);
            this.properties_button.TabIndex = 3;
            this.properties_button.Text = "Properties";
            this.properties_button.UseVisualStyleBackColor = true;
            this.properties_button.Click += new System.EventHandler(this.Properties_button_click);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_button.Location = new System.Drawing.Point(366, 176);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.Close_button_click);
            // 
            // execute_button
            // 
            this.execute_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.execute_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.execute_button.Location = new System.Drawing.Point(447, 176);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(75, 23);
            this.execute_button.TabIndex = 4;
            this.execute_button.Text = "Execute";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.Execute_button_click);
            // 
            // class_combo_box
            // 
            this.class_combo_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class_combo_box.FormattingEnabled = true;
            this.class_combo_box.Location = new System.Drawing.Point(12, 56);
            this.class_combo_box.Name = "class_combo_box";
            this.class_combo_box.Size = new System.Drawing.Size(510, 21);
            this.class_combo_box.TabIndex = 2;
            // 
            // path_text_box
            // 
            this.path_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path_text_box.Location = new System.Drawing.Point(93, 30);
            this.path_text_box.Name = "path_text_box";
            this.path_text_box.Size = new System.Drawing.Size(429, 20);
            this.path_text_box.TabIndex = 1;
            this.path_text_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Path_text_box_mouse_click);
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileName = "Dynamic Link Library Picker";
            this.open_file_dialog.Filter = "Dynamic Link Library|*.dll";
            this.open_file_dialog.SupportMultiDottedExtensions = true;
            this.open_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_file_dialog_file_ok);
            // 
            // menu_strip
            // 
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.environmentToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(534, 24);
            this.menu_strip.TabIndex = 6;
            this.menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // environmentToolStripMenuItem
            // 
            this.environmentToolStripMenuItem.Name = "environmentToolStripMenuItem";
            this.environmentToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.environmentToolStripMenuItem.Text = "Environment";
            this.environmentToolStripMenuItem.Click += new System.EventHandler(this.Environment_tool_strip_menu_Item_click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_tool_Strip_menu_item_click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // inputs_button
            // 
            this.inputs_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputs_button.Location = new System.Drawing.Point(366, 83);
            this.inputs_button.Name = "inputs_button";
            this.inputs_button.Size = new System.Drawing.Size(75, 23);
            this.inputs_button.TabIndex = 7;
            this.inputs_button.Text = "Inputs";
            this.inputs_button.UseVisualStyleBackColor = true;
            this.inputs_button.Click += new System.EventHandler(this.Inputs_button_click);
            // 
            // Debugger
            // 
            this.AcceptButton = this.execute_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_button;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.inputs_button);
            this.Controls.Add(this.path_text_box);
            this.Controls.Add(this.class_combo_box);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.properties_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.menu_strip);
            this.MainMenuStrip = this.menu_strip;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Debugger";
            this.Text = "DLL Debugger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Debugger_FormClosing);
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button properties_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.ComboBox class_combo_box;
        private System.Windows.Forms.TextBox path_text_box;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button inputs_button;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

