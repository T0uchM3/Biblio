namespace Biblio
{
    partial class Access
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
            this.button1 = new System.Windows.Forms.Button();
            this.libPwd = new Biblio.RoundTf();
            this.libName = new Biblio.RoundTf();
            ((System.ComponentModel.ISupportInitialize)(this.libPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Biblio.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libPwd
            // 
            this.libPwd.Location = new System.Drawing.Point(117, 192);
            this.libPwd.Name = "libPwd";
            this.libPwd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.libPwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.libPwd.Properties.Appearance.Options.UseBackColor = true;
            this.libPwd.Properties.Appearance.Options.UseFont = true;
            this.libPwd.Properties.AutoHeight = false;
            this.libPwd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.libPwd.Properties.NullText = "Librarian password...";
            this.libPwd.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.libPwd.Properties.UseSystemPasswordChar = true;
            this.libPwd.Size = new System.Drawing.Size(204, 44);
            this.libPwd.TabIndex = 6;
            // 
            // libName
            // 
            this.libName.Location = new System.Drawing.Point(117, 101);
            this.libName.Name = "libName";
            this.libName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.libName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.libName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.libName.Properties.Appearance.Options.UseBackColor = true;
            this.libName.Properties.Appearance.Options.UseFont = true;
            this.libName.Properties.Appearance.Options.UseForeColor = true;
            this.libName.Properties.AutoHeight = false;
            this.libName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.libName.Properties.NullText = "Librarian name...";
            this.libName.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.libName.Size = new System.Drawing.Size(204, 44);
            this.libName.TabIndex = 5;
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Biblio.Properties.Resources.illustration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.libPwd);
            this.Controls.Add(this.libName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Access";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Access";
            this.Load += new System.EventHandler(this.Access_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundTf libName;
        private RoundTf libPwd;
        private System.Windows.Forms.Button button1;
    }
}