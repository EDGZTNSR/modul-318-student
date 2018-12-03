namespace SBBTimetable
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GMap_GMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.btnCloseMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GMap_GMapControl
            // 
            this.GMap_GMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GMap_GMapControl.Bearing = 0F;
            this.GMap_GMapControl.CanDragMap = true;
            this.GMap_GMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMap_GMapControl.GrayScaleMode = false;
            this.GMap_GMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMap_GMapControl.LevelsKeepInMemmory = 5;
            this.GMap_GMapControl.Location = new System.Drawing.Point(16, 15);
            this.GMap_GMapControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GMap_GMapControl.MarkersEnabled = true;
            this.GMap_GMapControl.MaxZoom = 2;
            this.GMap_GMapControl.MinZoom = 2;
            this.GMap_GMapControl.MouseWheelZoomEnabled = true;
            this.GMap_GMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMap_GMapControl.Name = "GMap_GMapControl";
            this.GMap_GMapControl.NegativeMode = false;
            this.GMap_GMapControl.PolygonsEnabled = true;
            this.GMap_GMapControl.RetryLoadTile = 0;
            this.GMap_GMapControl.RoutesEnabled = true;
            this.GMap_GMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMap_GMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMap_GMapControl.ShowTileGridLines = false;
            this.GMap_GMapControl.Size = new System.Drawing.Size(1083, 583);
            this.GMap_GMapControl.TabIndex = 2;
            this.GMap_GMapControl.Zoom = 0D;
            // 
            // btnCloseMap
            // 
            this.btnCloseMap.Location = new System.Drawing.Point(976, 619);
            this.btnCloseMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseMap.Name = "btnCloseMap";
            this.btnCloseMap.Size = new System.Drawing.Size(123, 34);
            this.btnCloseMap.TabIndex = 3;
            this.btnCloseMap.Text = "Schliessen";
            this.btnCloseMap.UseVisualStyleBackColor = true;
            this.btnCloseMap.Click += new System.EventHandler(this.btnCloseMap_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 668);
            this.Controls.Add(this.btnCloseMap);
            this.Controls.Add(this.GMap_GMapControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Map";
            this.Text = "Karte";
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMap_GMapControl;
        private System.Windows.Forms.Button btnCloseMap;
    }
}