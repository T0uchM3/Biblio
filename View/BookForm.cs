using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace Biblio
{
    public partial class BookForm : Form
    {
        string selectedFileName;
        Main mainRef;

        public BookForm(Main main)
        {
            mainRef = main;
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Database files (*.mdb, *.accdb)|*.mdb;*.accdb";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog1.FileName;
                pictureBox1.ImageLocation = selectedFileName;
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
                mainRef.Location = new Point(
                    (mainRef.Location.X - lastLocation.X) + e.X, (mainRef.Location.Y - lastLocation.Y) + e.Y);

                mainRef.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /// <summary>
        /// DRAG END
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            String title = searchTf.Text;
            BookADO bookADO = new BookADO();
            bookADO.load(title);
            this.bookBindingSource.DataSource = bookADO.bookADOList;
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            BookADO bookADO = new BookADO();
            bookADO.load(null);
            this.bookBindingSource.DataSource = bookADO.bookADOList;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //get id from selected card
            Int32 id = (Int32)tileView2.GetFocusedRowCellValue("Id");
            BookADO bookADO = new BookADO();
            bookADO.delete(id);
            bookADO.load(null);
            //Books_Load(sender, null);
            bookBindingSource.DataSource = bookADO.bookADOList;
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
        }

        private void onFocusChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            //if (tileView2.GetFocusedRowCellValue("Id") == null)
            //    return;
            Int32 id = 0;
            String title = null;
            byte[] imageByte = null;
            try
            {
                id = (Int32)tileView2.GetFocusedRowCellValue("Id");
                title = (String)tileView2.GetFocusedRowCellValue("Title");
                imageByte = (byte[])tileView2.GetFocusedRowCellValue("Picture");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (title == null)
                return;
            ImageConverter converter = new ImageConverter();
            pictureBox1.Image = (Image)converter.ConvertFrom(imageByte);
            Console.WriteLine(" " + id);
            roundTf1.Text = title;
            //Books_Load(sender, null);
        }

        private void addEvent(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = roundTf1.Text;


            //if no cover is selected the app will assign a generic cover  
            if (selectedFileName == null)
            {
                ImageConverter converter = new ImageConverter();
                Object nullHolder = Properties.Resources.ResourceManager.GetObject("note");
                book.Picture = (byte[])converter.ConvertTo(nullHolder,
                    typeof(byte[]));
            }
            else
                book.Picture = File.ReadAllBytes(selectedFileName);

            BookADO bookADO = new BookADO();
            bookADO.insert(book);
            bookADO.load(null);
            bookBindingSource.DataSource = bookADO.bookADOList;
            //Books_Load(sender, null);
        }
    }
}