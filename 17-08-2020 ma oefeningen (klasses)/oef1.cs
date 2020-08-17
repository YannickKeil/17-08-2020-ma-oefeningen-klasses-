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
    public partial class oef1 : Form
    {
        public oef1()
        {
            InitializeComponent();
        }
        private Teller mijnTeller = new Teller();

        private void btnBekijkGetal_Click(object sender, EventArgs e)
        {
            mijnTeller.Bekijken();
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            mijnTeller.Verhogen();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            mijnTeller.Verlagen();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mijnTeller.Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
