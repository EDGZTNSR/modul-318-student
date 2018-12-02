using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBTimetable
{
    public partial class stationboard : Form
    {
        public stationboard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Sets the Station in the Station label
        /// </summary>
        /// <param name="station"></param>
        public void setcmbFromStation(string station)
        {
            lblFromStation.Text = station;
        }
        /// <summary>
        /// Set Items for Stationboard List
        /// </summary>
        public void setListItemView()
        {
            livStationboard.Items.Clear();
            Form1 mainForm = new Form1();
            livStationboard.Items.AddRange(mainForm.GetStationBoard(lblFromStation.Text));
        }

    }
}
