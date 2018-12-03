namespace SBBTimetable
{
    partial class stationboard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.livStationboard = new System.Windows.Forms.ListView();
            this.colLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFromStation = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(585, 292);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 39);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // livStationboard
            // 
            this.livStationboard.AutoArrange = false;
            this.livStationboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLine,
            this.colDeparture,
            this.colTo});
            this.livStationboard.Location = new System.Drawing.Point(16, 65);
            this.livStationboard.Margin = new System.Windows.Forms.Padding(4);
            this.livStationboard.Name = "livStationboard";
            this.livStationboard.Size = new System.Drawing.Size(667, 218);
            this.livStationboard.TabIndex = 24;
            this.livStationboard.UseCompatibleStateImageBehavior = false;
            this.livStationboard.View = System.Windows.Forms.View.Details;
            // 
            // colLine
            // 
            this.colLine.Text = "Linie";
            this.colLine.Width = 50;
            // 
            // colDeparture
            // 
            this.colDeparture.Text = "Abfahrt Zeit";
            this.colDeparture.Width = 67;
            // 
            // colTo
            // 
            this.colTo.Text = "Bis Station";
            this.colTo.Width = 358;
            // 
            // lblFromStation
            // 
            this.lblFromStation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFromStation.Location = new System.Drawing.Point(157, 23);
            this.lblFromStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromStation.Name = "lblFromStation";
            this.lblFromStation.Size = new System.Drawing.Size(527, 25);
            this.lblFromStation.TabIndex = 27;
            this.lblFromStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStation
            // 
            this.lblStation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStation.Location = new System.Drawing.Point(16, 23);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(133, 24);
            this.lblStation.TabIndex = 36;
            this.lblStation.Text = "Von Station:";
            this.lblStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stationboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 346);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblFromStation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.livStationboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "stationboard";
            this.Text = "Abfahrtstafel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView livStationboard;
        private System.Windows.Forms.ColumnHeader colLine;
        private System.Windows.Forms.ColumnHeader colDeparture;
        private System.Windows.Forms.ColumnHeader colTo;
        private System.Windows.Forms.Label lblFromStation;
        private System.Windows.Forms.Label lblStation;
    }
}