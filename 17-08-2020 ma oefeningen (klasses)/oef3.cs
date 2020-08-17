using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }

        Rapport mijnRaport = new Rapport();

        private void oef3_Load(object sender, EventArgs e)
        {
            nudWiskunde.Minimum = 0;
            nudWiskunde.Maximum = 100;
            nudFrans.Minimum = 0;
            nudFrans.Maximum = 100;
            nudNederlands.Minimum = 0;
            nudNederlands.Maximum = 100;
            nudInformatica.Minimum = 0;
            nudInformatica.Maximum = 100;
            nudFysica.Minimum = 0;
            nudFysica.Maximum = 100;
        }

        private void btnAddWiskunde_Click(object sender, EventArgs e)
        {
            Wiskunde wiskPunt = new Wiskunde(Convert.ToInt32(nudWiskunde.Value));
            mijnRaport.WiskundePunten.Add(wiskPunt);
            lbWiskunde.DataSource = null;
            lbWiskunde.DataSource = mijnRaport.WiskundePunten;
            //foreach (var item in mijnRaport.WiskundePunten)
            //{
            //    lbWiskunde.Items.Add(item.Punten);
            //}
            //Gemiddelde(lbWiskunde, lGemWiskunde);
        }

        private void btnDelWiskunde_Click(object sender, EventArgs e)
        {
            mijnRaport.WiskundePunten.RemoveAt(lbWiskunde.SelectedIndex);
            lbWiskunde.DataSource = null;
            lbWiskunde.DataSource = mijnRaport.WiskundePunten;
            //lbWiskunde.Items.Clear();
            //foreach (var item in mijnRaport.WiskundePunten)
            //{
            //    lbWiskunde.Items.Add(item.Punten);
            //}
            //Gemiddelde(lbWiskunde, lGemWiskunde);
        }

        private void btnAddFrans_Click(object sender, EventArgs e)
        {
            Frans fransPunt = new Frans(Convert.ToInt32(nudFrans.Value));
            mijnRaport.FransPunten.Add(fransPunt);
            lbFrans.DataSource = null;
            lbFrans.DataSource = mijnRaport.FransPunten;
        }

        private void btnDelFrans_Click(object sender, EventArgs e)
        {
            mijnRaport.FransPunten.RemoveAt(lbFrans.SelectedIndex);
            lbFrans.DataSource = null;
            lbFrans.DataSource = mijnRaport.FransPunten;
        }

        private void btnAddInformatica_Click(object sender, EventArgs e)
        {
            Informatica informaticaPunt = new Informatica(Convert.ToInt32(nudInformatica.Value));
            mijnRaport.InformaticaPunten.Add(informaticaPunt);
            lbInformatica.DataSource = null;
            lbInformatica.DataSource = mijnRaport.InformaticaPunten;
        }
        private void btnDelInformatica_Click(object sender, EventArgs e)
        {
            mijnRaport.InformaticaPunten.RemoveAt(lbInformatica.SelectedIndex);
            lbInformatica.DataSource = null;
            lbInformatica.DataSource = mijnRaport.InformaticaPunten;
        }

        private void btnAddNederlands_Click(object sender, EventArgs e)
        {
            Nederlands nederlandsPunt = new Nederlands(Convert.ToInt32(nudNederlands.Value));
            mijnRaport.NederlandsPunten.Add(nederlandsPunt);
            lbNederlands.DataSource = null;
            lbNederlands.DataSource = mijnRaport.NederlandsPunten;
        }

        private void btnDelNederlands_Click(object sender, EventArgs e)
        {
            mijnRaport.NederlandsPunten.RemoveAt(lbNederlands.SelectedIndex);
            lbNederlands.DataSource = null;
            lbNederlands.DataSource = mijnRaport.NederlandsPunten;
        }

        private void btnAddFysica_Click(object sender, EventArgs e)
        {
            Fysica fysicaPunt = new Fysica(Convert.ToInt32(nudFysica.Value));
            mijnRaport.FysicaPunten.Add(fysicaPunt);
            lbFysica.DataSource = null;
            lbFysica.DataSource = mijnRaport.FysicaPunten;
        }

        private void btnDelFysica_Click(object sender, EventArgs e)
        {
            mijnRaport.FysicaPunten.RemoveAt(lbFysica.SelectedIndex);
            lbFysica.DataSource = null;
            lbFysica.DataSource = mijnRaport.FysicaPunten;
        }



       

        private void lbWiskunde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWiskunde.DataSource != null)
            {
                lGemWiskunde.Text = Convert.ToString(mijnRaport.Gemiddelde("Wiskunde"));
            }
        }

        private void lbFrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFrans.DataSource != null)
            {
                lGemFrans.Text = Convert.ToString(mijnRaport.Gemiddelde("Frans"));
            }
        }

        private void lbInformatica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInformatica.DataSource != null)
            {
                lGemInformatica.Text = Convert.ToString(mijnRaport.Gemiddelde("Informatica"));
            }
        }

        private void lbNederlands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNederlands.DataSource != null)
            {
                lGemNederlands.Text = Convert.ToString(mijnRaport.Gemiddelde("Nederlands"));
            }
        }

        private void lbFysica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFysica.DataSource != null)
            {
                lGemFysica.Text = Convert.ToString(mijnRaport.Gemiddelde("Fysica"));
            }
        }
    }   
}
