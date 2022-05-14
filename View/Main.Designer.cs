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
            this.nameLab = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bookBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.visitorBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.topLayer = new System.Windows.Forms.Panel();
            this.sizer = new System.Windows.Forms.Label();
            this.delayExecTimer = new System.Windows.Forms.Timer(this.components);
            this.biblioDataSet = new Biblio.BiblioDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorTableAdapter = new Biblio.BiblioDataSetTableAdapters.VisitorTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.topLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.sideBar.Controls.Add(this.nameLab);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel9);
            this.sideBar.Controls.Add(this.panel7);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.sideBar.MinimumSize = new System.Drawing.Size(68, 500);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(68, 500);
            this.sideBar.TabIndex = 3;
            this.sideBar.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.sideBar.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // nameLab
            // 
            this.nameLab.Font = new System.Drawing.Font("Century Schoolbook", 30F);
            this.nameLab.ForeColor = System.Drawing.Color.White;
            this.nameLab.Image = global::Biblio.Properties.Resources.circle__2_;
            this.nameLab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLab.Location = new System.Drawing.Point(0, 0);
            this.nameLab.Margin = new System.Windows.Forms.Padding(0);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(216, 70);
            this.nameLab.TabIndex = 11;
            this.nameLab.Text = " ";
            this.nameLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLab.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.nameLab.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 10);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashBtn);
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 48);
            this.panel2.TabIndex = 5;
            // 
            // dashBtn
            // 
            this.dashBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashBtn.Image = global::Biblio.Properties.Resources.stats__6_;
            this.dashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBtn.Location = new System.Drawing.Point(-13, -3);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.dashBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dashBtn.Size = new System.Drawing.Size(311, 57);
            this.dashBtn.TabIndex = 6;
            this.dashBtn.Text = "    Dashboard";
            this.dashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashBtn.UseCompatibleTextRendering = true;
            this.dashBtn.UseVisualStyleBackColor = true;
            this.dashBtn.Click += new System.EventHandler(this.dashBtn_Click);
            this.dashBtn.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.dashBtn.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bookBtn);
            this.panel5.Location = new System.Drawing.Point(0, 160);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 48);
            this.panel5.TabIndex = 13;
            // 
            // bookBtn
            // 
            this.bookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookBtn.Image = global::Biblio.Properties.Resources.icons8_book_24px;
            this.bookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBtn.Location = new System.Drawing.Point(-12, -3);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.bookBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookBtn.Size = new System.Drawing.Size(311, 57);
            this.bookBtn.TabIndex = 6;
            this.bookBtn.Text = "    Book Library";
            this.bookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookBtn.UseCompatibleTextRendering = true;
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookLibBtn_Click);
            this.bookBtn.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.bookBtn.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.visitorBtn);
            this.panel3.Location = new System.Drawing.Point(0, 231);
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
            this.visitorBtn.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.visitorBtn.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.borrowBtn);
            this.panel9.Location = new System.Drawing.Point(0, 302);
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
            this.borrowBtn.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.borrowBtn.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.exitBtn);
            this.panel7.Location = new System.Drawing.Point(0, 373);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 48);
            this.panel7.TabIndex = 10;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Image = global::Biblio.Properties.Resources.power_button;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(-13, -3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.exitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBtn.Size = new System.Drawing.Size(311, 57);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "    Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseCompatibleTextRendering = true;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.sideBarEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.sideBarLeave2);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // topLayer
            // 
            this.topLayer.BackColor = System.Drawing.Color.White;
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
            this.sizer.BackColor = System.Drawing.Color.LightGray;
            this.sizer.Location = new System.Drawing.Point(776, 476);
            this.sizer.Name = "sizer";
            this.sizer.Size = new System.Drawing.Size(25, 24);
            this.sizer.TabIndex = 1;
            this.sizer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.sizer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.sizer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // delayExecTimer
            // 
            this.delayExecTimer.Interval = 5;
            this.delayExecTimer.Tick += new System.EventHandler(this.timerTick2);
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
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataMember = "Visitor";
            this.visitorBindingSource.DataSource = this.biblioDataSet;
            // 
            // visitorTableAdapter
            // 
            this.visitorTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 26;
            this.barManager1.ShowScreenTipsInMenus = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
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
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.topLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashBtn;
        public System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel topLayer;
        private System.Windows.Forms.Label sizer;
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button visitorBtn;
        private System.Windows.Forms.Timer delayExecTimer;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private BiblioDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bookBtn;
    }
}