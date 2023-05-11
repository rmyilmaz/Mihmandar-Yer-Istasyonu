namespace UAVGroundControlV2
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCommands = new System.Windows.Forms.TabPage();
            this.tbWaypoints = new System.Windows.Forms.TabPage();
            this.tbRadioLog = new System.Windows.Forms.TabPage();
            this.radioReceivedList = new System.Windows.Forms.DataGridView();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPayloadLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPayload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChecksum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbRadioSetup = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogging = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.txtToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tbRadioLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioReceivedList)).BeginInit();
            this.tbRadioSetup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCommands);
            this.tabControl1.Controls.Add(this.tbWaypoints);
            this.tabControl1.Controls.Add(this.tbRadioLog);
            this.tabControl1.Controls.Add(this.tbRadioSetup);
            this.tabControl1.Controls.Add(this.tbLogging);
            this.tabControl1.Location = new System.Drawing.Point(526, 480);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 237);
            this.tabControl1.TabIndex = 1;
            // 
            // tbCommands
            // 
            this.tbCommands.Location = new System.Drawing.Point(4, 22);
            this.tbCommands.Name = "tbCommands";
            this.tbCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tbCommands.Size = new System.Drawing.Size(494, 211);
            this.tbCommands.TabIndex = 1;
            this.tbCommands.Text = "Commands";
            this.tbCommands.UseVisualStyleBackColor = true;
            // 
            // tbWaypoints
            // 
            this.tbWaypoints.Location = new System.Drawing.Point(4, 22);
            this.tbWaypoints.Name = "tbWaypoints";
            this.tbWaypoints.Size = new System.Drawing.Size(976, 211);
            this.tbWaypoints.TabIndex = 4;
            this.tbWaypoints.Text = "Waypoints";
            this.tbWaypoints.UseVisualStyleBackColor = true;
            // 
            // tbRadioLog
            // 
            this.tbRadioLog.Controls.Add(this.radioReceivedList);
            this.tbRadioLog.Location = new System.Drawing.Point(4, 22);
            this.tbRadioLog.Name = "tbRadioLog";
            this.tbRadioLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbRadioLog.Size = new System.Drawing.Size(976, 211);
            this.tbRadioLog.TabIndex = 0;
            this.tbRadioLog.Text = "Radio Log";
            this.tbRadioLog.UseVisualStyleBackColor = true;
            // 
            // radioReceivedList
            // 
            this.radioReceivedList.AllowUserToAddRows = false;
            this.radioReceivedList.AllowUserToDeleteRows = false;
            this.radioReceivedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.radioReceivedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.radioReceivedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTime,
            this.clSequence,
            this.clIDA,
            this.clIDB,
            this.clPayloadLength,
            this.clPayload,
            this.clChecksum});
            this.radioReceivedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioReceivedList.Location = new System.Drawing.Point(3, 3);
            this.radioReceivedList.Name = "radioReceivedList";
            this.radioReceivedList.ReadOnly = true;
            this.radioReceivedList.Size = new System.Drawing.Size(970, 205);
            this.radioReceivedList.TabIndex = 2;
            // 
            // clTime
            // 
            this.clTime.HeaderText = "Time";
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            this.clTime.Width = 55;
            // 
            // clSequence
            // 
            this.clSequence.HeaderText = "Sequence";
            this.clSequence.Name = "clSequence";
            this.clSequence.ReadOnly = true;
            this.clSequence.Width = 81;
            // 
            // clIDA
            // 
            this.clIDA.HeaderText = "ID A";
            this.clIDA.Name = "clIDA";
            this.clIDA.ReadOnly = true;
            this.clIDA.Width = 43;
            // 
            // clIDB
            // 
            this.clIDB.HeaderText = "ID B";
            this.clIDB.Name = "clIDB";
            this.clIDB.ReadOnly = true;
            this.clIDB.Width = 43;
            // 
            // clPayloadLength
            // 
            this.clPayloadLength.HeaderText = "Payload Length";
            this.clPayloadLength.Name = "clPayloadLength";
            this.clPayloadLength.ReadOnly = true;
            this.clPayloadLength.Width = 97;
            // 
            // clPayload
            // 
            this.clPayload.HeaderText = "Payload";
            this.clPayload.Name = "clPayload";
            this.clPayload.ReadOnly = true;
            this.clPayload.Width = 70;
            // 
            // clChecksum
            // 
            this.clChecksum.HeaderText = "Checksum?";
            this.clChecksum.Name = "clChecksum";
            this.clChecksum.ReadOnly = true;
            this.clChecksum.Width = 69;
            // 
            // tbRadioSetup
            // 
            this.tbRadioSetup.Controls.Add(this.button3);
            this.tbRadioSetup.Controls.Add(this.label15);
            this.tbRadioSetup.Controls.Add(this.comboBox2);
            this.tbRadioSetup.Controls.Add(this.comboBox1);
            this.tbRadioSetup.Controls.Add(this.button2);
            this.tbRadioSetup.Controls.Add(this.label2);
            this.tbRadioSetup.Controls.Add(this.label1);
            this.tbRadioSetup.Location = new System.Drawing.Point(4, 22);
            this.tbRadioSetup.Name = "tbRadioSetup";
            this.tbRadioSetup.Size = new System.Drawing.Size(976, 211);
            this.tbRadioSetup.TabIndex = 2;
            this.tbRadioSetup.Text = "Radio Setup";
            this.tbRadioSetup.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Bağlantı Açma";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(465, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "label15";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bağlantı Kapama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baunt:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port:";
            // 
            // tbLogging
            // 
            this.tbLogging.Location = new System.Drawing.Point(4, 22);
            this.tbLogging.Name = "tbLogging";
            this.tbLogging.Size = new System.Drawing.Size(976, 211);
            this.tbLogging.TabIndex = 3;
            this.tbLogging.Text = "Logging";
            this.tbLogging.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Cyan;
            this.label11.Location = new System.Drawing.Point(45, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 39);
            this.label11.TabIndex = 8;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(273, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 39);
            this.label12.TabIndex = 6;
            this.label12.Text = "label12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(42, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(273, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "TIME IN AIR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(23, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "SAT COUNT";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(45, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(273, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 39);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(264, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "WIND VELOCITY(m/s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(23, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "AIRSPEED (m/s)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(273, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(264, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "YAW(deg)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALTITUDE (m)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gMapControl1);
            this.groupBox2.Location = new System.Drawing.Point(526, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 437);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 13);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 15;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(484, 418);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip.TabIndex = 4;
            // 
            // txtToolStrip
            // 
            this.txtToolStrip.Name = "txtToolStrip";
            this.txtToolStrip.Size = new System.Drawing.Size(47, 17);
            this.txtToolStrip.Text = "Started.";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 729);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAV Ground Control v2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbRadioLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioReceivedList)).EndInit();
            this.tbRadioSetup.ResumeLayout(false);
            this.tbRadioSetup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbRadioLog;
        private System.Windows.Forms.DataGridView radioReceivedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPayloadLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPayload;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clChecksum;
        private System.Windows.Forms.TabPage tbCommands;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tbWaypoints;
        private System.Windows.Forms.TabPage tbRadioSetup;
        private System.Windows.Forms.TabPage tbLogging;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel txtToolStrip;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}

