using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class Main : Form
    {
        private Form shadow;
        private Form msg;


        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);
            //labelControl1.BringToFront();
            //sizer.BringToFront();
        }

        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //    //simpleButton1_Click(null, null);
        //}

        public void hideDialog()
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaa");
            msg.Hide();
            shadow.Hide();
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;

            //this.Focus();
            //this.Show();
            //this.BringToFront();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            shadow = new Form();
            shadow.MinimizeBox = false;
            shadow.MaximizeBox = false;
            shadow.ControlBox = false;

            shadow.Text = "";
            shadow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            shadow.Size = Size;
            shadow.BackColor = Color.Black;
            shadow.Opacity = 0.3;
            shadow.Show();
            shadow.Location = Location;
            shadow.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private bool sideBarExpanded;

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpanded)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpanded = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpanded = true;
                    sideBarTimer.Stop();
                }
            }
        }


        /// <summary>
        /// DRAG RESIZE ROUNDCORNERS
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        private void BookLibrary_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            Boolean found = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Borrow")
                {
                    found = true;
                }
            }

            if (found == true)
            {
                (Application.OpenForms["Borrow"] as Borrow).Close();
                this.topLayer.Controls.Remove((Application.OpenForms["Borrow"] as Borrow));
                //frm.Close();
            }

            Books book = new Books();
            book.TopLevel = false;
            book.AutoScroll = true;
            this.topLayer.Controls.Add(book);
            book.Dock = DockStyle.Fill;
            book.Show();
            sizer.BringToFront();
            labelControl1.BringToFront();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
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
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        void SizerMouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            Boolean found = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Books")
                {
                    found = true;
                }
            }

            if (found == true)
            {
                (Application.OpenForms["Books"] as Books).Close();
                this.topLayer.Controls.Remove((Application.OpenForms["Books"] as Books));
                //frm.Close();
            }

            Borrow borrow = new Borrow();
            borrow.TopLevel = false;
            borrow.AutoScroll = true;
            this.topLayer.Controls.Add(borrow);
            borrow.Dock = DockStyle.Fill;
            borrow.Show();
            sizer.BringToFront();
            labelControl1.BringToFront();
        }
    }
}