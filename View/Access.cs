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
using Controller;
using Model;
using CONTROLLER;


namespace Biblio
{
    public partial class Access : Form
    {
        private LibrarianADO libA;

        public Access()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //enter key is pressed, grant access 
        private void libPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Librarian lib in libA.libADOList)
                {
                    if (lib.Name.Equals(libName.Text) &&
                        lib.Password.Equals(libPwd.Text))
                    {
                        Console.WriteLine("ENTERRRR");
                        Console.WriteLine("BBBBBBBBb " + Application.OpenForms[0].Name);
                        (Application.OpenForms[0] as Main).hideDialog();
                    }
                }
            }
        }

        private void Access_Load(object sender, EventArgs e)
        {
            libA = new LibrarianADO();
            libA.load();
            libPwd.Select();
            //remap enter key based on whether there's a librarian in db or not
            if (libA.libADOList.Count == 0)
            {
                libName.Properties.NullText = "NEW Librarian name...";
                libPwd.Properties.NullText = "NEW Librarian password...";
                libPwd.KeyDown += new KeyEventHandler(libPwd_KeyDownCreate);
                libName.KeyDown += new KeyEventHandler(libPwd_KeyDownCreate);
            }
            else
            {
                libPwd.KeyDown += new KeyEventHandler(libPwd_KeyDown);
                libName.KeyDown += new KeyEventHandler(libPwd_KeyDown);
            }
        }

        //enter key is pressed, create new librarian
        private void libPwd_KeyDownCreate(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Librarian lib = new Librarian();
                lib.Name = libName.Text;
                lib.Password = libPwd.Text;
                libA.insert(lib);

                Console.WriteLine("create " + libName.Text);

                Console.WriteLine(libPwd.Text);
            }
        }

        ///
        /// RoundCorners
        /// 
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
    }
}