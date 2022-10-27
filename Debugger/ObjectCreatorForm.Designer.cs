namespace Debugger
{
    partial class ObjectCreatorForm
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
            this.object_data_grid_view = new System.Windows.Forms.DataGridView();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.object_data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // object_data_grid_view
            // 
            this.object_data_grid_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.object_data_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyName,
            this.PropertyType,
            this.PropertyValue});
            this.object_data_grid_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.object_data_grid_view.Location = new System.Drawing.Point(12, 12);
            this.object_data_grid_view.Name = "object_data_grid_view";
            this.object_data_grid_view.Size = new System.Drawing.Size(560, 208);
            this.object_data_grid_view.TabIndex = 0;
            this.object_data_grid_view.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Object_data_grid_view_cell_mouse_click);
            // 
            // PropertyName
            // 
            this.PropertyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyName.DataPropertyName = "PropertyName";
            this.PropertyName.HeaderText = "Name";
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ToolTipText = "Name";
            // 
            // PropertyType
            // 
            this.PropertyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyType.DataPropertyName = "PropertyType";
            this.PropertyType.HeaderText = "Type";
            this.PropertyType.Name = "PropertyType";
            this.PropertyType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PropertyType.ToolTipText = "Type";
            // 
            // PropertyValue
            // 
            this.PropertyValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyValue.DataPropertyName = "PropertyValue";
            this.PropertyValue.HeaderText = "Value";
            this.PropertyValue.Name = "PropertyValue";
            this.PropertyValue.ToolTipText = "Value";
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(497, 226);
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
            this.cancel_button.Location = new System.Drawing.Point(416, 226);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // ObjectCreatorForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.object_data_grid_view);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "ObjectCreatorForm";
            this.Text = "Object creator";
            ((System.ComponentModel.ISupportInitialize)(this.object_data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView object_data_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewComboBoxColumn PropertyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyValue;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}