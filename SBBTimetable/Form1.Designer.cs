namespace SBBTimetable
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearchForConnections = new System.Windows.Forms.Button();
            this.btnChangePosition = new System.Windows.Forms.Button();
            this.cmbToStation = new System.Windows.Forms.ComboBox();
            this.cmbFromStation = new System.Windows.Forms.ComboBox();
            this.lblToPosition = new System.Windows.Forms.Label();
            this.lblFromPosition = new System.Windows.Forms.Label();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btndepartureBoard = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.lblConnections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchForConnections
            // 
            this.btnSearchForConnections.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchForConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchForConnections.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchForConnections.Location = new System.Drawing.Point(74, 240);
            this.btnSearchForConnections.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchForConnections.Name = "btnSearchForConnections";
            this.btnSearchForConnections.Size = new System.Drawing.Size(160, 38);
            this.btnSearchForConnections.TabIndex = 27;
            this.btnSearchForConnections.Text = "Verbindung Suchen";
            this.btnSearchForConnections.UseVisualStyleBackColor = false;
            this.btnSearchForConnections.Click += new System.EventHandler(this.btnSearchForConnections_Click);
            // 
            // btnChangePosition
            // 
            this.btnChangePosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePosition.BackgroundImage")));
            this.btnChangePosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePosition.Location = new System.Drawing.Point(417, 72);
            this.btnChangePosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePosition.Name = "btnChangePosition";
            this.btnChangePosition.Size = new System.Drawing.Size(56, 35);
            this.btnChangePosition.TabIndex = 24;
            this.btnChangePosition.UseVisualStyleBackColor = true;
            this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
            // 
            // cmbToStation
            // 
            this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToStation.FormattingEnabled = true;
            this.cmbToStation.Location = new System.Drawing.Point(74, 141);
            this.cmbToStation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbToStation.Name = "cmbToStation";
            this.cmbToStation.Size = new System.Drawing.Size(320, 25);
            this.cmbToStation.TabIndex = 23;
            this.cmbToStation.Click += new System.EventHandler(this.cmbToStation_Click);
            // 
            // cmbFromStation
            // 
            this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromStation.FormattingEnabled = true;
            this.cmbFromStation.Location = new System.Drawing.Point(74, 77);
            this.cmbFromStation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFromStation.Name = "cmbFromStation";
            this.cmbFromStation.Size = new System.Drawing.Size(320, 25);
            this.cmbFromStation.TabIndex = 22;
            this.cmbFromStation.Click += new System.EventHandler(this.cmbFromStation_Click);
            // 
            // lblToPosition
            // 
            this.lblToPosition.AutoSize = true;
            this.lblToPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPosition.Location = new System.Drawing.Point(18, 148);
            this.lblToPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToPosition.Name = "lblToPosition";
            this.lblToPosition.Size = new System.Drawing.Size(49, 17);
            this.lblToPosition.TabIndex = 21;
            this.lblToPosition.Text = "Nach: ";
            // 
            // lblFromPosition
            // 
            this.lblFromPosition.AutoSize = true;
            this.lblFromPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPosition.Location = new System.Drawing.Point(18, 77);
            this.lblFromPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromPosition.Name = "lblFromPosition";
            this.lblFromPosition.Size = new System.Drawing.Size(37, 17);
            this.lblFromPosition.TabIndex = 20;
            this.lblFromPosition.Text = "Von:";
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStation.BackgroundImage")));
            this.btnDeleteStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStation.Location = new System.Drawing.Point(417, 134);
            this.btnDeleteStation.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(56, 38);
            this.btnDeleteStation.TabIndex = 29;
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(19, 192);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Zeit:";
            // 
            // TimePicker
            // 
            this.TimePicker.Checked = false;
            this.TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(74, 187);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(102, 23);
            this.TimePicker.TabIndex = 30;
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvConnections.Location = new System.Drawing.Point(21, 316);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(559, 344);
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
            this.btndepartureBoard.Location = new System.Drawing.Point(234, 240);
            this.btndepartureBoard.Name = "btndepartureBoard";
            this.btndepartureBoard.Size = new System.Drawing.Size(160, 38);
            this.btndepartureBoard.TabIndex = 33;
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
            this.btnMap.Location = new System.Drawing.Point(417, 240);
            this.btnMap.Margin = new System.Windows.Forms.Padding(2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(56, 38);
            this.btnMap.TabIndex = 34;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // lblConnections
            // 
            this.lblConnections.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnections.Location = new System.Drawing.Point(21, 293);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(559, 20);
            this.lblConnections.TabIndex = 35;
            this.lblConnections.Text = "Verbindungen:";
            this.lblConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(599, 672);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btndepartureBoard);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.btnSearchForConnections);
            this.Controls.Add(this.btnChangePosition);
            this.Controls.Add(this.cmbToStation);
            this.Controls.Add(this.cmbFromStation);
            this.Controls.Add(this.lblToPosition);
            this.Controls.Add(this.lblFromPosition);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Fahrplan der NDB";
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
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btndepartureBoard;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.TextBox txtFromStation;
        private System.Windows.Forms.TextBox textBox1;
    }
}

