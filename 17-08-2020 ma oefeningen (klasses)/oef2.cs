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
    public partial class oef2 : Form
    {
        public oef2()
        {
            InitializeComponent();
        }
        static int mijnTellerChannel = 1;
        
        Televisie tv = new Televisie(10);
        Kanaal een = new Kanaal (1, "een");
        Kanaal canvas = new Kanaal(2, "canvas");
        Kanaal vtm = new Kanaal(3, "vtm");
        Kanaal vier = new Kanaal(4, "vier");
        Kanaal vijf = new Kanaal(5, "vijf");
        Kanaal zes = new Kanaal(6, "zes");
        Kanaal caz = new Kanaal(7, "CAZ");
        Kanaal DC = new Kanaal(18, "Discovery Channel");
        Kanaal NGC = new Kanaal(18, "National Geagrafic channel");
        Kanaal Disney = new Kanaal(31, "Disney Channel");
        Kanaal nickelodeon = new Kanaal(30, "Nickelodeon");
        //Kanaal sneeuw = new Kanaal(0, "Static");


        private void pbVolume_Click(object sender, EventArgs e)
        {

        }

        private void lVolume_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            if (tv.Volume > 0)
            {
                tv.VolumeDown();
                lVolume.Text = $"Volume: {tv.Volume}";
                pbVolume.Value = tv.Volume;
            }
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            if (tv.Volume < 15)
            {
                tv.VolumeUp();
                lVolume.Text = $"Volume: {tv.Volume}";
                pbVolume.Value = tv.Volume;
            }
        }

        private void txtChannel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtChannel.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtChannel.Text = txtChannel.Text.Remove(txtChannel.Text.Length - 1);
            }
            else if (txtChannel.Text != "")
            {
                mijnTellerChannel = Convert.ToInt32(txtChannel.Text);
                lChannel.Text = tv.CurrentChannel(mijnTellerChannel);
                lChannelNr.Text = Convert.ToString(mijnTellerChannel);
            }
        }
        private void btnChannelDown_Click(object sender, EventArgs e)
        {
            mijnTellerChannel--;
            if (mijnTellerChannel < 0)
            {
                mijnTellerChannel = 999;
            }
            lChannel.Text = tv.CurrentChannel(mijnTellerChannel);
            lChannelNr.Text = Convert.ToString(mijnTellerChannel);
        }

        private void btnChannelUp_Click(object sender, EventArgs e)
        {
            mijnTellerChannel++;
            if (mijnTellerChannel > 999)
            {
                mijnTellerChannel = 0;
            }
            lChannel.Text = tv.CurrentChannel(mijnTellerChannel);
            lChannelNr.Text = Convert.ToString(mijnTellerChannel);
        }

        private void oef2_Load(object sender, EventArgs e)
        {
            pbVolume.Minimum = 0;
            pbVolume.Maximum = 15;
            pbVolume.Value = 10;
            tv.MijnKanaal.Add(een);
            tv.MijnKanaal.Add(canvas);
            tv.MijnKanaal.Add(vtm);
            tv.MijnKanaal.Add(vier);
            tv.MijnKanaal.Add(vijf);
            tv.MijnKanaal.Add(zes);
            tv.MijnKanaal.Add(caz);
            tv.MijnKanaal.Add(DC);
            tv.MijnKanaal.Add(NGC);
            tv.MijnKanaal.Add(Disney);
            tv.MijnKanaal.Add(nickelodeon);
            //tv.MijnKanaal.Add(sneeuw);
            lVolume.Text = $"Volume: {tv.Volume}";
            lChannel.Text = tv.CurrentChannel(mijnTellerChannel);

        }
    }
}
