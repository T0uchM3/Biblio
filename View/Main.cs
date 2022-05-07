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
        private int librarianId = 2;
        Boolean wasInBook = false;
        Boolean wasInVisit = false;
        Boolean wasInBorrow = false;
        Boolean wasInDashboard = false;
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
            // TODO: This line of code loads data into the 'biblioDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.biblioDataSet.Visitor);
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

        private void sideBarEnter(object sender, EventArgs e)
        {
            if (!_sideBarExpanded) //sidebar is closed
            {
                sideBarTimer.Start();
            }
        }


        void sideBarLeave2(object sender, EventArgs e)
        {
            if (_sideBarExpanded)
            {
                if (sideBar.ClientRectangle.Contains(sideBar.PointToClient(Control.MousePosition)))
                {
                    return;
                }


                start = DateTime.Now;
                //somehow the onMouseLeave event getting triggered
                //while inside it's sender, hence why we added a timer
                //to delay the execution of the event
                delayExecTimer.Start();

                sideBarTimer.Start();
            }
        }

        void timerTick2(object sender, EventArgs e)
        {
            if ((DateTime.Now - start).TotalMilliseconds > 100)
            {
                delayExecTimer.Stop();
            }

            if (dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)))
            {
                return;
            }

            if (sideBar.ClientRectangle.Contains(sideBar.PointToClient(Control.MousePosition)))
            {
                return;
            }
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (_sideBarExpanded)
            {
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
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    _sideBarExpanded = true;
                    sideBarTimer.Stop();
                    if (!dashBtn.ClientRectangle.Contains(dashBtn.PointToClient(Control.MousePosition)) &&
                        !sideBar.ClientRectangle.Contains(sideBar.PointToClient(Control.MousePosition)))
                    {
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
                tempForm = Application.OpenForms["BookForm"] as BookForm;
            }

            if (wasInVisit)
            {
                wasInVisit = false;
                tempForm = Application.OpenForms["VisitorsForm"] as VisitorsForm;
            }

            if (wasInDashboard)
            {
                wasInDashboard = false;
                tempForm = Application.OpenForms["Dashboard"] as Dashboard;
            }

            if (tempForm == null)
                return;
            tempForm.Close();
            Console.WriteLine("CLOSE SHIT UP");
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            contentChange();
            Dashboard dashboard = new Dashboard(this);
            dashboard.TopLevel = false;
            dashboard.AutoScroll = true;
            this.topLayer.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
            sizer.BringToFront();
            wasInDashboard = true;
        }
    }
}