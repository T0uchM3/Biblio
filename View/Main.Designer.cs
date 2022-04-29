namespace Biblio
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookLibrary = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.topLayer = new System.Windows.Forms.Panel();
            this.sizer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.biblioDataSet = new Biblio.BiblioDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Biblio.BiblioDataSetTableAdapters.BookTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.topLayer.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(200, 700);
            this.sideBar.MinimumSize = new System.Drawing.Size(68, 700);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(68, 700);
            this.sideBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 48);
            this.panel2.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dashboard.Location = new System.Drawing.Point(-12, -16);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(219, 84);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "    D        Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BookLibrary);
            this.panel3.Location = new System.Drawing.Point(3, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 48);
            this.panel3.TabIndex = 7;
            // 
            // BookLibrary
            // 
            this.BookLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.BookLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLibrary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BookLibrary.Location = new System.Drawing.Point(-12, -9);
            this.BookLibrary.Name = "BookLibrary";
            this.BookLibrary.Size = new System.Drawing.Size(212, 68);
            this.BookLibrary.TabIndex = 6;
            this.BookLibrary.Text = "    BL      Book Library";
            this.BookLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookLibrary.UseVisualStyleBackColor = true;
            this.BookLibrary.Click += new System.EventHandler(this.BookLibrary_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(3, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 48);
            this.panel5.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(-12, -9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "    M      Members";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // topLayer
            // 
            this.topLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.topLayer.Controls.Add(this.pictureBox1);
            this.topLayer.Controls.Add(this.labelControl1);
            this.topLayer.Controls.Add(this.sizer);
            this.topLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayer.Location = new System.Drawing.Point(0, 0);
            this.topLayer.Name = "topLayer";
            this.topLayer.Size = new System.Drawing.Size(800, 500);
            this.topLayer.TabIndex = 5;
            // 
            // sizer
            // 
            this.sizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizer.BackColor = System.Drawing.Color.Transparent;
            this.sizer.Location = new System.Drawing.Point(774, 475);
            this.sizer.Name = "sizer";
            this.sizer.Size = new System.Drawing.Size(25, 24);
            this.sizer.TabIndex = 1;
            this.sizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.sizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.sizer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBorrow);
            this.panel4.Location = new System.Drawing.Point(3, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 48);
            this.panel4.TabIndex = 9;
            // 
            // btnBorrow
            // 
            this.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrow.Location = new System.Drawing.Point(-12, -9);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(212, 68);
            this.btnBorrow.TabIndex = 6;
            this.btnBorrow.Text = "     B       Borrow";
            this.btnBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(785, 32);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.labelControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.labelControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // biblioDataSet
            // 
            this.biblioDataSet.DataSetName = "BiblioDataSet";
            this.biblioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.biblioDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ImageLocation = "C:\\Users\\adolf\\Source\\Repos\\Biblio\\bg";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.topLayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.topLayer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BookLibrary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel topLayer;
        private System.Windows.Forms.Label sizer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBorrow;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BiblioDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}