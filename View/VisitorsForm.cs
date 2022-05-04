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

        public VisitorsForm(Main _mainRef)
        {
            this._mainRef = _mainRef;
            InitializeComponent();
        }

        private void VisitorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.biblioDataSet.Visitor);
            // TODO: This line of code loads data into the 'biblioDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.biblioDataSet.Member);
            // TODO: This line of code loads data into the 'biblioDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.biblioDataSet.Member);
        }

        private void addVis_Click(object sender, EventArgs e)
        {
            Visitor visitor = new Visitor();
            visitor.Name = visName.Text;
            visitor.Age = Int32.Parse(visAge.Text);
            visitor.VisitDay = DateTime.Today.Date;
            VisitorADO visitADO = new VisitorADO();
            visitADO.insert(visitor);
            VisitorsForm_Load(sender, null);
        }

        private void addMem_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Name = memName.Text;
            member.Age = Int32.Parse(memAge.Text);
            member.Since = DateTime.Today.Date;
            ImageConverter converter = new ImageConverter();

            member.Picture = (byte[])converter.ConvertTo(memPic.CurrentImage,
                typeof(byte[]));
            member.Phone = Int32.Parse(memPhone.Text);
            member.Mail = memMail.Text;
            MemberADO memADO = new MemberADO();
            memADO.insert(member);
            VisitorsForm_Load(sender, null);
        }

        void sideBarLeave(object sender, EventArgs e)
        {
            if (_mainRef._sideBarExpanded)
            {
                _mainRef.sideBarTimer.Start();
            }
        }
    }
}