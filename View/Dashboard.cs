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
    public partial class Dashboard : Form
    {
        private Main refMain;

        public Dashboard(Main refMain)
        {
            this.refMain = refMain;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.biblioDataSet.Visitor);
            // TODO: This line of code loads data into the 'biblioDataSet1.combo' table. You can move, or remove it, as needed.
            this.comboTableAdapter.Fill(this.biblioDataSet1.combo);
        }
    }
}