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
            this.SuspendLayout();
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(12, 12);
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
            this.properties_button.Location = new System.Drawing.Point(197, 68);
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
            this.close_button.Location = new System.Drawing.Point(116, 126);
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
            this.execute_button.Location = new System.Drawing.Point(197, 126);
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
            this.class_combo_box.Location = new System.Drawing.Point(12, 41);
            this.class_combo_box.Name = "class_combo_box";
            this.class_combo_box.Size = new System.Drawing.Size(260, 21);
            this.class_combo_box.TabIndex = 2;
            this.class_combo_box.SelectedIndexChanged += new System.EventHandler(this.Class_combo_box_selected_index_changed);
            // 
            // path_text_box
            // 
            this.path_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.path_text_box.Location = new System.Drawing.Point(93, 12);
            this.path_text_box.Name = "path_text_box";
            this.path_text_box.Size = new System.Drawing.Size(179, 20);
            this.path_text_box.TabIndex = 1;
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileName = "Dynamic Link Library Picker";
            this.open_file_dialog.Filter = "Dynamic Link Library|*.dll";
            this.open_file_dialog.SupportMultiDottedExtensions = true;
            // 
            // Debugger
            // 
            this.AcceptButton = this.execute_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_button;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.path_text_box);
            this.Controls.Add(this.class_combo_box);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.properties_button);
            this.Controls.Add(this.browse_button);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Debugger";
            this.Text = "DLL Debugger";
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
    }
}

