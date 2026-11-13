using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Managment_System_GUI
{
    public partial class Form1 : Form
    {
        private ParkingManagerService manager;
        public Form1()
        {

            InitializeComponent();
            // Parking History colors
            dgvParkingHistory.DefaultCellStyle.ForeColor = Color.Black;
            dgvParkingHistory.DefaultCellStyle.BackColor = Color.White;

            dgvParkingHistory.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvParkingHistory.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

            dgvParkingHistory.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvParkingHistory.RowsDefaultCellStyle.BackColor = Color.White;

            dgvParkingHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgvParkingHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgvParkingHistory.EnableHeadersVisualStyles = false;
            dgvParkingHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvParkingHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            manager = new ParkingManagerService();

            UpdateDashboard();
        }

        private void btnParkVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                string plate = txtPlateNumber.Text.Trim();
                string type = cmbVehicleType.Text;

                if (plate == "" || type == "")
                {
                    MessageBox.Show("Enter plate number and vehicle type.");
                    return;
                }

                manager.ParkVehicle(plate, type);
                ParkingTicket ticket = manager.FindVehicle(plate);

                dgvParkingHistory.Rows.Add(
                    ticket.TicketId,
                    ticket.Vehicle.PlateNumber,
                    ticket.Vehicle.VehicleType,
                    ticket.Space.SpaceNumber,
                    ticket.EntryTime.ToString("dd/MM/yyyy HH:mm"),
                    "Still Parked",
                    "RM 0.00"
                );
                UpdateDashboard();

                MessageBox.Show("Vehicle parked successfully!");

                txtPlateNumber.Clear();
                cmbVehicleType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReleaseVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                string plate = txtPlateNumber.Text.Trim();

                if (plate == "")
                {
                    MessageBox.Show("Enter vehicle plate number.");
                    return;
                }

                ParkingTicket ticket = manager.FindVehicle(plate);

                if (ticket == null)
                {
                    MessageBox.Show("Vehicle not found.");
                    return;
                }

                string ticketId = ticket.TicketId;

                decimal fee = manager.CalculateFee(ticket);

                DialogResult result = MessageBox.Show(
                    "Parking Fee: RM " + fee.ToString("F2") +
                    "\nConfirm payment?",
                    "Payment",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    manager.ReleaseVehicle(plate);

                    foreach (DataGridViewRow row in dgvParkingHistory.Rows)
                    {
                        if (row.Cells["TicketId"].Value?.ToString() == ticketId)
                        {
                            row.Cells["Exit"].Value =
                                DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                            row.Cells["Fee"].Value =
                                "RM " + fee.ToString("F2");

                            break;
                        }
                    }

                    UpdateDashboard();

                    MessageBox.Show("Vehicle released successfully!");

                    txtPlateNumber.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateDashboard()
        {
            lblTotalSpaces.Text = "12";

            lblAvailable.Text =
                manager.GetAvailableSpaces().ToString();

            lblOccupied.Text =
                manager.GetOccupiedSpaces().ToString();

            lblRevenue.Text =
                "RM " + manager.TotalRevenue.ToString("F2");

            UpdateParkingButtons();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDashboard();

            MessageBox.Show("Dashboard updated!");
        }
        private void UpdateParkingButtons()
        {
            Button[] buttons =
            {
        btnSpace01, btnSpace02, btnSpace03,
        btnSpace04, btnSpace05, btnSpace06,
        btnSpace07, btnSpace08, btnSpace09,
        btnSpace10, btnSpace11, btnSpace12
    };

            var spaces = manager.GetSpaces();

            for (int i = 0; i < buttons.Length; i++)
            {
                if (spaces[i].IsOccupied)
                {
                    buttons[i].Text = "P" + (i + 1) + "\nOccupied";
                    buttons[i].BackColor = Color.IndianRed;
                }
                else
                {
                    buttons[i].Text = "P" + (i + 1) + "\nAvailable";
                    buttons[i].BackColor = Color.LightGreen;
                }
            }
        }

        private void dgvParkingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
