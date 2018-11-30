using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SBBTimetable
{
    public partial class Form1 : Form
    {
        //Globale Variabeln
        List<string> fromStationId = new List<string>();
        Transport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
            SetTimePickerFormat();
        }
        //Events / Ereignisse
        private void cmbFromStation_Click(object sender, EventArgs e)
        {
            cmbFromStation.Items.Clear();
            GetStation(cmbFromStation.Text, true);
        }
        private void cmbToStation_Click(object sender, EventArgs e)
        {
            cmbToStation.Items.Clear();
            GetStation(cmbToStation.Text, false);
        }
        private void btnChangePosition_Click(object sender, EventArgs e)
        {
            string fromStationText = "";
            string toStationText = "";
            fromStationText = cmbFromStation.Text;
            toStationText = cmbToStation.Text;

            cmbToStation.Text = fromStationText;
            cmbFromStation.Text = toStationText;
        }
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            cmbToStation.Text = "";
            cmbFromStation.Text = "";
        }
        private void btnSearchForConnections_Click(object sender, EventArgs e)
        {
            GetConnection();
        }
        //Funktionen
        
        private void GetStation(string location, bool stationType)
        {
            //Lokale Variabeln
            Stations station = transport.GetStations(location);
            //Prüft ob FromStation oder ToStation
            if (stationType)
            {
                List<string> fromStationList = new List<string>();
                foreach (var item in station.StationList)
                {
                    if (!string.IsNullOrEmpty(item.Name))
                    {
                        fromStationList.Add(item.Name);
                    }
                }

                foreach (var item in fromStationList)
                {
                    cmbFromStation.Items.Add(item);
                }
            }
            else
            {
                List<string> toStationList = new List<string>();

                foreach (var item in station.StationList)
                {
                    if (!string.IsNullOrEmpty(item.Name))
                    {
                        toStationList.Add(item.Name);
                    }
                }
                foreach (var item in toStationList)
                {
                    cmbToStation.Items.Add(item);
                }
                
            }
        }
        private void GetConnection()
        {
            Connections connection = new Transport().GetConnections(cmbFromStation.SelectedItem.ToString(), cmbToStation.SelectedItem.ToString());
            foreach (var item in connection.ConnectionList)
            {
                
            }
        }
        //private bool HasValue(int? value)
        //{
        //    if (value != null)
        //        return true;
        //    else
        //        return false;

        //}
        private void SetTimePickerFormat()
        {
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "HH m";
        }
    }
}
