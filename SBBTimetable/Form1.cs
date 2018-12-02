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
        List<Station> stationList = new List<Station>();
        
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
            lvConnections.Items.Clear();
            lvConnections.Items.AddRange(GetConnection(cmbFromStation.Text, cmbToStation.Text));
        }
        private void btndepartureBoard_Click(object sender, EventArgs e)
        {
            stationboard stationBoardForm = new stationboard();
            stationBoardForm.setcmbFromStation(cmbFromStation.Text);
            stationBoardForm.setListItemView();
            stationBoardForm.ShowDialog();
        }
        private void btnMap_Click(object sender, EventArgs e)
        {
            Map gMap = new Map();
            gMap.getLocation(stationList, transport, cmbToStation.SelectedItem.ToString());
        }
        private void cmbFromStation_TextUpdate(object sender, EventArgs e)
        {
            cmbFromStation.Items.Clear();
            GetStation(cmbFromStation.Text, true);
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
        private ListViewItem[] GetConnection(string fromStation, string toStation)
        {
            Connections ConnectionListView = transport.GetConnections(fromStation, toStation);
            try
            {
                ConnectionListView = transport.GetConnections(fromStation, toStation);
            }
            catch (Exception e)
            {
                ListViewItem[] errorListItemView = new ListViewItem[1];
                errorListItemView[0] = new ListViewItem("Fehler:\n");
                errorListItemView[0].SubItems.Add(e.Message);
                return errorListItemView;

            }
            ListViewItem[] listView = new ListViewItem[ConnectionListView.ConnectionList.Count];
            for (int i = 0; i < ConnectionListView.ConnectionList.Count; i++)
            {
                listView[i] = new ListViewItem(ConnectionListView.ConnectionList[i].From.Station.Name);
                listView[i].SubItems.Add(ConnectionListView.ConnectionList[i].To.Station.Name);
                listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].From.Departure).ToShortTimeString());
                listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].To.Arrival).ToShortTimeString());
                listView[i].SubItems.Add(TimeSpan.Parse(ConnectionListView.ConnectionList[i].Duration.Substring(3)).TotalMinutes.ToString() + " Min");
            }
            if (listView == null)
            {
                listView[0] = new ListViewItem("Es sind keine Verbindungen vorhanden");
            }
            return listView;
        }
        /// <summary>
        /// Function to get Stationboard from current FromStation
        /// </summary>
        /// <param name="fromStation"></param>
        /// <returns></returns>
        public ListViewItem[] GetStationBoard(string fromStation)
        {
            Stations stations = new Stations();
            stations = transport.GetStations(fromStation);
            string stationId = stations.StationList.First().Id;
            StationBoardRoot stationBoard = null;
            try
            {
                stationBoard = transport.GetStationBoard(fromStation, stationId);
            }
            catch (Exception e)
            {
                ListViewItem[] errorListView = new ListViewItem[1];
                errorListView[0] = new ListViewItem("FEHLER");
                errorListView[0].SubItems.Add(e.Message);
                return errorListView;

            }
            ListViewItem[] stationListView = new ListViewItem[stationBoard.Entries.Count];
            int i = 0;
            foreach (StationBoard item in stationBoard.Entries)
            {
                stationListView[i] = new ListViewItem(item.Name);
                stationListView[i].SubItems.Add(item.Stop.Departure.ToShortTimeString());
                stationListView[i].SubItems.Add(item.To);
                i++;
            }

            if (stationListView == null)
            {
                stationListView[0] = new ListViewItem("Keine Abfahrtstafel vorhanden");
            }

            return stationListView;
        }
    }
}
