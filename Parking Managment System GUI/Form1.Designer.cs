namespace Parking_Managment_System_GUI
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalSpaces = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReleaseVehicle = new System.Windows.Forms.Button();
            this.btnParkVehicle = new System.Windows.Forms.Button();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpParkingSpaces = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSpace12 = new System.Windows.Forms.Button();
            this.btnSpace11 = new System.Windows.Forms.Button();
            this.btnSpace10 = new System.Windows.Forms.Button();
            this.btnSpace09 = new System.Windows.Forms.Button();
            this.btnSpace08 = new System.Windows.Forms.Button();
            this.btnSpace07 = new System.Windows.Forms.Button();
            this.btnSpace06 = new System.Windows.Forms.Button();
            this.btnSpace05 = new System.Windows.Forms.Button();
            this.btnSpace04 = new System.Windows.Forms.Button();
            this.btnSpace03 = new System.Windows.Forms.Button();
            this.btnSpace02 = new System.Windows.Forms.Button();
            this.btnSpace01 = new System.Windows.Forms.Button();
            this.dgvParkingHistory = new System.Windows.Forms.DataGridView();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpVehicle.SuspendLayout();
            this.grpParkingSpaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1214, 177);
            this.pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "\tSmart Parking Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "\tPARKING MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblTotalSpaces);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 129);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalSpaces
            // 
            this.lblTotalSpaces.AutoSize = true;
            this.lblTotalSpaces.Location = new System.Drawing.Point(106, 76);
            this.lblTotalSpaces.Name = "lblTotalSpaces";
            this.lblTotalSpaces.Size = new System.Drawing.Size(59, 43);
            this.lblTotalSpaces.TabIndex = 7;
            this.lblTotalSpaces.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL SPACES";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblAvailable);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(349, 200);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 129);
            this.panel2.TabIndex = 3;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(91, 86);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(39, 43);
            this.lblAvailable.TabIndex = 8;
            this.lblAvailable.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "AVAIBLE";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.lblRevenue);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(967, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 129);
            this.panel3.TabIndex = 4;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(106, 86);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(39, 43);
            this.lblRevenue.TabIndex = 10;
            this.lblRevenue.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 43);
            this.label7.TabIndex = 9;
            this.label7.Text = "REVENUE";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.lblOccupied);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(646, 200);
            this.panel4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 129);
            this.panel4.TabIndex = 5;
            // 
            // lblOccupied
            // 
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Location = new System.Drawing.Point(107, 86);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(39, 43);
            this.lblOccupied.TabIndex = 9;
            this.lblOccupied.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 43);
            this.label6.TabIndex = 9;
            this.label6.Text = "OCCUPIED";
            // 
            // grpVehicle
            // 
            this.grpVehicle.Controls.Add(this.btnRefresh);
            this.grpVehicle.Controls.Add(this.btnReleaseVehicle);
            this.grpVehicle.Controls.Add(this.btnParkVehicle);
            this.grpVehicle.Controls.Add(this.cmbVehicleType);
            this.grpVehicle.Controls.Add(this.label9);
            this.grpVehicle.Controls.Add(this.txtPlateNumber);
            this.grpVehicle.Controls.Add(this.label8);
            this.grpVehicle.Location = new System.Drawing.Point(7, 368);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(505, 588);
            this.grpVehicle.TabIndex = 6;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "\tVehicle Information";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(55, 508);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(371, 68);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReleaseVehicle
            // 
            this.btnReleaseVehicle.BackColor = System.Drawing.Color.Firebrick;
            this.btnReleaseVehicle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReleaseVehicle.ForeColor = System.Drawing.Color.Black;
            this.btnReleaseVehicle.Location = new System.Drawing.Point(55, 412);
            this.btnReleaseVehicle.Name = "btnReleaseVehicle";
            this.btnReleaseVehicle.Size = new System.Drawing.Size(371, 70);
            this.btnReleaseVehicle.TabIndex = 8;
            this.btnReleaseVehicle.Text = "\tRELEASE VEHICLE";
            this.btnReleaseVehicle.UseVisualStyleBackColor = false;
            this.btnReleaseVehicle.Click += new System.EventHandler(this.btnReleaseVehicle_Click);
            // 
            // btnParkVehicle
            // 
            this.btnParkVehicle.BackColor = System.Drawing.Color.PaleGreen;
            this.btnParkVehicle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParkVehicle.ForeColor = System.Drawing.Color.Black;
            this.btnParkVehicle.Location = new System.Drawing.Point(55, 322);
            this.btnParkVehicle.Name = "btnParkVehicle";
            this.btnParkVehicle.Size = new System.Drawing.Size(371, 68);
            this.btnParkVehicle.TabIndex = 7;
            this.btnParkVehicle.Text = "Park Vehicle";
            this.btnParkVehicle.UseVisualStyleBackColor = false;
            this.btnParkVehicle.Click += new System.EventHandler(this.btnParkVehicle_Click);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Car",
            "Motocycle"});
            this.cmbVehicleType.Location = new System.Drawing.Point(55, 245);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(344, 51);
            this.cmbVehicleType.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(50, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vehicle Type:";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(55, 112);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(344, 49);
            this.txtPlateNumber.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(50, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vehicle Plate Number:";
            // 
            // grpParkingSpaces
            // 
            this.grpParkingSpaces.Controls.Add(this.label11);
            this.grpParkingSpaces.Controls.Add(this.label10);
            this.grpParkingSpaces.Controls.Add(this.btnSpace12);
            this.grpParkingSpaces.Controls.Add(this.btnSpace11);
            this.grpParkingSpaces.Controls.Add(this.btnSpace10);
            this.grpParkingSpaces.Controls.Add(this.btnSpace09);
            this.grpParkingSpaces.Controls.Add(this.btnSpace08);
            this.grpParkingSpaces.Controls.Add(this.btnSpace07);
            this.grpParkingSpaces.Controls.Add(this.btnSpace06);
            this.grpParkingSpaces.Controls.Add(this.btnSpace05);
            this.grpParkingSpaces.Controls.Add(this.btnSpace04);
            this.grpParkingSpaces.Controls.Add(this.btnSpace03);
            this.grpParkingSpaces.Controls.Add(this.btnSpace02);
            this.grpParkingSpaces.Controls.Add(this.btnSpace01);
            this.grpParkingSpaces.Location = new System.Drawing.Point(558, 368);
            this.grpParkingSpaces.Name = "grpParkingSpaces";
            this.grpParkingSpaces.Size = new System.Drawing.Size(656, 576);
            this.grpParkingSpaces.TabIndex = 7;
            this.grpParkingSpaces.TabStop = false;
            this.grpParkingSpaces.Text = "Parking Spaces";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(334, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Red — Occupied\r\n";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(49, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Green — Available";
            // 
            // btnSpace12
            // 
            this.btnSpace12.ForeColor = System.Drawing.Color.Black;
            this.btnSpace12.Location = new System.Drawing.Point(437, 434);
            this.btnSpace12.Name = "btnSpace12";
            this.btnSpace12.Size = new System.Drawing.Size(102, 58);
            this.btnSpace12.TabIndex = 11;
            this.btnSpace12.Text = "P12";
            this.btnSpace12.UseVisualStyleBackColor = true;
            // 
            // btnSpace11
            // 
            this.btnSpace11.ForeColor = System.Drawing.Color.Black;
            this.btnSpace11.Location = new System.Drawing.Point(245, 434);
            this.btnSpace11.Name = "btnSpace11";
            this.btnSpace11.Size = new System.Drawing.Size(102, 58);
            this.btnSpace11.TabIndex = 10;
            this.btnSpace11.Text = "P11";
            this.btnSpace11.UseVisualStyleBackColor = true;
            // 
            // btnSpace10
            // 
            this.btnSpace10.ForeColor = System.Drawing.Color.Black;
            this.btnSpace10.Location = new System.Drawing.Point(54, 434);
            this.btnSpace10.Name = "btnSpace10";
            this.btnSpace10.Size = new System.Drawing.Size(102, 58);
            this.btnSpace10.TabIndex = 9;
            this.btnSpace10.Text = "P10";
            this.btnSpace10.UseVisualStyleBackColor = true;
            // 
            // btnSpace09
            // 
            this.btnSpace09.ForeColor = System.Drawing.Color.Black;
            this.btnSpace09.Location = new System.Drawing.Point(437, 311);
            this.btnSpace09.Name = "btnSpace09";
            this.btnSpace09.Size = new System.Drawing.Size(102, 58);
            this.btnSpace09.TabIndex = 8;
            this.btnSpace09.Text = "P09";
            this.btnSpace09.UseVisualStyleBackColor = true;
            // 
            // btnSpace08
            // 
            this.btnSpace08.ForeColor = System.Drawing.Color.Black;
            this.btnSpace08.Location = new System.Drawing.Point(245, 311);
            this.btnSpace08.Name = "btnSpace08";
            this.btnSpace08.Size = new System.Drawing.Size(102, 58);
            this.btnSpace08.TabIndex = 7;
            this.btnSpace08.Text = "P08";
            this.btnSpace08.UseVisualStyleBackColor = true;
            // 
            // btnSpace07
            // 
            this.btnSpace07.ForeColor = System.Drawing.Color.Black;
            this.btnSpace07.Location = new System.Drawing.Point(54, 311);
            this.btnSpace07.Name = "btnSpace07";
            this.btnSpace07.Size = new System.Drawing.Size(102, 58);
            this.btnSpace07.TabIndex = 6;
            this.btnSpace07.Text = "P07";
            this.btnSpace07.UseVisualStyleBackColor = true;
            // 
            // btnSpace06
            // 
            this.btnSpace06.ForeColor = System.Drawing.Color.Black;
            this.btnSpace06.Location = new System.Drawing.Point(437, 196);
            this.btnSpace06.Name = "btnSpace06";
            this.btnSpace06.Size = new System.Drawing.Size(102, 58);
            this.btnSpace06.TabIndex = 5;
            this.btnSpace06.Text = "P06";
            this.btnSpace06.UseVisualStyleBackColor = true;
            // 
            // btnSpace05
            // 
            this.btnSpace05.ForeColor = System.Drawing.Color.Black;
            this.btnSpace05.Location = new System.Drawing.Point(245, 196);
            this.btnSpace05.Name = "btnSpace05";
            this.btnSpace05.Size = new System.Drawing.Size(102, 58);
            this.btnSpace05.TabIndex = 4;
            this.btnSpace05.Text = "P05";
            this.btnSpace05.UseVisualStyleBackColor = true;
            // 
            // btnSpace04
            // 
            this.btnSpace04.ForeColor = System.Drawing.Color.Black;
            this.btnSpace04.Location = new System.Drawing.Point(54, 196);
            this.btnSpace04.Name = "btnSpace04";
            this.btnSpace04.Size = new System.Drawing.Size(102, 58);
            this.btnSpace04.TabIndex = 3;
            this.btnSpace04.Text = "P04";
            this.btnSpace04.UseVisualStyleBackColor = true;
            // 
            // btnSpace03
            // 
            this.btnSpace03.ForeColor = System.Drawing.Color.Black;
            this.btnSpace03.Location = new System.Drawing.Point(437, 88);
            this.btnSpace03.Name = "btnSpace03";
            this.btnSpace03.Size = new System.Drawing.Size(102, 58);
            this.btnSpace03.TabIndex = 2;
            this.btnSpace03.Text = "P03";
            this.btnSpace03.UseVisualStyleBackColor = true;
            // 
            // btnSpace02
            // 
            this.btnSpace02.ForeColor = System.Drawing.Color.Black;
            this.btnSpace02.Location = new System.Drawing.Point(245, 88);
            this.btnSpace02.Name = "btnSpace02";
            this.btnSpace02.Size = new System.Drawing.Size(102, 58);
            this.btnSpace02.TabIndex = 1;
            this.btnSpace02.Text = "P02";
            this.btnSpace02.UseVisualStyleBackColor = true;
            // 
            // btnSpace01
            // 
            this.btnSpace01.ForeColor = System.Drawing.Color.Black;
            this.btnSpace01.Location = new System.Drawing.Point(54, 88);
            this.btnSpace01.Name = "btnSpace01";
            this.btnSpace01.Size = new System.Drawing.Size(102, 58);
            this.btnSpace01.TabIndex = 0;
            this.btnSpace01.Text = "P01";
            this.btnSpace01.UseVisualStyleBackColor = true;
            // 
            // dgvParkingHistory
            // 
            this.dgvParkingHistory.AllowUserToAddRows = false;
            this.dgvParkingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParkingHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParkingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParkingHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketId,
            this.Plate,
            this.Type,
            this.Space,
            this.Entry,
            this.Exit,
            this.Fee});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParkingHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParkingHistory.Location = new System.Drawing.Point(7, 979);
            this.dgvParkingHistory.Name = "dgvParkingHistory";
            this.dgvParkingHistory.ReadOnly = true;
            this.dgvParkingHistory.RowHeadersVisible = false;
            this.dgvParkingHistory.RowHeadersWidth = 62;
            this.dgvParkingHistory.RowTemplate.Height = 28;
            this.dgvParkingHistory.Size = new System.Drawing.Size(1214, 493);
            this.dgvParkingHistory.TabIndex = 8;
            this.dgvParkingHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParkingHistory_CellContentClick);
            // 
            // TicketId
            // 
            this.TicketId.HeaderText = "Ticket ID";
            this.TicketId.MinimumWidth = 8;
            this.TicketId.Name = "TicketId";
            this.TicketId.ReadOnly = true;
            this.TicketId.Visible = false;
            // 
            // Plate
            // 
            this.Plate.HeaderText = "Plate Number";
            this.Plate.MinimumWidth = 8;
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Vehicle Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Space
            // 
            this.Space.HeaderText = "Parking Space";
            this.Space.MinimumWidth = 8;
            this.Space.Name = "Space";
            this.Space.ReadOnly = true;
            // 
            // Entry
            // 
            this.Entry.HeaderText = "Entry Time";
            this.Entry.MinimumWidth = 8;
            this.Entry.Name = "Entry";
            this.Entry.ReadOnly = true;
            // 
            // Exit
            // 
            this.Exit.HeaderText = "Exit Time";
            this.Exit.MinimumWidth = 8;
            this.Exit.Name = "Exit";
            this.Exit.ReadOnly = true;
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.MinimumWidth = 8;
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1236, 1492);
            this.Controls.Add(this.dgvParkingHistory);
            this.Controls.Add(this.grpParkingSpaces);
            this.Controls.Add(this.grpVehicle);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Parking Management System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.grpParkingSpaces.ResumeLayout(false);
            this.grpParkingSpaces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkingHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalSpaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblOccupied;
        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReleaseVehicle;
        private System.Windows.Forms.Button btnParkVehicle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpParkingSpaces;
        private System.Windows.Forms.Button btnSpace09;
        private System.Windows.Forms.Button btnSpace08;
        private System.Windows.Forms.Button btnSpace07;
        private System.Windows.Forms.Button btnSpace06;
        private System.Windows.Forms.Button btnSpace05;
        private System.Windows.Forms.Button btnSpace04;
        private System.Windows.Forms.Button btnSpace03;
        private System.Windows.Forms.Button btnSpace02;
        private System.Windows.Forms.Button btnSpace01;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSpace12;
        private System.Windows.Forms.Button btnSpace11;
        private System.Windows.Forms.Button btnSpace10;
        private System.Windows.Forms.DataGridView dgvParkingHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Space;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
    }
}

