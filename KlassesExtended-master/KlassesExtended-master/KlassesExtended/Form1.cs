using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassesExtended
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Persoon> personenLijst = new List<Persoon>();

        private void Form1_Load(object sender, EventArgs e)
        {
            personenLijst.Add(new Persoon("Benjamin", 28));
            personenLijst.Add(new Persoon("Koen", 57));
            personenLijst.Add(new Persoon("Ken"));

            lbPersonen.DataSource = personenLijst;

            personenLijst.Add(new Persoon("Jonas", 24));

            lbPersonen.DataSource = null;
            lbPersonen.DataSource = personenLijst;
        }

        private void lbPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPersonen.DataSource != null)
            {
                if (personenLijst[lbPersonen.SelectedIndex].Leeftijd >= 0)
                    lblLeeftijd.Text = personenLijst[lbPersonen.SelectedIndex].Leeftijd.ToString();
                else
                    lblLeeftijd.Text = "Niet bekend";
            }
        }
    }
}
