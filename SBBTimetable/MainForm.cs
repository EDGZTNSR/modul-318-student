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
    public partial class MainForm : Form
    {
        //Member Variabeln
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();
        Transport transport = new Transport();
        string departureTime = null;
        string departureDate = null;
        int isArrivalTime = 1;

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /*Events / Ereignisse*/
        //Click Event to Delete Stations
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            cmbToStation.Items.Clear();
            cmbToStation.Text = "";
            txtStation.Clear();
            cmbFromStation.Items.Clear();
            cmbFromStation.Text = "";
            txtToStation.Clear();
        }
        //Click Event to Show Connections in ListView
        private void btnSearchForConnections_Click(object sender, EventArgs e)
        {
            SetIsArrivalTime();
            SetDepartureDate();
            SetDepartureTime();
            lvConnections.Items.Clear();
            lvConnections.Items.AddRange(GetConnection(cmbFromStation.Text, cmbToStation.Text));
        }
        //Click Event to Show the Departure Board from the Current "From" Station
        private void btnDepartureBoard_Click(object sender, EventArgs e)
        {
            if (cmbFromStation.SelectedIndex != -1)
            {
                stationboard stationBoardForm = new stationboard();
                stationBoardForm.setcmbFromStation(cmbFromStation.Text);
                stationBoardForm.setListItemView();
                stationBoardForm.ShowDialog();
            }
        }
        //Click Event to Show the Current "To" Station on the Map Form
        private void btnMap_Click(object sender, EventArgs e)
        {
            if (cmbToStation.SelectedIndex != -1)
            {
                Map gMap = new Map();
                gMap.GetLocation(stationList, transport, cmbToStation.SelectedItem.ToString());
            }
        }
        //Text Change Event to Show Textinput in the "From" Station Combobox below
        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            cmbFromStation.Items.Clear();
            GetFromStation(txtStation.Text, cmbFromStation);
        }
        //Text Change Event to Show Textinput in the "To" Station Combobox below
        private void txtToStation_TextChanged(object sender, EventArgs e)
        {
            cmbToStation.Items.Clear();
            GetToStation(txtToStation.Text, cmbToStation);
        }
        
        /*Funktionen*/
        //Function to get all stations for the "From" Station Combobox
        private void GetFromStation(string location, ComboBox cmbStation)
        {
            //Lokale Variablen
            Stations station = transport.GetStations(location);
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
                cmbStation.Items.Add(item);
            }
            if (cmbStation.Items.Count > 0)
            {
                cmbStation.SelectedIndex = 0;
            }
        }
        //Function to get all stations for the "To" Station Combobox
        private void GetToStation(string location, ComboBox cmbStation)
        {
            //Lokale Variabeln
            Stations station = transport.GetStations(location);
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
                cmbStation.Items.Add(item);
            }
            if (cmbStation.Items.Count > 0)
            {
                cmbStation.SelectedIndex = 0;
            }
        }
        //Function to get all connections into the ListView
        private ListViewItem[] GetConnection(string fromStation, string toStation)
        {
            Connections ConnectionListView = transport.GetConnections(fromStation, toStation, departureDate, departureTime, isArrivalTime);
            try
            {
                ConnectionListView = transport.GetConnections(fromStation, toStation, departureDate, departureTime, isArrivalTime);
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
        /// Function to get stationboard from current "From" station
        /// </summary>
        /// <param name="fromStation"></param>
        /// <returns>ListViewItem for the stationboard</returns>
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
        //Function to set the membervariable departureTime
        private void SetDepartureTime()
        {
            departureTime = (tpFromTime.Value.Hour) + ":" + tpFromTime.Value.Minute;
        }
        //Function to set the memvervariable departureDate
        private void SetDepartureDate()
        {
            departureDate = tpFromDate.Value.Year + "-" + tpFromDate.Value.Month + "-" + tpFromDate.Value.Day;
        }
        //Funtion to set the membervariable IsArrivalTime, 0 = false, 1 = true. 1 is default value
        private void SetIsArrivalTime()
        {
            if(optIsArrival.Checked == true)
            {
                isArrivalTime = 1;
            }
            else if(optIsDeparture.Checked == true)
            {
                isArrivalTime = 0;
            }
        }
    }
}
