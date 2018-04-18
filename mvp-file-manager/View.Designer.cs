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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.miniTCPanel2 = new mvp_file_manager.MiniTCPanelView();
            this.miniTCPanel1 = new mvp_file_manager.MiniTCPanelView();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(376, 135);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 46);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.buttonClicked);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Location = new System.Drawing.Point(457, 135);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 46);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.buttonClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(538, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.buttonClicked);
            // 
            // miniTCPanel2
            // 
            this.miniTCPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.miniTCPanel2.CurrentPath = "";
            this.miniTCPanel2.Dir = null;
            this.miniTCPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.miniTCPanel2.Drives = null;
            this.miniTCPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miniTCPanel2.Location = new System.Drawing.Point(495, 0);
            this.miniTCPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.miniTCPanel2.Name = "miniTCPanel2";
            this.miniTCPanel2.SelectedDir = null;
            this.miniTCPanel2.Size = new System.Drawing.Size(496, 796);
            this.miniTCPanel2.TabIndex = 1;
            // 
            // miniTCPanel1
            // 
            this.miniTCPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.miniTCPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.miniTCPanel1.CurrentPath = "";
            this.miniTCPanel1.Dir = null;
            this.miniTCPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.miniTCPanel1.Drives = null;
            this.miniTCPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miniTCPanel1.Location = new System.Drawing.Point(0, 0);
            this.miniTCPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.miniTCPanel1.Name = "miniTCPanel1";
            this.miniTCPanel1.SelectedDir = null;
            this.miniTCPanel1.Size = new System.Drawing.Size(496, 796);
            this.miniTCPanel1.TabIndex = 0;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 796);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.miniTCPanel2);
            this.Controls.Add(this.miniTCPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "File Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private MiniTCPanelView miniTCPanel1;
        private MiniTCPanelView miniTCPanel2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDelete;
    }
}

