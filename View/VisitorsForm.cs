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
    public partial class VisitorsForm : Form
    {
        Main _mainRef;
        public List<Borrow> borrowADOList = new List<Borrow>();
        public List<Member> memADOList = new List<Member>();


        public VisitorsForm(Main _mainRef)
        {
            this._mainRef = _mainRef;
            InitializeComponent();
            toolTip1.OwnerDraw = true;
            toolTip1.Draw += new DrawToolTipEventHandler(toolTip1_Draw);
        }

        private void VisitorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.biblioDataSet1.Member);
            // TODO: This line of code loads data into the 'biblioDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.biblioDataSet.Visitor);

            //needed to verify if a member exist in Borrow database or not before deleting theme
            BorrowADO bADO = new BorrowADO();
            bADO.load();
            borrowADOList = bADO.borrowADOList;
            ////needed to 
            //MemberADO mADO = new MemberADO();
            //mADO.load();
            //memADOList = mADO.memADOList;
        }

        private void addVis_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.Name = visName.Text;
            visitor.Age = Int32.Parse(visAge.Text);
            visitor.VisitDay = DateTime.Today.Date;
            VisitorADO visitADO = new VisitorADO();
            visitADO.insert(visitor);
            visitADO.load();
            visitorBindingSource.DataSource = visitADO.visADOList;
        }

        private void addMem_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Name = memName.Text;
            member.Age = Int32.Parse(memAge.Text);
            member.Since = DateTime.Today.Date;
            ImageConverter converter = new ImageConverter();

            member.Picture = memPic.CurrentImageIndex;
            member.Phone = Int32.Parse(memPhone.Text);
            member.Mail = memMail.Text;
            MemberADO memADO = new MemberADO();
            memADO.insert(member);
            memADO.load();
            memberBindingSource.DataSource = memADO.memADOList;
        }

        private void makeMem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(gridView2.GetFocusedRowCellValue("Name"));
            String id = gridView2.GetFocusedRowCellValue("Id").ToString();
            String name = gridView2.GetFocusedRowCellValue("Name").ToString();
            String Age = gridView2.GetFocusedRowCellValue("Age").ToString();
            VisitorADO vADO = new VisitorADO();
            vADO.delete(id);
            vADO.load();
            visitorBindingSource.DataSource = vADO.visADOList;
            memName.Text = name;
            memAge.Text = Age;
        }

        private void gridView2_CustomDrawColumnHeader(object sender,
            DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;

            e.Column.AppearanceHeader.BackColor = Color.FromArgb(230, 240, 249);
            if (e.Column.AppearanceHeader.BackColor != Color.Empty)
            {
                e.Info.AllowColoring = true;
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LLIST lENGhr::: " + borrowADOList.Count());
            String id = gridView1.GetFocusedRowCellValue("Id").ToString();
            foreach (Borrow borrow in borrowADOList)
            {
                if (borrow.MemId == Int32.Parse(id))
                {
                    toolTip1.Show(
                        "Can't delete, because this member is connected to other records in the database, delete those first.",
                        this, Cursor.Position.X - _mainRef.Location.X - 250,
                        Cursor.Position.Y - _mainRef.Location.Y + 20, 5000);
                    return;
                }
            }

            MemberADO mADO = new MemberADO();
            mADO.delete(id);
            mADO.load();
            memberBindingSource.DataSource = mADO.memADOList;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Name = memName.Text;
            member.Age = Int32.Parse(memAge.Text);
            member.Since = DateTime.Today.Date;
            ImageConverter converter = new ImageConverter();
            String id = gridView1.GetFocusedRowCellValue("Id").ToString();
            member.Id = Int32.Parse(id);
            member.Picture = memPic.CurrentImageIndex;
            member.Phone = Int32.Parse(memPhone.Text);
            member.Mail = memMail.Text;
            MemberADO memADO = new MemberADO();
            memADO.update(member);
            memADO.load();
            memberBindingSource.DataSource = memADO.memADOList;
        }

        void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font f = new Font("Arial", 10.0f);
            toolTip1.BackColor = System.Drawing.Color.Red;
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void gridView1_FocusedRowObjectChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            //String id = gridView1.GetFocusedRowCellValue("Id").ToString();
            String name = gridView1.GetFocusedRowCellValue("Name").ToString();
            String mail = gridView1.GetFocusedRowCellValue("Mail").ToString();
            String age = gridView1.GetFocusedRowCellValue("Age").ToString();
            String phone = gridView1.GetFocusedRowCellValue("Phone").ToString();
            int picIndex = Int32.Parse(gridView1.GetFocusedRowCellValue("Picture").ToString());
            memName.Text = name;
            memMail.Text = mail;
            memAge.Text = age;
            memPhone.Text = phone;
            memPic.CurrentImageIndex = picIndex;
        }
    }
}