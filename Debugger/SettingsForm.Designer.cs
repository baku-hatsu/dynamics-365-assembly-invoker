namespace Debugger
{
    partial class SettingsForm
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
            this.namespaces_group_box = new System.Windows.Forms.GroupBox();
            this.namespace_remove_button = new System.Windows.Forms.Button();
            this.namespaces_list_box = new System.Windows.Forms.ListBox();
            this.namespace_add_text_box = new System.Windows.Forms.TextBox();
            this.namespace_add_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.namespaces_group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // namespaces_group_box
            // 
            this.namespaces_group_box.Controls.Add(this.namespace_remove_button);
            this.namespaces_group_box.Controls.Add(this.namespaces_list_box);
            this.namespaces_group_box.Controls.Add(this.namespace_add_text_box);
            this.namespaces_group_box.Controls.Add(this.namespace_add_button);
            this.namespaces_group_box.Location = new System.Drawing.Point(4, 4);
            this.namespaces_group_box.Name = "namespaces_group_box";
            this.namespaces_group_box.Size = new System.Drawing.Size(346, 279);
            this.namespaces_group_box.TabIndex = 0;
            this.namespaces_group_box.TabStop = false;
            this.namespaces_group_box.Text = "Namespaces";
            // 
            // namespace_remove_button
            // 
            this.namespace_remove_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namespace_remove_button.Location = new System.Drawing.Point(184, 250);
            this.namespace_remove_button.Name = "namespace_remove_button";
            this.namespace_remove_button.Size = new System.Drawing.Size(75, 23);
            this.namespace_remove_button.TabIndex = 3;
            this.namespace_remove_button.Text = "Remove";
            this.namespace_remove_button.UseVisualStyleBackColor = true;
            this.namespace_remove_button.Click += new System.EventHandler(this.Namespace_remove_button_click);
            // 
            // namespaces_list_box
            // 
            this.namespaces_list_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespaces_list_box.FormattingEnabled = true;
            this.namespaces_list_box.Location = new System.Drawing.Point(6, 21);
            this.namespaces_list_box.Name = "namespaces_list_box";
            this.namespaces_list_box.Size = new System.Drawing.Size(334, 225);
            this.namespaces_list_box.TabIndex = 2;
            // 
            // namespace_add_text_box
            // 
            this.namespace_add_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespace_add_text_box.Location = new System.Drawing.Point(6, 251);
            this.namespace_add_text_box.Name = "namespace_add_text_box";
            this.namespace_add_text_box.Size = new System.Drawing.Size(172, 20);
            this.namespace_add_text_box.TabIndex = 1;
            // 
            // namespace_add_button
            // 
            this.namespace_add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namespace_add_button.Location = new System.Drawing.Point(265, 250);
            this.namespace_add_button.Name = "namespace_add_button";
            this.namespace_add_button.Size = new System.Drawing.Size(75, 23);
            this.namespace_add_button.TabIndex = 0;
            this.namespace_add_button.Text = "Add";
            this.namespace_add_button.UseVisualStyleBackColor = true;
            this.namespace_add_button.Click += new System.EventHandler(this.Namespace_add_button_click);
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_button.Location = new System.Drawing.Point(505, 334);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Save_button_click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(424, 334);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.namespaces_group_box);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Settings";
            this.namespaces_group_box.ResumeLayout(false);
            this.namespaces_group_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox namespaces_group_box;
        private System.Windows.Forms.ListBox namespaces_list_box;
        private System.Windows.Forms.TextBox namespace_add_text_box;
        private System.Windows.Forms.Button namespace_add_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button namespace_remove_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}