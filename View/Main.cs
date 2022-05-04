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
        private Form _shadow;
        private Form _msg;
        private int librarianId = 0;
        Boolean wasInBook = false;
        Boolean wasInVisit = false;
        Boolean wasInBorrow = false;
        public bool _sideBarExpanded;
        private DateTime start;

        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this.biblioDataSet.Book);
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
            _shadow.Hide();
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;

            //this.Focus();
            //this.Show();
            //this.BringToFront();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _shadow = new Form();
            _shadow.MinimizeBox = false;
            _shadow.MaximizeBox = false;
            _shadow.ControlBox = false;

            _shadow.Text = "";
            _shadow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _shadow.Size = Size;
            _shadow.BackColor = Color.Black;
            _shadow.Opacity = 0.3;
            _shadow.Show();
            _shadow.Location = Location;
            _shadow.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sideBarTimer.Start();
        }

        private void sideBarEnter(object sender, EventArgs e)
        {
            if (!_sideBarExpanded) //sidebar is closed
            {
                sideBarTimer.Start();
            }
        }

        void sideBarLeave(object sender, EventArgs e)
        {
            //if (_sideBarExpanded)
            //{
            //    sideBarTimer.Start();
            //}
        }

        void sideBarLeave2(object sender, EventArgs e)
        {
            if (_sideBarExpanded)
            {
                Console.WriteLine("leaft " + sender.ToString());
                if (sideBar.ClientRectangle.Contains(sideBar.PointToClient(Control.MousePosition)))
                {
                    Console.WriteLine("sideBar ");
                    return;
                }

                //if (dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)))
                //{
                //    Console.WriteLine("dashBtn ");
                //    return;
                //}

                //Console.WriteLine("****TICK ");
                Console.WriteLine("TICK ");

                start = DateTime.Now;
                timer1.Start();
                //if (dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)))
                //{
                //    Console.WriteLine("dashBtn ");
                //    return;
                //}

                sideBarTimer.Start();
            }
        }

        void timerTick2(object sender, EventArgs e)
        {
            //Console.WriteLine("TICK ");
            if ((DateTime.Now - start).TotalMilliseconds > 100)
            {
                Console.WriteLine("STTTOOOOOPPPPPP");
                timer1.Stop();
            }

            if (dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)))
            {
                Console.WriteLine("dashBtnnnnnn ");
                return;
            }

            if (sideBar.ClientRectangle.Contains(sideBar.PointToClient(Control.MousePosition)))
            {
                Console.WriteLine("sidebarrrrrrr ");
                return;
            }
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (_sideBarExpanded)
            {
                //dummyRatCatcher.Width = 50;
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    _sideBarExpanded = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                //if (!dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)))
                //{
                //    Console.WriteLine(" WAY 222 FAAASSTT");
                //    sideBarTimer.Stop();
                //    sideBar.Width = 68;
                //}

                //dummyRatCatcher.Width = 205;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    Console.WriteLine("EXPANDED");

                    _sideBarExpanded = true;
                    sideBarTimer.Stop();
                    if (!dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)) &&
                        !sideBar.ClientRectangle.Contains(sideBar.PointToClient(Control.MousePosition)))
                    {
                        Console.WriteLine("FAAASSTT");
                        sideBarTimer.Start();
                    }
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


        private void borrowBtn_Click(object sender, EventArgs e)
        {
            //FormCollection fc = Application.OpenForms;
            //Boolean found = false;
            //foreach (Form frm in fc)
            //{
            //    if (frm.Name == "Books")
            //    {
            //        found = true;
            //    }
            //}

            //if (found == true)
            //{
            //    (Application.OpenForms["Books"] as BookForm).Close();
            //    this.topLayer.Controls.Remove((Application.OpenForms["Books"] as BookForm));
            //    //frm.Close();
            //}
            contentChange();
            BorrowForm borrow = new BorrowForm(librarianId);
            borrow.TopLevel = false;
            borrow.AutoScroll = true;
            this.topLayer.Controls.Add(borrow);
            borrow.Dock = DockStyle.Fill;
            borrow.Show();
            sizer.BringToFront();
            wasInBorrow = true;
            //labelControl1.BringToFront();
        }

        void contentChange()
        {
            Form tempForm = null;
            if (wasInBorrow)
            {
                wasInBorrow = false;
                tempForm = Application.OpenForms["BorrowForm"] as BorrowForm;
            }

            if (wasInBook)
            {
                wasInBook = false;
                tempForm = Application.OpenForms["Books"] as BookForm;
            }

            if (wasInVisit)
            {
                wasInVisit = false;
                tempForm = Application.OpenForms["VisitorsForm"] as VisitorsForm;
            }

            if (tempForm == null)
                return;
            tempForm.Close();
            this.topLayer.Controls.Remove(tempForm);
        }

        private void bookLibBtn_Click(object sender, EventArgs e)
        {
            contentChange();

            BookForm book = new BookForm(this);
            book.TopLevel = false;
            book.AutoScroll = true;
            this.topLayer.Controls.Add(book);
            book.Dock = DockStyle.Fill;
            book.Show();
            sizer.BringToFront();
            wasInBook = true;
            //labelControl1.SendToBack();
        }

        private void visitorBtn_Click(object sender, EventArgs e)
        {
            //FormCollection fc = Application.OpenForms;
            //Boolean foundBook = false;
            //Boolean foundBorrow = false;
            //foreach (Form frm in fc)
            //{
            //    if (frm.Name == "Borrow")
            //    {
            //        foundBorrow = true;
            //    }
            //}

            //if (foundBorrow == true)
            //{
            //    (Application.OpenForms["Borrow"] as BorrowForm).Close();
            //    this.topLayer.Controls.Remove((Application.OpenForms["Borrow"] as BorrowForm));
            //    //frm.Close();
            //}
            contentChange();
            VisitorsForm visitor = new VisitorsForm(this);
            visitor.TopLevel = false;
            visitor.AutoScroll = true;
            this.topLayer.Controls.Add(visitor);
            visitor.Dock = DockStyle.Fill;
            visitor.Show();
            sizer.BringToFront();
            wasInVisit = true;
        }
    }
}