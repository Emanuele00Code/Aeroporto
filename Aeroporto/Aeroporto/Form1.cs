using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeroporto.CLASSES;

namespace Aeroporto
{
    public partial class frmAeroporto : Form
    {
        public frmAeroporto()
        {
            InitializeComponent();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (radAliante.Checked)
            {
                Aliante aliante1 = new Aliante(txtSigla.Text, (int)updPotenza.Value);
                if (radAliante2.Checked)
                {
                    Aliante aliante2 = new Aliante(txtSigla2.Text, (int)updPotenza2.Value);
                    if (aliante1.Superiore(aliante2.GetEfficienza()))
                    {
                        MessageBox.Show(aliante1.GetSigla() + " ha più potenza del " + aliante2.GetSigla());
                    }
                    else
                    {
                        MessageBox.Show(aliante2.GetSigla() + " ha più potenza del " + aliante1.GetSigla());
                    }
                }
                else
                    MessageBox.Show("Hai selezionato due aerei non comparabili!");
            }

            else
            {
                AereoMotore aereomotore1 = new AereoMotore(txtSigla.Text, (int)updPotenza.Value);
                if(radMotore2.Checked)
                {
                    AereoMotore aereomotore2 = new AereoMotore(txtSigla.Text, (int)updPotenza2.Value);
                    if(aereomotore1.Superiore(aereomotore2.GetCavalli()))
                    {
                        MessageBox.Show(aereomotore1.GetSigla()+" ha più potenza del "+aereomotore2.GetSigla());
                    }
                    else
                    {
                        MessageBox.Show(aereomotore2.GetSigla()+" ha più potenza del "+aereomotore1.GetSigla());
                    }               
                }
                else
                MessageBox.Show("Hai selezionato due aerei non comparabili!");

            }


        }

    }
}
