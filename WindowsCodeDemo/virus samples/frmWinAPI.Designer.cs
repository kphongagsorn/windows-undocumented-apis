namespace windowsDemo
{
    partial class frmWinAPI
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
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnSwapMouse = new System.Windows.Forms.Button();
            this.btnReturnMouse = new System.Windows.Forms.Button();
            this.cmdStoredProc = new System.Windows.Forms.Button();
            this.deleteFilebtn = new System.Windows.Forms.Button();
            this.findVolumesbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(26, 35);
            this.btnDemo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(136, 19);
            this.btnDemo.TabIndex = 0;
            this.btnDemo.Text = "Disable Minimize Button";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnSwapMouse
            // 
            this.btnSwapMouse.Location = new System.Drawing.Point(26, 67);
            this.btnSwapMouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwapMouse.Name = "btnSwapMouse";
            this.btnSwapMouse.Size = new System.Drawing.Size(136, 19);
            this.btnSwapMouse.TabIndex = 1;
            this.btnSwapMouse.Text = "Swap Mouse";
            this.btnSwapMouse.UseVisualStyleBackColor = true;
            this.btnSwapMouse.Click += new System.EventHandler(this.btnSwapMouse_Click);
            // 
            // btnReturnMouse
            // 
            this.btnReturnMouse.Location = new System.Drawing.Point(26, 102);
            this.btnReturnMouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnMouse.Name = "btnReturnMouse";
            this.btnReturnMouse.Size = new System.Drawing.Size(136, 19);
            this.btnReturnMouse.TabIndex = 2;
            this.btnReturnMouse.Text = "Return Mouse";
            this.btnReturnMouse.UseVisualStyleBackColor = true;
            this.btnReturnMouse.Click += new System.EventHandler(this.btnReturnMouse_Click);
            // 
            // cmdStoredProc
            // 
            this.cmdStoredProc.Location = new System.Drawing.Point(26, 136);
            this.cmdStoredProc.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStoredProc.Name = "cmdStoredProc";
            this.cmdStoredProc.Size = new System.Drawing.Size(136, 19);
            this.cmdStoredProc.TabIndex = 3;
            this.cmdStoredProc.Text = "Run Stored Proc";
            this.cmdStoredProc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdStoredProc.UseVisualStyleBackColor = true;
            this.cmdStoredProc.Click += new System.EventHandler(this.cmdStoredProc_Click);
            // 
            // deleteFilebtn
            // 
            this.deleteFilebtn.Location = new System.Drawing.Point(26, 171);
            this.deleteFilebtn.Name = "deleteFilebtn";
            this.deleteFilebtn.Size = new System.Drawing.Size(136, 23);
            this.deleteFilebtn.TabIndex = 4;
            this.deleteFilebtn.Text = "Delete File";
            this.deleteFilebtn.UseVisualStyleBackColor = true;
            this.deleteFilebtn.Click += new System.EventHandler(this.deleteFilebtn_Click);
            // 
            // findVolumesbtn
            // 
            this.findVolumesbtn.Location = new System.Drawing.Point(26, 208);
            this.findVolumesbtn.Name = "findVolumesbtn";
            this.findVolumesbtn.Size = new System.Drawing.Size(136, 23);
            this.findVolumesbtn.TabIndex = 5;
            this.findVolumesbtn.Text = "Find Volumes";
            this.findVolumesbtn.UseVisualStyleBackColor = true;
            this.findVolumesbtn.Click += new System.EventHandler(this.findVolumesbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Wallpaper";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.setDeskWallpaperbtn_Click);
            // 
            // frmWinAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findVolumesbtn);
            this.Controls.Add(this.deleteFilebtn);
            this.Controls.Add(this.cmdStoredProc);
            this.Controls.Add(this.btnReturnMouse);
            this.Controls.Add(this.btnSwapMouse);
            this.Controls.Add(this.btnDemo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWinAPI";
            this.Text = "Code Demo for Calling Windows API\'s";
            this.Load += new System.EventHandler(this.frmWinAPI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnSwapMouse;
        private System.Windows.Forms.Button btnReturnMouse;
        private System.Windows.Forms.Button cmdStoredProc;
        private System.Windows.Forms.Button deleteFilebtn;
        private System.Windows.Forms.Button findVolumesbtn;
        private System.Windows.Forms.Button button1;
    }
}