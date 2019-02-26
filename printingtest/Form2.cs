using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace printingtest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bitmap BMP;
        private void button1_Click(object sender, EventArgs e)
        {
            //  int height = listView1.Height;

           
               // listView1.Items.Add(printname);
                BMP = new Bitmap(listView1.Width, listView1.Height);
                listView1.DrawToBitmap(BMP, new Rectangle(0, 0, listView1.Width, listView1.Height));
                printPreviewDialog1.ShowDialog();
           
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(BMP, 0, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                listView1.Items.Add(printname);
                MessageBox.Show("Hi...");
               
            }

        }
    }
}
