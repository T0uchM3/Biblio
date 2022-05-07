namespace Biblio
{
    partial class BookForm
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
            DevExpress.XtraGrid.Views.Tile.ItemTemplate itemTemplate2 = new DevExpress.XtraGrid.Views.Tile.ItemTemplate();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colPicture3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTitle3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.biblioDataSet = new Biblio.BiblioDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Biblio.BiblioDataSetTableAdapters.BookTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.roundTf1 = new Biblio.RoundTf();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.Id = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTitle1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPicture1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPicture1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTitle2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upBtn = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchTf = new Biblio.RoundTf();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.topRoot = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundTf1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPicture1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTf.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.topRoot.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colPicture3
            // 
            this.colPicture3.FieldName = "Picture";
            this.colPicture3.Name = "colPicture3";
            this.colPicture3.Visible = true;
            this.colPicture3.VisibleIndex = 1;
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
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(245, 38);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Book Title";
            // 
            // roundTf1
            // 
            this.roundTf1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundTf1.Location = new System.Drawing.Point(20, 49);
            this.roundTf1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.roundTf1.Name = "roundTf1";
            this.roundTf1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.roundTf1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.roundTf1.Properties.Appearance.Options.UseBackColor = true;
            this.roundTf1.Properties.Appearance.Options.UseFont = true;
            this.roundTf1.Properties.Appearance.Options.UseTextOptions = true;
            this.roundTf1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.roundTf1.Properties.AutoHeight = false;
            this.roundTf1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.roundTf1.Properties.NullText = "Title here...";
            this.roundTf1.Size = new System.Drawing.Size(211, 36);
            this.roundTf1.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bookBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(8, 3);
            this.gridControl1.MainView = this.tileView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(853, 336);
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
            this.colPicture3,
            this.Id});
            this.tileView2.GridControl = this.gridControl1;
            this.tileView2.Name = "tileView2";
            this.tileView2.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView2.OptionsTiles.ItemSize = new System.Drawing.Size(86, 100);
            this.tileView2.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView2.OptionsTiles.RowCount = 0;
            tileViewItemElement5.Column = this.colPicture3;
            tileViewItemElement5.Text = "colPicture3";
            tileViewItemElement6.Column = this.colTitle3;
            tileViewItemElement6.Text = "colTitle3";
            itemTemplate2.Elements.Add(tileViewItemElement5);
            itemTemplate2.Elements.Add(tileViewItemElement6);
            itemTemplate2.Name = "template1";
            this.tileView2.Templates.Add(itemTemplate2);
            tileViewItemElement7.Column = this.colPicture3;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement7.ImageOptions.ImageSize = new System.Drawing.Size(86, 100);
            tileViewItemElement7.Text = "colPicture3";
            tileViewItemElement8.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            tileViewItemElement8.Appearance.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            tileViewItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Bold);
            tileViewItemElement8.Appearance.Normal.Options.UseBackColor = true;
            tileViewItemElement8.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement8.Column = this.colTitle3;
            tileViewItemElement8.Text = "colTitle3";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileView2.TileTemplate.Add(tileViewItemElement7);
            this.tileView2.TileTemplate.Add(tileViewItemElement8);
            this.tileView2.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.onFocusChanged);
            // 
            // Id
            // 
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.upBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roundTf1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(47, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 147);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.upBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upBtn.FlatAppearance.BorderSize = 0;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBtn.Image = global::Biblio.Properties.Resources.icons8_pictures_folder_36px;
            this.upBtn.Location = new System.Drawing.Point(30, 93);
            this.upBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(191, 51);
            this.upBtn.TabIndex = 17;
            this.upBtn.UseVisualStyleBackColor = false;
            this.upBtn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.root.ColumnCount = 4;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.0534F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.9466F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.root.Controls.Add(this.pictureBox1, 1, 0);
            this.root.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.root.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.root.Controls.Add(this.tableLayoutPanel2, 3, 0);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(304, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.modifyBtn, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.deleteBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.addBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(438, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 147);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.modifyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyBtn.FlatAppearance.BorderSize = 0;
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBtn.ForeColor = System.Drawing.Color.White;
            this.modifyBtn.Image = global::Biblio.Properties.Resources.icons8_save_36px;
            this.modifyBtn.Location = new System.Drawing.Point(40, 103);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(60, 41);
            this.modifyBtn.TabIndex = 18;
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::Biblio.Properties.Resources.icons8_reduce_36px;
            this.deleteBtn.Location = new System.Drawing.Point(40, 53);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 44);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = global::Biblio.Properties.Resources.icons8_add_new_36px;
            this.addBtn.Location = new System.Drawing.Point(40, 3);
            this.addBtn.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(60, 44);
            this.addBtn.TabIndex = 16;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addEvent);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchTf, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(584, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(238, 147);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(232, 40);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Search by Title";
            // 
            // searchTf
            // 
            this.searchTf.Location = new System.Drawing.Point(3, 49);
            this.searchTf.Name = "searchTf";
            this.searchTf.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.searchTf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchTf.Properties.Appearance.Options.UseBackColor = true;
            this.searchTf.Properties.Appearance.Options.UseFont = true;
            this.searchTf.Properties.Appearance.Options.UseTextOptions = true;
            this.searchTf.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchTf.Properties.AutoHeight = false;
            this.searchTf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.searchTf.Properties.NullText = "Title to search here...";
            this.searchTf.Size = new System.Drawing.Size(214, 40);
            this.searchTf.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.36207F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.63793F));
            this.tableLayoutPanel4.Controls.Add(this.clearSearchBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.searchBtn, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 49);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.clearSearchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearSearchBtn.FlatAppearance.BorderSize = 0;
            this.clearSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchBtn.ForeColor = System.Drawing.Color.White;
            this.clearSearchBtn.Image = global::Biblio.Properties.Resources.icons8_Close_36px;
            this.clearSearchBtn.Location = new System.Drawing.Point(150, 3);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(79, 43);
            this.clearSearchBtn.TabIndex = 19;
            this.clearSearchBtn.UseVisualStyleBackColor = false;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::Biblio.Properties.Resources.icons8_search_36px;
            this.searchBtn.Location = new System.Drawing.Point(30, 3);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(87, 43);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // topRoot
            // 
            this.topRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.topRoot.ColumnCount = 1;
            this.topRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topRoot.Controls.Add(this.root, 0, 0);
            this.topRoot.Controls.Add(this.panel1, 0, 1);
            this.topRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRoot.Location = new System.Drawing.Point(0, 0);
            this.topRoot.Name = "topRoot";
            this.topRoot.RowCount = 2;
            this.topRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.68859F));
            this.topRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.31141F));
            this.topRoot.Size = new System.Drawing.Size(851, 517);
            this.topRoot.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 342);
            this.panel1.TabIndex = 15;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 517);
            this.Controls.Add(this.topRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTf.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.topRoot.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel topRoot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button searchBtn;
        private RoundTf searchTf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button clearSearchBtn;
        private DevExpress.XtraGrid.Columns.TileViewColumn Id;
    }
}