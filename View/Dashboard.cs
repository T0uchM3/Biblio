using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress.ClipboardSource.SpreadsheetML;

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
            // TODO: This line of code loads data into the 'biblioDataSet3.OverdueList' table. You can move, or remove it, as needed.
            this.overdueListTableAdapter.Fill(this.biblioDataSet3.OverdueList);
            // TODO: This line of code loads data into the 'biblioDataSet2.FINALVIEW' table. You can move, or remove it, as needed.
            this.fINALVIEWTableAdapter.Fill(this.biblioDataSet2.FINALVIEW);
            // TODO: This line of code loads data into the 'biblioDataSet2.FINALVIEW' table. You can move, or remove it, as needed.
            this.fINALVIEWTableAdapter.Fill(this.biblioDataSet2.FINALVIEW);
            // TODO: This line of code loads data into the 'biblioDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.biblioDataSet.Visitor);

            init();
        }

        void init()
        {
            List<Count> counVisitList = new List<Count>();
            List<Count> counBorrowList = new List<Count>();


            BorrowADO bADO = new BorrowADO();
            bADO.loadCount(0);
            counVisitList = bADO.counList;
            bADO.loadCount(1);
            counBorrowList = bADO.counList;
            //foreach (Count c in bADO.counList)
            //{
            //    //Console.WriteLine("date: " + c.date + " count: " + c.count);
            //}

            chart1.Series.Clear();
            //chart1.Series[0].XValueMember=
            //Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaa " + chart1.Series.Count());


            var series1 = new Series
            {
                Name = "Visitors",
                Color = System.Drawing.Color.FromArgb(0, 171, 182),
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime
            };

            var series2 = new Series
            {
                Name = "Borrower",
                Color = System.Drawing.Color.FromArgb(253, 181, 72),
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime,
            };
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series["Visitors"]["PixelPointWidth"] = "10";
            chart1.Series["Borrower"]["PixelPointWidth"] = "10";

            foreach (var result in counVisitList)
            {
                series1.Points.AddXY(result.date, result.count);
            }

            foreach (var result in counBorrowList)
            {
                series2.Points.AddXY(result.date, result.count);
            }

            chart1.Invalidate();

            Status s = bADO.loadStatus();
            Console.WriteLine("visitsBeforey:: " + s.VisitBeforeYesterday);
            Object rm = Properties.Resources.ResourceManager.GetObject("Resource_Image");
            Bitmap myImage = (Bitmap)rm;
            Image image = myImage;
            borrowedBookLab.Text = s.TotalBorrow.ToString();
            nbrVisitorsLab.Text = s.TotalVisit.ToString();
            overdueBooksLab.Text = s.TotalOverdue.ToString();

            if (s.BorrowYesterday > s.BorrowBeforeYesterday)
            {
                borrowedBookLab.ImageOptions.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("borrowUp");
            }

            if (s.BorrowYesterday < s.BorrowBeforeYesterday)
            {
                borrowedBookLab.ImageOptions.Image =
                    (Bitmap)Properties.Resources.ResourceManager.GetObject("borrowDown");
            }

            if (s.VisitYesterday > s.VisitBeforeYesterday)
            {
                nbrVisitorsLab.ImageOptions.Image =
                    (Bitmap)Properties.Resources.ResourceManager.GetObject("visitorsUp");
            }

            if (s.VisitYesterday < s.VisitBeforeYesterday)
            {
                nbrVisitorsLab.ImageOptions.Image =
                    (Bitmap)Properties.Resources.ResourceManager.GetObject("visitorsDown");
            }

            if (s.OverdueYesterday > s.OverdueBeforeYesterday)
            {
                overdueBooksLab.ImageOptions.Image =
                    (Bitmap)Properties.Resources.ResourceManager.GetObject("overdueUp");
            }

            if (s.OverdueYesterday < s.OverdueBeforeYesterday)
            {
                overdueBooksLab.ImageOptions.Image =
                    (Bitmap)Properties.Resources.ResourceManager.GetObject("overdueDown");
            }
            //if (s.BorrowYesterday == s.BorrowBeforeYesterday)
            //{
            //    borrowedBookLab.ImageOptions.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Invalid");
            //}
        }
    }
}