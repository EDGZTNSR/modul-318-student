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
        //Events / Ereignisse
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Funktionen
        /// <summary>
        /// Set stationname from "From Station" into Label Text
        /// </summary>
        /// <param name="station"></param>
        public void setcmbFromStation(string station)
        {
            lblFromStation.Text = station;
        }
        /// <summary>
        /// Set Items for Stationboard ListView
        /// </summary>
        public void setListItemView()
        {
            livStationboard.Items.Clear();
            MainForm mainForm = new MainForm();
            livStationboard.Items.AddRange(mainForm.GetStationBoard(lblFromStation.Text));
        }

    }
}
