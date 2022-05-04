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

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = roundTf1.Text;
            book.Picture = File.ReadAllBytes(selectedFileName);
            BookADO bookADO = new BookADO();
            bookADO.insert(book);
            Books_Load(sender, null);
        }


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
    }
}