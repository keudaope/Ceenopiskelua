using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RistinollaXO
{
    
    public partial class Form1 : Form
    {
        bool vuoro = true;
        int vuorolaskuri = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright Jyri Lindroos", "Tekijä");
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void napinpainallus(object sender, EventArgs e)
        {
            Button painike = (Button)sender;
            if (vuoro)
                painike.Text = "X";
            else
                painike.Text = "O";
            vuoro = !vuoro;
            vuorolaskuri++;
            painike.Enabled = false;
            tarkistaVoitto();

        }
        private void tarkistaVoitto()
        {
            bool voitto = false;
            //tarkistetaan vaakarivit
            if((R1S1.Text == R1S2.Text)&&(R1S1.Text == R1S3.Text)&&(!R1S1.Enabled))
            {
                voitto = true;
            }
            else if ((R2S1.Text == R2S2.Text) && (R2S1.Text == R2S3.Text) && (!R2S1.Enabled))
            {
                voitto = true;
            }
            else if ((R3S1.Text == R3S2.Text) && (R3S1.Text == R3S3.Text) && (!R3S1.Enabled))
            {
                voitto = true;
            }
            //tarkistetaan pystysarakkeet
            else if ((R1S1.Text == R2S1.Text) && (R1S1.Text == R3S1.Text) && (!R1S1.Enabled))
            {
                voitto = true;
            }
            else if ((R1S2.Text == R2S2.Text) && (R1S2.Text == R3S2.Text) && (!R1S2.Enabled))
            {
                voitto = true;
            }
            else if ((R1S3.Text == R2S3.Text) && (R1S3.Text == R3S3.Text) && (!R1S3.Enabled))
            {
                voitto = true;
            }
            //tarkistetaan vinottain
            else if ((R1S1.Text == R2S2.Text) && (R1S1.Text == R3S3.Text) && (!R1S1.Enabled))
            {
                voitto = true;
            }
            else if ((R1S3.Text == R2S2.Text) && (R1S3.Text == R3S1.Text) && (!R1S3.Enabled))
            {
                voitto = true;
            }
            else if(vuorolaskuri ==9)
            {
                MessageBox.Show("Tasapeli", "Voi harmi");
            }    

            if (voitto)
            {
                String voittaja = "";
                if (!vuoro)
                    voittaja = "X";
                else
                    voittaja = "O";
                MessageBox.Show(voittaja + " on pelin voittaja", "Jippii");

            }
        }
        private void sammutaPainikkeet()
        {
            try
            {
                foreach (Control painike in Controls)
                {
                    painike.Enabled = false;
                }
            }
            catch { }
            
        }

        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vuoro = true;
            vuorolaskuri = 0;
            try
            {
                foreach (Control painike in Controls)
                {
                    painike.Enabled = true;
                    painike.Text = "";
                }
            }
            catch { }
            
        }
    }
}
