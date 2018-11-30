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
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnChangePosition = new System.Windows.Forms.Button();
            this.cmbToStation = new System.Windows.Forms.ComboBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.cmbFromStation = new System.Windows.Forms.ComboBox();
            this.lblToPosition = new System.Windows.Forms.Label();
            this.lblFromPosition = new System.Windows.Forms.Label();
            this.dgvFoundConnections = new System.Windows.Forms.DataGridView();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.ColumnStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchForConnections
            // 
            this.btnSearchForConnections.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchForConnections.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchForConnections.Location = new System.Drawing.Point(493, 296);
            this.btnSearchForConnections.Name = "btnSearchForConnections";
            this.btnSearchForConnections.Size = new System.Drawing.Size(225, 47);
            this.btnSearchForConnections.TabIndex = 27;
            this.btnSearchForConnections.Text = "Verbindung Suchen";
            this.btnSearchForConnections.UseVisualStyleBackColor = false;
            this.btnSearchForConnections.Click += new System.EventHandler(this.btnSearchForConnections_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(80, 241);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 20);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "Datum:";
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(155, 236);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(125, 27);
            this.datePicker.TabIndex = 25;
            // 
            // btnChangePosition
            // 
            this.btnChangePosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePosition.BackgroundImage")));
            this.btnChangePosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePosition.Location = new System.Drawing.Point(743, 135);
            this.btnChangePosition.Name = "btnChangePosition";
            this.btnChangePosition.Size = new System.Drawing.Size(75, 43);
            this.btnChangePosition.TabIndex = 24;
            this.btnChangePosition.UseVisualStyleBackColor = true;
            this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
            // 
            // cmbToStation
            // 
            this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToStation.FormattingEnabled = true;
            this.cmbToStation.Location = new System.Drawing.Point(155, 174);
            this.cmbToStation.Name = "cmbToStation";
            this.cmbToStation.Size = new System.Drawing.Size(563, 28);
            this.cmbToStation.TabIndex = 23;
            this.cmbToStation.Click += new System.EventHandler(this.cmbToStation_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitel.Location = new System.Drawing.Point(364, 35);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(177, 29);
            this.lblTitel.TabIndex = 19;
            this.lblTitel.Text = "NDB Fahrplan";
            // 
            // cmbFromStation
            // 
            this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromStation.FormattingEnabled = true;
            this.cmbFromStation.Location = new System.Drawing.Point(155, 116);
            this.cmbFromStation.Name = "cmbFromStation";
            this.cmbFromStation.Size = new System.Drawing.Size(563, 28);
            this.cmbFromStation.TabIndex = 22;
            this.cmbFromStation.Click += new System.EventHandler(this.cmbFromStation_Click);
            // 
            // lblToPosition
            // 
            this.lblToPosition.AutoSize = true;
            this.lblToPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPosition.Location = new System.Drawing.Point(80, 182);
            this.lblToPosition.Name = "lblToPosition";
            this.lblToPosition.Size = new System.Drawing.Size(58, 20);
            this.lblToPosition.TabIndex = 21;
            this.lblToPosition.Text = "Nach: ";
            // 
            // lblFromPosition
            // 
            this.lblFromPosition.AutoSize = true;
            this.lblFromPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPosition.Location = new System.Drawing.Point(80, 116);
            this.lblFromPosition.Name = "lblFromPosition";
            this.lblFromPosition.Size = new System.Drawing.Size(43, 20);
            this.lblFromPosition.TabIndex = 20;
            this.lblFromPosition.Text = "Von:";
            // 
            // dgvFoundConnections
            // 
            this.dgvFoundConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStationName,
            this.ColumnDepartureTime,
            this.Column1,
            this.Endstation});
            this.dgvFoundConnections.Location = new System.Drawing.Point(17, 380);
            this.dgvFoundConnections.Name = "dgvFoundConnections";
            this.dgvFoundConnections.RowTemplate.Height = 24;
            this.dgvFoundConnections.Size = new System.Drawing.Size(854, 391);
            this.dgvFoundConnections.TabIndex = 28;
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStation.BackgroundImage")));
            this.btnDeleteStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStation.Location = new System.Drawing.Point(743, 296);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(75, 47);
            this.btnDeleteStation.TabIndex = 29;
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(322, 241);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 20);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Zeit:";
            // 
            // TimePicker
            // 
            this.TimePicker.Checked = false;
            this.TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(378, 236);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(117, 27);
            this.TimePicker.TabIndex = 30;
            // 
            // ColumnStationName
            // 
            this.ColumnStationName.HeaderText = "Startstation";
            this.ColumnStationName.Name = "ColumnStationName";
            this.ColumnStationName.Width = 150;
            // 
            // ColumnDepartureTime
            // 
            this.ColumnDepartureTime.HeaderText = "Abfahrtszeit";
            this.ColumnDepartureTime.Name = "ColumnDepartureTime";
            this.ColumnDepartureTime.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ankunftszeit";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.Name = "Endstation";
            this.Endstation.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(893, 827);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.dgvFoundConnections);
            this.Controls.Add(this.btnSearchForConnections);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnChangePosition);
            this.Controls.Add(this.cmbToStation);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.cmbFromStation);
            this.Controls.Add(this.lblToPosition);
            this.Controls.Add(this.lblFromPosition);
            this.Name = "Form1";
            this.Text = "Fahrplan der NDB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchForConnections;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnChangePosition;
        private System.Windows.Forms.ComboBox cmbToStation;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ComboBox cmbFromStation;
        private System.Windows.Forms.Label lblToPosition;
        private System.Windows.Forms.Label lblFromPosition;
        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.DataGridView dgvFoundConnections;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
    }
}

