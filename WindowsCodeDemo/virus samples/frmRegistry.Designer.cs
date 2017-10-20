namespace windowsDemo
{
    partial class frmRegistry
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
            this.btnRead = new System.Windows.Forms.Button();
            this.txtRegistrySubKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistryKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(52, 211);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtRegistrySubKey
            // 
            this.txtRegistrySubKey.Location = new System.Drawing.Point(42, 75);
            this.txtRegistrySubKey.Name = "txtRegistrySubKey";
            this.txtRegistrySubKey.Size = new System.Drawing.Size(620, 22);
            this.txtRegistrySubKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registry Sub Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registry Key Name";
            // 
            // txtRegistryKey
            // 
            this.txtRegistryKey.Location = new System.Drawing.Point(42, 169);
            this.txtRegistryKey.Name = "txtRegistryKey";
            this.txtRegistryKey.Size = new System.Drawing.Size(632, 22);
            this.txtRegistryKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registry Key";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(52, 281);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(139, 22);
            this.txtValue.TabIndex = 5;
            // 
            // frmRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistryKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistrySubKey);
            this.Controls.Add(this.btnRead);
            this.Name = "frmRegistry";
            this.Text = "Code Demo for Reading the Registry";
            this.Load += new System.EventHandler(this.frmRegistry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtRegistrySubKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistryKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
    }
}