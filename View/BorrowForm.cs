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

        public BorrowForm(int librarianId)
        {
            this.librarianId = librarianId;
            InitializeComponent();
        }


        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.biblioDataSet.Borrow);
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);
            // TODO: This line of code loads data into the 'biblioDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.biblioDataSet.Member);
            // TODO: This line of code loads data into the 'biblioDataSet.Borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.biblioDataSet.Borrow);
            // TODO: This line of code loads data into the 'biblioDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.biblioDataSet.Book);
        }

        private void lendBtn_Click(object sender, EventArgs e)
        {
            Borrow borow = new Borrow();
            borow.LibId = librarianId;
            borow.MemId = (int)memberLB.SelectedValue;
            borow.BookId = (int)bookLB.SelectedValue;
            borow.Date = dueDate.DateTime.Date;
            BorrowADO borrowADO = new BorrowADO();
            borrowADO.insert(borow);
            Borrow_Load(sender, null);
        }
    }
}