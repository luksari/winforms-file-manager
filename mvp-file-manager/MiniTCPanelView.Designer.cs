namespace mvp_file_manager
{
    partial class MiniTCPanelView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPath.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxPath.Location = new System.Drawing.Point(98, 24);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(370, 24);
            this.textBoxPath.TabIndex = 0;
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Coolvetica Rg", 10F);
            this.labelPath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPath.Location = new System.Drawing.Point(6, 27);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 17);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Path:";
            // 
            // labelDirectory
            // 
            this.labelDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Font = new System.Drawing.Font("Coolvetica Rg", 10F);
            this.labelDirectory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDirectory.Location = new System.Drawing.Point(6, 83);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(63, 17);
            this.labelDirectory.TabIndex = 2;
            this.labelDirectory.Text = "Directory:";
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDrives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.comboBoxDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDrives.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(98, 78);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(370, 25);
            this.comboBoxDrives.TabIndex = 3;
            this.comboBoxDrives.DropDown += new System.EventHandler(this.LoadDrives);
            this.comboBoxDrives.SelectedValueChanged += new System.EventHandler(this.ChangeDrive);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.listBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFiles.Font = new System.Drawing.Font("Arial", 10.25F);
            this.listBoxFiles.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 153);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(486, 610);
            this.listBoxFiles.TabIndex = 4;
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.DoubleClick);
            // 
            // MiniTCPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Font = new System.Drawing.Font("COCOGOOSE", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MiniTCPanelView";
            this.Size = new System.Drawing.Size(486, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}
