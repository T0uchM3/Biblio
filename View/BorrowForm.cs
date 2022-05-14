using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace Biblio
{
    public partial class BorrowForm : Form
    {
        public int librarianId;
        public List<Book> bookList = new List<Book>();
        Boolean runOnce = false;
        Main _mainRef;

        public BorrowForm(int librarianId, Main _mainRef)
        {
            this._mainRef = _mainRef;
            this.librarianId = librarianId;
            InitializeComponent();
            //gridView1.enableHea
        }


        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);
            // TODO: This line of code loads data into the 'biblioDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.biblioDataSet.Member);
            if (!runOnce)
            {
                loadToRefresh();
                runOnce = true;
            }

            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);

            BookADO bADO = new BookADO();
            bADO.load(null);
            bookList = bADO.bookADOList;
            //Attaching the event here cause if it gets done directly it will try to read from the list
            //before the data get loaded and will get NPE 
            bookLB.SelectedIndexChanged += new EventHandler(bookLB_SelectedIndexChanged);
            //And doing it manually won't make the already selected item (1st) appear in picture
            ImageConverter converter = new ImageConverter();
            previewCover.Image = (Image)converter.ConvertFrom(bookList[0].Picture);
        }

        void loadToRefresh()
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.biblioDataSet.Borrow);
        }

        private void lendBtn_Click(object sender, EventArgs e)
        {
            Borrow borow = new Borrow();
            borow.LibId = librarianId;
            borow.MemId = (Int32.Parse(memberLB.GetItemText(memberLB.SelectedIndex)));
            borow.BookId = (Int32.Parse(bookLB.GetItemValue(bookLB.SelectedIndex).ToString()));
            borow.DueDate = dueDate.DateTime.Date;

            Console.WriteLine("DAAAATTEEE now:  " + dueDate.DateTime.Date);
            borow.Date = DateTime.Now.Date;

            BorrowADO borrowADO = new BorrowADO();
            borrowADO.insert(borow);
            loadToRefresh();
        }

        private void bookLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (Int32.Parse(bookLB.GetItemValue(bookLB.SelectedIndex).ToString()));

            ImageConverter converter = new ImageConverter();
            foreach (Book book in bookList)
            {
                if (book.Id == id)
                {
                    previewCover.Image = (Image)converter.ConvertFrom(book.Picture);
                }
            }
        }

        private void gridView1_CustomDrawColumnHeader(object sender,
            DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;

            e.Column.AppearanceHeader.BackColor = Color.FromArgb(240, 244, 249);
            if (e.Column.AppearanceHeader.BackColor != Color.Empty)
            {
                e.Info.AllowColoring = true;
            }
        }

        /// <summary>
        /// DRAG BEGIN
        /// </summary>
        private bool mouseDown;

        private Point lastLocation;

        private void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                _mainRef.Location = new Point(
                    (_mainRef.Location.X - lastLocation.X) + e.X, (_mainRef.Location.Y - lastLocation.Y) + e.Y);

                _mainRef.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /// <summary>
        /// DRAG END
        /// </summary>
        ///
        private void returnBtn_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.LibId = Int32.Parse(gridView1.GetFocusedRowCellValue("LibID").ToString());
            borrow.MemId = Int32.Parse(gridView1.GetFocusedRowCellValue("MemID").ToString());
            borrow.BookId = Int32.Parse(gridView1.GetFocusedRowCellValue("BookID").ToString());
            ImageConverter converter = new ImageConverter();
            String id = gridView1.GetFocusedRowCellValue("Id").ToString();
            borrow.Id = Int32.Parse(id);
            borrow.Date = (DateTime)gridView1.GetFocusedRowCellValue("Date");
            borrow.DueDate = (DateTime)gridView1.GetFocusedRowCellValue("DueDate");
            borrow.Returned = 1;
            BorrowADO bADO = new BorrowADO();
            bADO.update(borrow);
            bADO.load();
            loadToRefresh();
        }
    }
}