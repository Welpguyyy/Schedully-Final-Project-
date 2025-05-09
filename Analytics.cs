using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Globalization;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Schedully
{
    public partial class Analytics : MaterialForm
    {
        List<String> courses = new List<String>();
        int BSCpE;
        int BSCS;
        int BSArch;
        int BSChe;
        int BSCE;
        int BSEE;
        int BSECE;
        int BSIE;
        int BSME;
        int BSMinE;

        List<string> Jan = new List<string>();
        List<string> Feb = new List<string>();
        List<string> Mar = new List<string>();
        List<string> Apr = new List<string>();
        List<string> May = new List<string>();
        List<string> Jun = new List<string>();
        List<string> Jul = new List<string>();
        List<string> Aug = new List<string>();
        List<string> Sep = new List<string>();
        List<string> oct = new List<string>();
        List<string> nov = new List<string>();
        List<string> Dec = new List<string>();
        List<String> dates = new List<String>();
        public Analytics()
        {
            InitializeComponent();
           


        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            loadcourse();
            countcourse();
            courseplot();
        }

        private void loadcourse()
        {
            string query = "SELECT Program FROM Clients";


            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\zhient\\Desktop\\projects\\Schedully\\bin\\Debug\\Schedully.accdb"))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string course = reader["Program"].ToString();
                                courses.Add(course);
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }



        }

        private void countcourse()
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == "BSCpE")
                {
                    BSCpE++;
                }
                else if (courses[i] == "BSCS")
                {
                    BSCS++;
                }
                else if (courses[i] == "BSArch")
                {
                    BSArch++;
                }
                else if (courses[i] == "BSChe")
                {
                    BSChe++;
                }
                else if (courses[i] == "BSCE")
                {
                    BSCE++;
                }
                else if (courses[i] == "BSEE")
                {
                    BSEE++;
                }
                else if (courses[i] == "BSECE")
                {
                    BSECE++;
                }
                else if (courses[i] == "BSIE")
                {
                    BSIE++;
                }
                else if (courses[i] == "BSME")
                {
                    BSME++;
                }
                else if (courses[i] == "BSMinE")
                {
                    BSMinE++;
                }



            }



        }







        private void courseplot()
        {
            OxyColor C(string hex) => OxyColor.Parse(hex);

            // Determine the largest count so we can size the axis nicely
            double maxCount = new[] { BSCpE, BSCS, BSArch, BSChe, BSCE,
                          BSEE, BSECE, BSIE, BSME, BSMinE }.Max();

            // Value axis (horizontal for BarSeries)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,                        // or 1 if you prefer
                Maximum = Math.Ceiling(maxCount),   // round up to next whole
                MajorStep = 1,                       // tick every 1
                MinorStep = 1,                       // small ticks every 1 as well
                LabelFormatter = x => x.ToString("0")// show as 0,1,2…
            };

            // Category axis for course names (left side)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Labels =
    {
        "BSCpE","BSCS","BSArch","BSChe","BSCE",
        "BSEE","BSECE","BSIE","BSME","BSMinE"
    }
            };

            // Build the model
            var model = new PlotModel
            {
                Title = "How many of each course visited the clinic Overall"
            };

            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };
            barSeries.Items.Add(new BarItem(BSCpE) { Color = C("#1f77b4") }); // blue
            barSeries.Items.Add(new BarItem(BSCS) { Color = C("#ff7f0e") }); // orange
            barSeries.Items.Add(new BarItem(BSArch) { Color = C("#2ca02c") }); // green
            barSeries.Items.Add(new BarItem(BSChe) { Color = C("#d62728") }); // red
            barSeries.Items.Add(new BarItem(BSCE) { Color = C("#9467bd") }); // purple
            barSeries.Items.Add(new BarItem(BSEE) { Color = C("#8c564b") }); // brown
            barSeries.Items.Add(new BarItem(BSECE) { Color = C("#e377c2") }); // pink
            barSeries.Items.Add(new BarItem(BSIE) { Color = C("#7f7f7f") }); // gray
            barSeries.Items.Add(new BarItem(BSME) { Color = C("#bcbd22") }); // olive
            barSeries.Items.Add(new BarItem(BSMinE) { Color = C("#17becf") }); // teal

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);
            model.Series.Add(barSeries);

            ploty.Model = model;


        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.OpenForms["form1"]?.Show();
            this.Hide();
        }
    }
}
