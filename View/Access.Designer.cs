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
            this.libName = new Biblio.RoundTf();
            this.libPwd = new Biblio.RoundTf();
            ((System.ComponentModel.ISupportInitialize)(this.libName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // libName
            // 
            this.libName.Location = new System.Drawing.Point(117, 101);
            this.libName.Name = "libName";
            this.libName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(164)))));
            this.libName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.libName.Properties.Appearance.Options.UseBackColor = true;
            this.libName.Properties.Appearance.Options.UseForeColor = true;
            this.libName.Properties.AutoHeight = false;
            this.libName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.libName.Properties.NullText = "Librarian name...";
            this.libName.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.libName.Size = new System.Drawing.Size(204, 44);
            this.libName.TabIndex = 5;
            // 
            // libPwd
            // 
            this.libPwd.Location = new System.Drawing.Point(117, 192);
            this.libPwd.Name = "libPwd";
            this.libPwd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(164)))));
            this.libPwd.Properties.Appearance.Options.UseBackColor = true;
            this.libPwd.Properties.AutoHeight = false;
            this.libPwd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.libPwd.Properties.NullText = "Librarian password...";
            this.libPwd.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.libPwd.Properties.UseSystemPasswordChar = true;
            this.libPwd.Size = new System.Drawing.Size(204, 44);
            this.libPwd.TabIndex = 6;
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(438, 334);
            this.Controls.Add(this.libPwd);
            this.Controls.Add(this.libName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Access";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Access";
            this.Load += new System.EventHandler(this.Access_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libPwd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundTf libName;
        private RoundTf libPwd;
    }
}