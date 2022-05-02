namespace Biblio
{
    partial class Books
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colTitle3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPicture3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.biblioDataSet = new Biblio.BiblioDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Biblio.BiblioDataSetTableAdapters.BookTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.roundTf1 = new Biblio.RoundTf();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTitle1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPicture1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPicture1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTitle2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upBtn = new System.Windows.Forms.Button();
            this.imLab = new DevExpress.XtraEditors.LabelControl();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topRoot = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundTf1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.root.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTitle3
            // 
            this.colTitle3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colTitle3.AppearanceHeader.Options.UseFont = true;
            this.colTitle3.FieldName = "Title";
            this.colTitle3.Name = "colTitle3";
            this.colTitle3.Visible = true;
            this.colTitle3.VisibleIndex = 0;
            // 
            // colPicture3
            // 
            this.colPicture3.FieldName = "Picture";
            this.colPicture3.Name = "colPicture3";
            this.colPicture3.Visible = true;
            this.colPicture3.VisibleIndex = 1;
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(268, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Book Tite";
            // 
            // roundTf1
            // 
            this.roundTf1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundTf1.Location = new System.Drawing.Point(20, 27);
            this.roundTf1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.roundTf1.Name = "roundTf1";
            this.roundTf1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.roundTf1.Properties.Appearance.Options.UseBackColor = true;
            this.roundTf1.Properties.AutoHeight = false;
            this.roundTf1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.roundTf1.Properties.NullText = "Title here...";
            this.roundTf1.Size = new System.Drawing.Size(234, 34);
            this.roundTf1.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bookBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 172);
            this.gridControl1.MainView = this.tileView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(845, 342);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView2});
            // 
            // tileView2
            // 
            this.tileView2.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tileView2.Appearance.EmptySpace.Options.UseBackColor = true;
            this.tileView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle3,
            this.colPicture3});
            this.tileView2.GridControl = this.gridControl1;
            this.tileView2.Name = "tileView2";
            this.tileView2.OptionsTiles.ItemSize = new System.Drawing.Size(190, 245);
            this.tileView2.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 100D;
            this.tileView2.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 15D;
            tableRowDefinition2.Length.Value = 100D;
            this.tileView2.TileRows.Add(tableRowDefinition1);
            this.tileView2.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14F);
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.colTitle3;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement1.Text = "colTitle3";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colPicture3;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colPicture3";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView2.TileTemplate.Add(tileViewItemElement1);
            this.tileView2.TileTemplate.Add(tileViewItemElement2);
            // 
            // colTitle1
            // 
            this.colTitle1.FieldName = "Title";
            this.colTitle1.LayoutViewField = this.layoutViewField_colTitle1;
            this.colTitle1.Name = "colTitle1";
            // 
            // layoutViewField_colTitle1
            // 
            this.layoutViewField_colTitle1.EditorPreferredWidth = 158;
            this.layoutViewField_colTitle1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colTitle1.Name = "layoutViewField_colTitle1";
            this.layoutViewField_colTitle1.Size = new System.Drawing.Size(332, 64);
            this.layoutViewField_colTitle1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // colPicture1
            // 
            this.colPicture1.FieldName = "Picture";
            this.colPicture1.LayoutViewField = this.layoutViewField_colPicture1;
            this.colPicture1.Name = "colPicture1";
            // 
            // layoutViewField_colPicture1
            // 
            this.layoutViewField_colPicture1.EditorPreferredWidth = 158;
            this.layoutViewField_colPicture1.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colPicture1.Name = "layoutViewField_colPicture1";
            this.layoutViewField_colPicture1.Size = new System.Drawing.Size(332, 44);
            this.layoutViewField_colPicture1.StartNewLine = true;
            this.layoutViewField_colPicture1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // colTitle2
            // 
            this.colTitle2.FieldName = "Title";
            this.colTitle2.Name = "colTitle2";
            // 
            // colPicture2
            // 
            this.colPicture2.FieldName = "Picture";
            this.colPicture2.Name = "colPicture2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.upBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roundTf1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imLab, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(180, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(180, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.91139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.08861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 147);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(227)))), ((int)(((byte)(81)))));
            this.upBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBtn.Location = new System.Drawing.Point(3, 97);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(268, 47);
            this.upBtn.TabIndex = 17;
            this.upBtn.Text = "Upload Cover";
            this.upBtn.UseVisualStyleBackColor = false;
            this.upBtn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // imLab
            // 
            this.imLab.Appearance.Options.UseTextOptions = true;
            this.imLab.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.imLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imLab.Location = new System.Drawing.Point(3, 69);
            this.imLab.Name = "imLab";
            this.imLab.Size = new System.Drawing.Size(268, 22);
            this.imLab.TabIndex = 13;
            this.imLab.Text = "Book Image";
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.root.ColumnCount = 3;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.0534F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.9466F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.root.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.root.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.root.Controls.Add(this.pictureBox1, 1, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(3, 3);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.root.Size = new System.Drawing.Size(845, 163);
            this.root.TabIndex = 14;
            this.root.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.root.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.root.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(665, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(167, 147);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(182)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(460, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // topRoot
            // 
            this.topRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.topRoot.ColumnCount = 1;
            this.topRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topRoot.Controls.Add(this.gridControl1, 0, 1);
            this.topRoot.Controls.Add(this.root, 0, 0);
            this.topRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRoot.Location = new System.Drawing.Point(0, 0);
            this.topRoot.Name = "topRoot";
            this.topRoot.RowCount = 2;
            this.topRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.68859F));
            this.topRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.31141F));
            this.topRoot.Size = new System.Drawing.Size(851, 517);
            this.topRoot.TabIndex = 15;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 517);
            this.Controls.Add(this.topRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundTf1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.root.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BiblioDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private RoundTf roundTf1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView2;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTitle3;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPicture3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTitle1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colTitle1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPicture1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPicture1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle2;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl imLab;
        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel topRoot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}