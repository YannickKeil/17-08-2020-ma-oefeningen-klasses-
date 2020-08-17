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
    public partial class oef4 : Form
    {
        public oef4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Zwembad zwembad = new Zwembad();
        private void btnVolume_Click(object sender, EventArgs e)
        {
            //lVolume.Text = $"{Convert.ToString(Math.Round(Convert.ToDouble(tbLengte.Text) * Convert.ToDouble(tbBreedte.Text) * Convert.ToDouble(tbDiepte.Text)*1000,2))} liter";
            zwembad.Lengte = Convert.ToDouble(tbLengte.Text);
            zwembad.Breedte = Convert.ToDouble(tbBreedte.Text);
            zwembad.Diepte = Convert.ToDouble(tbDiepte.Text);
            lVolume.Text = $"{Convert.ToString(zwembad.BerekenVolume())} liter";
        }

        private void oef4_Load(object sender, EventArgs e)
        {

        }
    }
}
