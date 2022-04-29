using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }


        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.biblioDataSet.Member);
            // TODO: This line of code loads data into the 'biblioDataSet.Borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.biblioDataSet.Borrow);
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);
            // TODO: This line of code loads data into the 'biblioDataSet.Librarian' table. You can move, or remove it, as needed.
            this.librarianTableAdapter.Fill(this.biblioDataSet.Librarian);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}