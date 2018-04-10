namespace mvp_file_manager
{
    partial class fileManager
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
            this.miniTCPanelView2 = new mvp_file_manager.MiniTCPanelView();
            this.miniTCPanelView1 = new mvp_file_manager.MiniTCPanelView();
            this.SuspendLayout();
            // 
            // miniTCPanelView2
            // 
            this.miniTCPanelView2.AutoSize = true;
            this.miniTCPanelView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.miniTCPanelView2.CurrentPath = "";
            this.miniTCPanelView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.miniTCPanelView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miniTCPanelView2.Location = new System.Drawing.Point(481, 0);
            this.miniTCPanelView2.Name = "miniTCPanelView2";
            this.miniTCPanelView2.Size = new System.Drawing.Size(486, 740);
            this.miniTCPanelView2.TabIndex = 1;
            // 
            // miniTCPanelView1
            // 
            this.miniTCPanelView1.AutoSize = true;
            this.miniTCPanelView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.miniTCPanelView1.CurrentPath = "";
            this.miniTCPanelView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.miniTCPanelView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miniTCPanelView1.Location = new System.Drawing.Point(0, 0);
            this.miniTCPanelView1.Name = "miniTCPanelView1";
            this.miniTCPanelView1.Size = new System.Drawing.Size(486, 740);
            this.miniTCPanelView1.TabIndex = 0;
            // 
            // fileManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 740);
            this.Controls.Add(this.miniTCPanelView2);
            this.Controls.Add(this.miniTCPanelView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fileManager";
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiniTCPanelView miniTCPanelView1;
        private MiniTCPanelView miniTCPanelView2;
    }
}

