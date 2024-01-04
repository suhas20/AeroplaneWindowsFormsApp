using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class SeatingArrangementForm : Form
    {
        private List<Seat> seats;
        public SeatingArrangementForm(byte[] serializedSeats, TravelClass travelClass)
        {
            InitializeComponent();
            InitializeSeatsGrid();
            DeserializeSeats(serializedSeats);
            this.Text = $"{travelClass} Class Seating Arrangement";
            UpdateSeatsGrid();
        }

        private void InitializeSeatsGrid() // Add this method
        {
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;

            // Assuming Seat is the class you are using
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "SeatNumber";
            dataGridView.Columns[1].Name = "PassengerName";
            dataGridView.Columns[2].Name = "IsAssigned";
            dataGridView.Columns[3].Name = "SeatType";
            dataGridView.Columns[4].Name = "Class";

            Controls.Add(dataGridView);
        }
        private void DeserializeSeats(byte[] serializedSeats)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(serializedSeats))
            {
                seats = (List<Seat>)formatter.Deserialize(memoryStream);
            }
        }
        private void UpdateSeatsGrid()
        {
            UpdateSeatsGrid(dataGridView, seats);
        }

        private void UpdateSeatsGrid(DataGridView dataGridView, List<Seat> seats)
        {
            dataGridView.Rows.Clear();

            foreach (Seat seat in seats)
            {
                dataGridView.Rows.Add(seat.SeatNumber, seat.PassengerName, seat.IsAssigned, seat.SeatType, seat.Class);
            }
        }

    }
}
