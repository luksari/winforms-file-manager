namespace mvp_file_manager
{
    partial class View
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
            this.miniTCPanel2 = new mvp_file_manager.MiniTCPanelView();
            this.miniTCPanel1 = new mvp_file_manager.MiniTCPanelView();
            this.SuspendLayout();
            // 
            // miniTCPanel2
            // 
            this.miniTCPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.miniTCPanel2.CurrentPath = "";
            this.miniTCPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.miniTCPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miniTCPanel2.Location = new System.Drawing.Point(360, 0);
            this.miniTCPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.miniTCPanel2.Name = "miniTCPanel2";
            this.miniTCPanel2.Size = new System.Drawing.Size(359, 764);
            this.miniTCPanel2.TabIndex = 1;
            // 
            // miniTCPanel1
            // 
            this.miniTCPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.miniTCPanel1.CurrentPath = "";
            this.miniTCPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.miniTCPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miniTCPanel1.Location = new System.Drawing.Point(0, 0);
            this.miniTCPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.miniTCPanel1.Name = "miniTCPanel1";
            this.miniTCPanel1.Size = new System.Drawing.Size(360, 764);
            this.miniTCPanel1.TabIndex = 0;
            // 
            // fileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 764);
            this.Controls.Add(this.miniTCPanel2);
            this.Controls.Add(this.miniTCPanel1);
            this.Name = "fileManager";
            this.Text = "File Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private MiniTCPanelView miniTCPanel1;
        private MiniTCPanelView miniTCPanel2;
    }
}

