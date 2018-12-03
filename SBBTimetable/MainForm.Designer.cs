namespace SBBTimetable
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSearchForConnections = new System.Windows.Forms.Button();
            this.btnChangePosition = new System.Windows.Forms.Button();
            this.cmbToStation = new System.Windows.Forms.ComboBox();
            this.cmbFromStation = new System.Windows.Forms.ComboBox();
            this.lblToPosition = new System.Windows.Forms.Label();
            this.lblFromPosition = new System.Windows.Forms.Label();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btndepartureBoard = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblConnections = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtToStation = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.tpFromTime = new System.Windows.Forms.DateTimePicker();
            this.grpArrivalOrDepart = new System.Windows.Forms.GroupBox();
            this.optIsDeparture = new System.Windows.Forms.RadioButton();
            this.optIsArrival = new System.Windows.Forms.RadioButton();
            this.grpArrivalOrDepart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchForConnections
            // 
            this.btnSearchForConnections.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchForConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchForConnections.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchForConnections.Location = new System.Drawing.Point(99, 295);
            this.btnSearchForConnections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchForConnections.Name = "btnSearchForConnections";
            this.btnSearchForConnections.Size = new System.Drawing.Size(213, 47);
            this.btnSearchForConnections.TabIndex = 2;
            this.btnSearchForConnections.Text = "Verbindung Suchen";
            this.btnSearchForConnections.UseVisualStyleBackColor = false;
            this.btnSearchForConnections.Click += new System.EventHandler(this.btnSearchForConnections_Click);
            // 
            // btnChangePosition
            // 
            this.btnChangePosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePosition.BackgroundImage")));
            this.btnChangePosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePosition.Location = new System.Drawing.Point(532, 60);
            this.btnChangePosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePosition.Name = "btnChangePosition";
            this.btnChangePosition.Size = new System.Drawing.Size(75, 43);
            this.btnChangePosition.TabIndex = 5;
            this.btnChangePosition.UseVisualStyleBackColor = true;
            this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
            // 
            // cmbToStation
            // 
            this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToStation.FormattingEnabled = true;
            this.cmbToStation.Location = new System.Drawing.Point(99, 174);
            this.cmbToStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbToStation.Name = "cmbToStation";
            this.cmbToStation.Size = new System.Drawing.Size(425, 28);
            this.cmbToStation.TabIndex = 23;
            // 
            // cmbFromStation
            // 
            this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromStation.FormattingEnabled = true;
            this.cmbFromStation.Location = new System.Drawing.Point(99, 95);
            this.cmbFromStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFromStation.Name = "cmbFromStation";
            this.cmbFromStation.Size = new System.Drawing.Size(425, 28);
            this.cmbFromStation.TabIndex = 22;
            // 
            // lblToPosition
            // 
            this.lblToPosition.AutoSize = true;
            this.lblToPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPosition.Location = new System.Drawing.Point(27, 143);
            this.lblToPosition.Name = "lblToPosition";
            this.lblToPosition.Size = new System.Drawing.Size(58, 20);
            this.lblToPosition.TabIndex = 21;
            this.lblToPosition.Text = "Nach: ";
            // 
            // lblFromPosition
            // 
            this.lblFromPosition.AutoSize = true;
            this.lblFromPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPosition.Location = new System.Drawing.Point(27, 64);
            this.lblFromPosition.Name = "lblFromPosition";
            this.lblFromPosition.Size = new System.Drawing.Size(43, 20);
            this.lblFromPosition.TabIndex = 20;
            this.lblFromPosition.Text = "Von:";
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStation.BackgroundImage")));
            this.btnDeleteStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStation.Location = new System.Drawing.Point(531, 139);
            this.btnDeleteStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(75, 47);
            this.btnDeleteStation.TabIndex = 6;
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvConnections.Location = new System.Drawing.Point(28, 389);
            this.lvConnections.Margin = new System.Windows.Forms.Padding(4);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(744, 422);
            this.lvConnections.TabIndex = 32;
            this.lvConnections.TileSize = new System.Drawing.Size(168, 30);
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Von";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nach";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Abfahrt";
            this.columnHeader2.Width = 46;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ankunft";
            this.columnHeader4.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dauer";
            this.columnHeader5.Width = 55;
            // 
            // btndepartureBoard
            // 
            this.btndepartureBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndepartureBoard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndepartureBoard.Location = new System.Drawing.Point(312, 295);
            this.btndepartureBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btndepartureBoard.Name = "btndepartureBoard";
            this.btndepartureBoard.Size = new System.Drawing.Size(213, 47);
            this.btndepartureBoard.TabIndex = 3;
            this.btndepartureBoard.Text = "Abfahrtstafel";
            this.btndepartureBoard.UseVisualStyleBackColor = true;
            this.btndepartureBoard.Click += new System.EventHandler(this.btndepartureBoard_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMap.BackgroundImage")));
            this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMap.Location = new System.Drawing.Point(532, 295);
            this.btnMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 47);
            this.btnMap.TabIndex = 4;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lblConnections
            // 
            this.lblConnections.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnections.Location = new System.Drawing.Point(28, 361);
            this.lblConnections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(745, 24);
            this.lblConnections.TabIndex = 35;
            this.lblConnections.Text = "Verbindungen:";
            this.lblConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtStation.Location = new System.Drawing.Point(99, 60);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(425, 27);
            this.txtStation.TabIndex = 0;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // txtToStation
            // 
            this.txtToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtToStation.Location = new System.Drawing.Point(99, 139);
            this.txtToStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtToStation.Name = "txtToStation";
            this.txtToStation.Size = new System.Drawing.Size(425, 27);
            this.txtToStation.TabIndex = 1;
            this.txtToStation.TextChanged += new System.EventHandler(this.txtToStation_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(24, 226);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 20);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "Datum:";
            // 
            // tpFromDate
            // 
            this.tpFromDate.Checked = false;
            this.tpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpFromDate.Location = new System.Drawing.Point(100, 221);
            this.tpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFromDate.Name = "tpFromDate";
            this.tpFromDate.Size = new System.Drawing.Size(212, 27);
            this.tpFromDate.TabIndex = 30;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(327, 226);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 20);
            this.lblTime.TabIndex = 37;
            this.lblTime.Text = "Zeit:";
            // 
            // tpFromTime
            // 
            this.tpFromTime.Checked = false;
            this.tpFromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpFromTime.Location = new System.Drawing.Point(387, 221);
            this.tpFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFromTime.Name = "tpFromTime";
            this.tpFromTime.ShowUpDown = true;
            this.tpFromTime.Size = new System.Drawing.Size(137, 27);
            this.tpFromTime.TabIndex = 36;
            // 
            // grpArrivalOrDepart
            // 
            this.grpArrivalOrDepart.Controls.Add(this.optIsDeparture);
            this.grpArrivalOrDepart.Controls.Add(this.optIsArrival);
            this.grpArrivalOrDepart.Location = new System.Drawing.Point(532, 206);
            this.grpArrivalOrDepart.Name = "grpArrivalOrDepart";
            this.grpArrivalOrDepart.Size = new System.Drawing.Size(175, 57);
            this.grpArrivalOrDepart.TabIndex = 38;
            this.grpArrivalOrDepart.TabStop = false;
            // 
            // optIsDeparture
            // 
            this.optIsDeparture.AutoSize = true;
            this.optIsDeparture.Location = new System.Drawing.Point(89, 21);
            this.optIsDeparture.Name = "optIsDeparture";
            this.optIsDeparture.Size = new System.Drawing.Size(75, 21);
            this.optIsDeparture.TabIndex = 1;
            this.optIsDeparture.TabStop = true;
            this.optIsDeparture.Text = "Abfahrt";
            this.optIsDeparture.UseVisualStyleBackColor = true;
            // 
            // optIsArrival
            // 
            this.optIsArrival.AutoSize = true;
            this.optIsArrival.Location = new System.Drawing.Point(6, 21);
            this.optIsArrival.Name = "optIsArrival";
            this.optIsArrival.Size = new System.Drawing.Size(77, 21);
            this.optIsArrival.TabIndex = 0;
            this.optIsArrival.TabStop = true;
            this.optIsArrival.Text = "Ankunft";
            this.optIsArrival.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(799, 827);
            this.Controls.Add(this.grpArrivalOrDepart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tpFromTime);
            this.Controls.Add(this.txtToStation);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btndepartureBoard);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tpFromDate);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.btnSearchForConnections);
            this.Controls.Add(this.btnChangePosition);
            this.Controls.Add(this.cmbToStation);
            this.Controls.Add(this.cmbFromStation);
            this.Controls.Add(this.lblToPosition);
            this.Controls.Add(this.lblFromPosition);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Zugfahrplan der Schweiz";
            this.grpArrivalOrDepart.ResumeLayout(false);
            this.grpArrivalOrDepart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchForConnections;
        private System.Windows.Forms.Button btnChangePosition;
        private System.Windows.Forms.ComboBox cmbToStation;
        private System.Windows.Forms.ComboBox cmbFromStation;
        private System.Windows.Forms.Label lblToPosition;
        private System.Windows.Forms.Label lblFromPosition;
        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btndepartureBoard;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.TextBox txtToStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker tpFromDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker tpFromTime;
        private System.Windows.Forms.GroupBox grpArrivalOrDepart;
        private System.Windows.Forms.RadioButton optIsDeparture;
        private System.Windows.Forms.RadioButton optIsArrival;
    }
}

