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
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bookLibBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.visitorBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.topLayer = new System.Windows.Forms.Panel();
            this.sizer = new System.Windows.Forms.Label();
            this.biblioDataSet = new Biblio.BiblioDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.topLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel6);
            this.sideBar.Controls.Add(this.panel8);
            this.sideBar.Controls.Add(this.panel9);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel7);
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
            this.panel1.Size = new System.Drawing.Size(197, 29);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 48);
            this.panel2.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dashboard.Image = global::Biblio.Properties.Resources.stats__6_;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(-13, -3);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.Dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dashboard.Size = new System.Drawing.Size(311, 57);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "    Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseCompatibleTextRendering = true;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bookLibBtn);
            this.panel6.Location = new System.Drawing.Point(0, 109);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 48);
            this.panel6.TabIndex = 7;
            // 
            // bookLibBtn
            // 
            this.bookLibBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bookLibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookLibBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLibBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookLibBtn.Image = global::Biblio.Properties.Resources.icons8_book_24px;
            this.bookLibBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookLibBtn.Location = new System.Drawing.Point(-13, -3);
            this.bookLibBtn.Name = "bookLibBtn";
            this.bookLibBtn.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.bookLibBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookLibBtn.Size = new System.Drawing.Size(311, 57);
            this.bookLibBtn.TabIndex = 6;
            this.bookLibBtn.Text = "    Book Library";
            this.bookLibBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookLibBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookLibBtn.UseCompatibleTextRendering = true;
            this.bookLibBtn.UseVisualStyleBackColor = true;
            this.bookLibBtn.Click += new System.EventHandler(this.bookLibBtn_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button4);
            this.panel8.Location = new System.Drawing.Point(0, 180);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 48);
            this.panel8.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = global::Biblio.Properties.Resources.calendar__1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-13, -3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(311, 57);
            this.button4.TabIndex = 6;
            this.button4.Text = "    Dashboard";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.borrowBtn);
            this.panel9.Location = new System.Drawing.Point(0, 251);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 48);
            this.panel9.TabIndex = 8;
            // 
            // borrowBtn
            // 
            this.borrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.borrowBtn.Image = global::Biblio.Properties.Resources.icons8_return_book_24px;
            this.borrowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.Location = new System.Drawing.Point(-13, -3);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.borrowBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.borrowBtn.Size = new System.Drawing.Size(311, 57);
            this.borrowBtn.TabIndex = 6;
            this.borrowBtn.Text = "    Borrowed Books";
            this.borrowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.borrowBtn.UseCompatibleTextRendering = true;
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.visitorBtn);
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 48);
            this.panel3.TabIndex = 9;
            // 
            // visitorBtn
            // 
            this.visitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.visitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.visitorBtn.Image = global::Biblio.Properties.Resources.user__3_;
            this.visitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitorBtn.Location = new System.Drawing.Point(-12, -3);
            this.visitorBtn.Name = "visitorBtn";
            this.visitorBtn.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.visitorBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.visitorBtn.Size = new System.Drawing.Size(311, 57);
            this.visitorBtn.TabIndex = 6;
            this.visitorBtn.Text = "    Visitors";
            this.visitorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visitorBtn.UseCompatibleTextRendering = true;
            this.visitorBtn.UseVisualStyleBackColor = true;
            this.visitorBtn.Click += new System.EventHandler(this.visitorBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button3);
            this.panel7.Location = new System.Drawing.Point(0, 393);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 48);
            this.panel7.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::Biblio.Properties.Resources.cogwheel__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-13, -3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(311, 57);
            this.button3.TabIndex = 6;
            this.button3.Text = "    Dashboard";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // topLayer
            // 
            this.topLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.topLayer.Controls.Add(this.sizer);
            this.topLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayer.Location = new System.Drawing.Point(0, 0);
            this.topLayer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.topLayer.Name = "topLayer";
            this.topLayer.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.topLayer.Size = new System.Drawing.Size(800, 500);
            this.topLayer.TabIndex = 5;
            this.topLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.topLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.topLayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // sizer
            // 
            this.sizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizer.BackColor = System.Drawing.Color.Black;
            this.sizer.Location = new System.Drawing.Point(776, 476);
            this.sizer.Name = "sizer";
            this.sizer.Size = new System.Drawing.Size(25, 24);
            this.sizer.TabIndex = 1;
            this.sizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.sizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.sizer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
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
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.topLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel topLayer;
        private System.Windows.Forms.Label sizer;
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bookLibBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button visitorBtn;
    }
}