using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.paintingProcess();
            label1.Text = "RENKLENDİRME TAMAMLANDI";
            int i = 1;
            if (i==1)
            {
                if (graph.adjlists[0].colour == i)
                    eskisehir.BackColor = Color.Red;
                if (graph.adjlists[1].colour == i)
                    ankara.BackColor = Color.Red;
                if (graph.adjlists[2].colour == i)
                    cankiri.BackColor = Color.Red;
                if (graph.adjlists[3].colour == i)
                    kirsehir.BackColor = Color.Red;
                if (graph.adjlists[4].colour == i)
                    konya.BackColor = Color.Red;
                if (graph.adjlists[5].colour == i)
                    nevsehir.BackColor = Color.Red;
                if (graph.adjlists[6].colour == i)
                    aksaray.BackColor = Color.Red;
                if (graph.adjlists[7].colour == i)
                    nigde.BackColor = Color.Red;
                if (graph.adjlists[8].colour == i)
                    yozgat.BackColor = Color.Red;
                if (graph.adjlists[9].colour == i)
                    kayseri.BackColor = Color.Red;
                if (graph.adjlists[10].colour == i)
                    sivas.BackColor = Color.Red;
                if (graph.adjlists[11].colour == i)
                    kirikkale.BackColor = Color.Red;
                if (graph.adjlists[12].colour == i)
                    karaman.BackColor = Color.Red;
            }
            i++;
            if (i == 2)
            {
                if (graph.adjlists[0].colour == i)
                    eskisehir.BackColor = Color.Blue;
                if (graph.adjlists[1].colour == i)
                    ankara.BackColor = Color.Blue;
                if (graph.adjlists[2].colour == i)
                    cankiri.BackColor = Color.Blue;
                if (graph.adjlists[3].colour == i)
                    kirsehir.BackColor = Color.Blue;
                if (graph.adjlists[4].colour == i)
                    konya.BackColor = Color.Blue;
                if (graph.adjlists[5].colour == i)
                    nevsehir.BackColor = Color.Blue;
                if (graph.adjlists[6].colour == i)
                    aksaray.BackColor = Color.Blue;
                if (graph.adjlists[7].colour == i)
                    nigde.BackColor = Color.Blue;
                if (graph.adjlists[8].colour == i)
                    yozgat.BackColor = Color.Blue;
                if (graph.adjlists[9].colour == i)
                    kayseri.BackColor = Color.Blue;
                if (graph.adjlists[10].colour == i)
                    sivas.BackColor = Color.Blue;
                if (graph.adjlists[11].colour == i)
                    kirikkale.BackColor = Color.Blue;
                if (graph.adjlists[12].colour == i)
                    karaman.BackColor = Color.Blue;
            }
            i++;
            if (i == 3)
            {
                if (graph.adjlists[0].colour == i)
                    eskisehir.BackColor = Color.Green;
                if (graph.adjlists[1].colour == i)
                    ankara.BackColor = Color.Green;
                if (graph.adjlists[2].colour == i)
                    cankiri.BackColor = Color.Green;
                if (graph.adjlists[3].colour == i)
                    kirsehir.BackColor = Color.Green;
                if (graph.adjlists[4].colour == i)
                    konya.BackColor = Color.Green;
                if (graph.adjlists[5].colour == i)
                    nevsehir.BackColor = Color.Green;
                if (graph.adjlists[6].colour == i)
                    aksaray.BackColor = Color.Green;
                if (graph.adjlists[7].colour == i)
                    nigde.BackColor = Color.Green;
                if (graph.adjlists[8].colour == i)
                    yozgat.BackColor = Color.Green;
                if (graph.adjlists[9].colour == i)
                    kayseri.BackColor = Color.Green;
                if (graph.adjlists[10].colour == i)
                    sivas.BackColor = Color.Green;
                if (graph.adjlists[11].colour == i)
                    kirikkale.BackColor = Color.Green;
                if (graph.adjlists[12].colour == i)
                    karaman.BackColor = Color.Green;
            }
            i++;
            if (i == 4)
            {
                if (graph.adjlists[0].colour == i)
                    eskisehir.BackColor = Color.MediumPurple;
                if (graph.adjlists[1].colour == i)
                    ankara.BackColor = Color.MediumPurple;
                if (graph.adjlists[2].colour == i)
                    cankiri.BackColor = Color.MediumPurple;
                if (graph.adjlists[3].colour == i)
                    kirsehir.BackColor = Color.MediumPurple;
                if (graph.adjlists[4].colour == i)
                    konya.BackColor = Color.MediumPurple;
                if (graph.adjlists[5].colour == i)
                    nevsehir.BackColor = Color.MediumPurple;
                if (graph.adjlists[6].colour == i)
                    aksaray.BackColor = Color.MediumPurple;
                if (graph.adjlists[7].colour == i)
                    nigde.BackColor = Color.MediumPurple;
                if (graph.adjlists[8].colour == i)
                    yozgat.BackColor = Color.MediumPurple;
                if (graph.adjlists[9].colour == i)
                    kayseri.BackColor = Color.MediumPurple;
                if (graph.adjlists[10].colour == i)
                    sivas.BackColor = Color.MediumPurple;
                if (graph.adjlists[11].colour == i)
                    kirikkale.BackColor = Color.MediumPurple;
                if (graph.adjlists[12].colour == i)
                    karaman.BackColor = Color.MediumPurple;
            }
        }
    }
}
