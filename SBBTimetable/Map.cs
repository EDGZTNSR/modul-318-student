using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SwissTransport;

namespace SBBTimetable
{
    public partial class Map : Form
    {
        GMapMarker marker;
        GMapOverlay overlay;

        public Map()
        {
            InitializeComponent();
        }

        //Events
        private void btnCloseMap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setToLocation(double x,double y, string stationName)
        {
            GMap_GMapControl.Position = new PointLatLng(x, y);
            GMap_GMapControl.MapProvider = GMapProviders.GoogleMap;
            GMap_GMapControl.CanDragMap = true;
            GMap_GMapControl.DragButton = MouseButtons.Left;
            GMap_GMapControl.MinZoom = 0;
            GMap_GMapControl.MaxZoom = 24;
            GMap_GMapControl.Zoom = 18;
            GMap_GMapControl.AutoScroll = true;
        }
        /// <summary>
        /// Set current Location from Location
        /// </summary>
        /// <param name="stations"></param>
        /// <param name="transport"></param>
        /// <param name="locationName"></param>
        public void getLocation(List<Station> stations, Transport transport, string locationName)
        {
            stations = transport.GetStations(locationName).StationList;
            foreach (Station station in stations)
            {
                if (station.Name == locationName)
                {
                    this.setToLocation(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate, station.Name.ToString());
                    this.Show();
                }
            }
        }
        //Funktionen
    }
}
