using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HGGrid;

namespace TestGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<100;i++)
            {
                DataColumn dc = new DataColumn();
                table.Columns.Add(dc);
            }

            for(int i=0;i<100000;i++)
            {
                DataRow r = table.NewRow();

                for(int j=0;j<table.Columns.Count;j++)
                {
                    r[j] = i.ToString();
                }

                table.Rows.Add(r);
            }
        }

        private void updateDataButton_Click(object sender, EventArgs e)
        {
            DateTime dtn = DateTime.Now;
            hgGrid1.Table = table;
            hgGrid1.UpdateData();
            TimeSpan ts = DateTime.Now - dtn;
            MessageBox.Show(ts.TotalSeconds.ToString("0.##") + "s");
        }
    }
}
