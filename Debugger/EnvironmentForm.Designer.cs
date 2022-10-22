namespace Debugger
{
    partial class EnvironmentForm
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
            this.instance_text_box = new System.Windows.Forms.TextBox();
            this.client_id_text_box = new System.Windows.Forms.TextBox();
            this.client_secret_text_box = new System.Windows.Forms.TextBox();
            this.use_unique_instance_check_box = new System.Windows.Forms.CheckBox();
            this.folder_browser_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.token_cache_path_text_box = new System.Windows.Forms.TextBox();
            this.instance_label = new System.Windows.Forms.Label();
            this.client_id_label = new System.Windows.Forms.Label();
            this.client_secret_label = new System.Windows.Forms.Label();
            this.token_cache_path_label = new System.Windows.Forms.Label();
            this.error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(405, 234);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(324, 234);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // instance_text_box
            // 
            this.instance_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instance_text_box.Location = new System.Drawing.Point(4, 17);
            this.instance_text_box.Name = "instance_text_box";
            this.instance_text_box.Size = new System.Drawing.Size(476, 20);
            this.instance_text_box.TabIndex = 1;
            // 
            // client_id_text_box
            // 
            this.client_id_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_id_text_box.Location = new System.Drawing.Point(4, 56);
            this.client_id_text_box.Name = "client_id_text_box";
            this.client_id_text_box.Size = new System.Drawing.Size(476, 20);
            this.client_id_text_box.TabIndex = 1;
            // 
            // client_secret_text_box
            // 
            this.client_secret_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_secret_text_box.Location = new System.Drawing.Point(4, 95);
            this.client_secret_text_box.Name = "client_secret_text_box";
            this.client_secret_text_box.Size = new System.Drawing.Size(476, 20);
            this.client_secret_text_box.TabIndex = 1;
            // 
            // use_unique_instance_check_box
            // 
            this.use_unique_instance_check_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.use_unique_instance_check_box.AutoSize = true;
            this.use_unique_instance_check_box.Location = new System.Drawing.Point(4, 121);
            this.use_unique_instance_check_box.Name = "use_unique_instance_check_box";
            this.use_unique_instance_check_box.Size = new System.Drawing.Size(123, 17);
            this.use_unique_instance_check_box.TabIndex = 2;
            this.use_unique_instance_check_box.Text = "Use unique instance";
            this.use_unique_instance_check_box.UseVisualStyleBackColor = true;
            // 
            // token_cache_path_text_box
            // 
            this.token_cache_path_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.token_cache_path_text_box.Location = new System.Drawing.Point(4, 157);
            this.token_cache_path_text_box.Name = "token_cache_path_text_box";
            this.token_cache_path_text_box.ReadOnly = true;
            this.token_cache_path_text_box.Size = new System.Drawing.Size(476, 20);
            this.token_cache_path_text_box.TabIndex = 3;
            this.token_cache_path_text_box.Click += new System.EventHandler(this.Token_cache_path_text_box_click);
            // 
            // instance_label
            // 
            this.instance_label.AutoSize = true;
            this.instance_label.Location = new System.Drawing.Point(4, 1);
            this.instance_label.Name = "instance_label";
            this.instance_label.Size = new System.Drawing.Size(48, 13);
            this.instance_label.TabIndex = 4;
            this.instance_label.Text = "Instance";
            // 
            // client_id_label
            // 
            this.client_id_label.AutoSize = true;
            this.client_id_label.Location = new System.Drawing.Point(4, 40);
            this.client_id_label.Name = "client_id_label";
            this.client_id_label.Size = new System.Drawing.Size(45, 13);
            this.client_id_label.TabIndex = 5;
            this.client_id_label.Text = "Client Id";
            // 
            // client_secret_label
            // 
            this.client_secret_label.AutoSize = true;
            this.client_secret_label.Location = new System.Drawing.Point(4, 79);
            this.client_secret_label.Name = "client_secret_label";
            this.client_secret_label.Size = new System.Drawing.Size(65, 13);
            this.client_secret_label.TabIndex = 6;
            this.client_secret_label.Text = "Client secret";
            // 
            // token_cache_path_label
            // 
            this.token_cache_path_label.AutoSize = true;
            this.token_cache_path_label.Location = new System.Drawing.Point(4, 141);
            this.token_cache_path_label.Name = "token_cache_path_label";
            this.token_cache_path_label.Size = new System.Drawing.Size(95, 13);
            this.token_cache_path_label.TabIndex = 7;
            this.token_cache_path_label.Text = "Token cache path";
            // 
            // error_provider
            // 
            this.error_provider.ContainerControl = this;
            // 
            // EnvironmentForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.token_cache_path_label);
            this.Controls.Add(this.client_secret_label);
            this.Controls.Add(this.client_id_label);
            this.Controls.Add(this.instance_label);
            this.Controls.Add(this.token_cache_path_text_box);
            this.Controls.Add(this.use_unique_instance_check_box);
            this.Controls.Add(this.client_secret_text_box);
            this.Controls.Add(this.client_id_text_box);
            this.Controls.Add(this.instance_text_box);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnvironmentForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Environment";
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox instance_text_box;
        private System.Windows.Forms.TextBox client_id_text_box;
        private System.Windows.Forms.TextBox client_secret_text_box;
        private System.Windows.Forms.CheckBox use_unique_instance_check_box;
        private System.Windows.Forms.FolderBrowserDialog folder_browser_dialog;
        private System.Windows.Forms.TextBox token_cache_path_text_box;
        private System.Windows.Forms.Label instance_label;
        private System.Windows.Forms.Label client_id_label;
        private System.Windows.Forms.Label client_secret_label;
        private System.Windows.Forms.Label token_cache_path_label;
        private System.Windows.Forms.ErrorProvider error_provider;
    }
}