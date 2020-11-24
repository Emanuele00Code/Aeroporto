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

        /*private void btnCompara_Click(object sender, EventArgs e)
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


        }*/

        private void btnCompara_Click_1(object sender, EventArgs e)
        {
            if (radAliante.Checked)
            {
                string dato = "";
                dato += "AL-";
                dato += txtSigla.Text;
                dato += ";";
                dato += (int)updPotenza.Value;
                cmb1.Items.Add(dato);
                cmb2.Items.Add(dato);
            }
            else
            {
                string dato = "";
                dato += "AM-";
                dato += txtSigla.Text;
                dato += ";";
                dato += (int)updPotenza.Value;
                cmb1.Items.Add(dato);
                cmb2.Items.Add(dato);
            }
            /*if (radAliante.Checked)
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
                if (radMotore2.Checked)
                {
                    AereoMotore aereomotore2 = new AereoMotore(txtSigla.Text, (int)updPotenza2.Value);
                    if (aereomotore1.Superiore(aereomotore2.GetCavalli()))
                    {
                        MessageBox.Show(aereomotore1.GetSigla() + " ha più potenza del " + aereomotore2.GetSigla());
                    }
                    else
                    {
                        MessageBox.Show(aereomotore2.GetSigla() + " ha più potenza del " + aereomotore1.GetSigla());
                    }
                }
                else
                    MessageBox.Show("Hai selezionato due aerei non comparabili!");

            }*/


        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            int posizionetratto1 = cmb1.SelectedItem.ToString().IndexOf("-");
            int posizionepv1 = cmb1.SelectedItem.ToString().IndexOf(";");
            string tipo1 = cmb1.SelectedItem.ToString().Substring(0, posizionetratto1);
            string sigla1 = cmb1.SelectedItem.ToString().Substring(posizionetratto1 + 1, posizionepv1 - posizionetratto1 - 1);
            string potenza1 = cmb1.SelectedItem.ToString().Substring(posizionepv1 + 1);
            int power1 = Convert.ToInt32(potenza1); ;



            int posizionetratto2 = cmb2.SelectedItem.ToString().IndexOf("-");
            int posizionepv2 = cmb2.SelectedItem.ToString().IndexOf(";");
            string tipo2 = cmb2.SelectedItem.ToString().Substring(0, posizionetratto2);
            string sigla2 = cmb2.SelectedItem.ToString().Substring(posizionetratto2 + 1, posizionepv2 - posizionetratto2 - 1);
            string potenza2 = cmb2.SelectedItem.ToString().Substring(posizionepv2 + 1);
            int power2 = Convert.ToInt32(potenza2); ;

            if (tipo2 == tipo1)
            {
                if (tipo1 == "AL")
                {
                    Aliante aliante1 = new Aliante(sigla1, power1);
                    Aliante aliante2 = new Aliante(sigla2, power2);
                    if (aliante1.Superiore(aliante2.GetEfficienza()))
                    {
                        MessageBox.Show(aliante1.GetSigla() + " ha più potenza del " + aliante2.GetSigla());
                    }
                    else
                    {
                        MessageBox.Show(aliante1.GetSigla() + " NON ha più potenza del " + aliante2.GetSigla());
                    }
                }
                else
                {
                    AereoMotore aereomotore1 = new AereoMotore(sigla1, power1);
                    AereoMotore aereomotore2 = new AereoMotore(sigla2, power2);
                    if (aereomotore1.Superiore(aereomotore2.GetCavalli()))
                    {
                        MessageBox.Show(aereomotore1.GetSigla() + " ha più potenza del " + aereomotore2.GetSigla());
                    }
                    else
                    {
                        MessageBox.Show(aereomotore1.GetSigla() + " NON ha più potenza del " + aereomotore2.GetSigla());
                    }
                }
                
            }
            else
                MessageBox.Show("Aerei non compatibili");
        }
    }
}
