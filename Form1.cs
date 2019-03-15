using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Domaci2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Onemogucujemo stranicu B i C, jer je po defaultu izabran jednakostranicni trougao
            StranicaBtxt.Enabled = false;
            StranicaCtxt.Enabled = false;
        }

        /*Ukoliko je izabran Jednakostranicni trougao, onemogucicemo stranice B i C
        jer jednakostranicni trougao ima samo jednu stranicu*/
        private void rbJednakostranicni_CheckedChanged(object sender, EventArgs e)
        {
            StranicaBtxt.Enabled = false;
            StranicaCtxt.Enabled = false;
        }

        /*Ukoliko je izabran Jednako kraki trougao omogucicemo stranicu B, jer
         jednakokraki trougao ima 2 stranice*/
        private void rbJednakokraki_CheckedChanged(object sender, EventArgs e)
        {
            StranicaBtxt.Enabled = true;
            StranicaCtxt.Enabled = false;
        }
        /*Ukoliko je izabran raznostranicni trougao, omogucicemo i stranicu B i stranicu C, 
          jer on ima 3 stranice*/
        private void rbRaznostranicni_CheckedChanged(object sender, EventArgs e)
        {
            StranicaBtxt.Enabled = true;
            StranicaCtxt.Enabled = true;
        }

        private void Izracunajbtn_Click(object sender, EventArgs e)
        {
            if (rbJednakostranicni.Checked)
            {
              //Broj unesen u Text box, pretvara u double vrednost i rezultate racunanja ispisuje na ekranu
                Jednakostranicni jks = new Jednakostranicni(
                    Convert.ToDouble(StranicaAtxt.Text),
                    Convert.ToDouble(Visinahtxt.Text));
                MessageBox.Show("Obim: " + jks.obim() + "\n" +
                    "Povrsina: " + jks.povrsina());
            }

            else if (rbJednakokraki.Checked)
            {
                //Broj unesen u Text box, pretvara u double vrednost i rezultate racunanja ispisuje na ekranu
                Jednakokraki jdk = new Jednakokraki(
                    Convert.ToDouble(StranicaAtxt.Text),
                    Convert.ToDouble(StranicaBtxt.Text),
                    Convert.ToDouble(Visinahtxt.Text));
                MessageBox.Show("Obim: " + jdk.obim() + "\n" + "Povrsina: " + jdk.povrsina());

            }

            else 
            {
                //Broj unesen u Text box, pretvara u double vrednost i rezultate racunanja ispisuje na ekranu
                Raznostranicni rzn = new Raznostranicni(
                    Convert.ToDouble(StranicaAtxt.Text),
                    Convert.ToDouble(StranicaBtxt.Text),
                    Convert.ToDouble(StranicaCtxt.Text),
                    Convert.ToDouble(Visinahtxt.Text));
                MessageBox.Show("Obim: " + rzn.obim() + "\n" + "Povrsina: " + rzn.povrsina());
            
            
            }
        }
    }
}
