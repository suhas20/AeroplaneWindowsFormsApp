using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class Form1 : Form
    {
        private List<Seat> firstClassSeats = new List<Seat>();
        private List<Seat> economyClassSeats = new List<Seat>();
        private bool seatingArrangementShown = false;
        public Form1()
        {
            InitializeComponent();
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Seat seat = new Seat(GetSeatType(j), TravelClass.FIRST_CLASS);
                    firstClassSeats.Add(seat);
                }
            }

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Seat seat = new Seat(GetSeatTypeEco(j), TravelClass.ECONOMY_CLASS);
                    economyClassSeats.Add(seat);
                }
            }
        }
        private SeatType GetSeatTypeEco(int seatIndex)
        {
            if (seatIndex % 6 == 0 || (seatIndex - 5) % 6 == 0) // First or sixth seat in each row is a Window seat
            {
                return SeatType.WINDOW;
            }
            else if ((seatIndex - 1) % 6 == 0 || (seatIndex - 4) % 6 == 0) // Second or third seat in each row is a Center seat
            {
                return SeatType.CENTER;
            }
            else if ((seatIndex - 2) % 6 == 0 || (seatIndex - 3) % 6 == 0) // Fourth or fifth seats are Aisle seats
            {
                return SeatType.AISLE;
            }
            else
            {
                // This should not happen if you have exactly 6 seats per row, but handle any other cases accordingly
                return SeatType.UNKNOWN;
            }
        }

        private SeatType GetSeatType(int seatIndex)
        {
            if (seatIndex % 4 == 0 || (seatIndex - 3) % 4 == 0) // First seat in each row is a Window seat
            {
                return SeatType.WINDOW;
            }
            /*else if ((seatIndex - 1) % 4 == 0) // Second seat in each row is a Center seat
            {
                return SeatType.CENTER;
            }*/
            else /*if ((seatIndex - 2) % 4 == 0 || (seatIndex - 3) % 4 == 0)*/ // Third and fourth seats are Aisle seats
            {
                return SeatType.AISLE;
            }
        }


        private void btnAssignSeats_Click(object sender, EventArgs e)
        {
            TravelClass selectedTravelClass = GetSelectedTravelClass();
            SeatType selectedSeatType = GetSelectedSeatType();
            int numPassengers = (int)numPassengersSelector.Value;

            List<Seat> selectedSeats = (selectedTravelClass == TravelClass.FIRST_CLASS) ? firstClassSeats : economyClassSeats;

            if (TryAssignSeats(selectedSeats, numPassengers, selectedSeatType))
            {
                MessageBox.Show($"Seats assigned successfully in {selectedTravelClass} class.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                seatingArrangementShown = true;
            }
            else
            {
                MessageBox.Show("No available seats for the requested number of passengers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryAssignSeats(List<Seat> seats, int numPassengers, SeatType seatPreference)
        {
            int availableSeats = 0;

            foreach (Seat seat in seats)
            {
                if (!seat.IsAssigned && seat.SeatType == seatPreference)
                {
                    availableSeats++;

                    if (availableSeats == numPassengers)
                    {
                        for (int i = 0; i < numPassengers; i++)
                        {
                            seats[seats.IndexOf(seat) - i].IsAssigned = true;
                            seats[seats.IndexOf(seat) - i].PassengerName = textBox1.Text;
                        }
                        return true;
                    }
                }
                else
                {
                    availableSeats = 0;
                }
            }

            return false;
        }

        private void btnShowSeating_Click(object sender, EventArgs e)
        {
            // Show the seating arrangement in a new form
            using (SeatingArrangementForm seatingArrangementForm = new SeatingArrangementForm(SerializeSeats(firstClassSeats), TravelClass.FIRST_CLASS))
            {
                seatingArrangementForm.ShowDialog();
            }
        }

        private void btnShowSeatingEco_Click(object sender, EventArgs e)
        {
            using (SeatingArrangementForm seatingArrangementForm = new SeatingArrangementForm(SerializeSeats(economyClassSeats), TravelClass.ECONOMY_CLASS))
            {
                seatingArrangementForm.ShowDialog();
            }
        }

        private byte[] SerializeSeats(List<Seat> seats)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                formatter.Serialize(memoryStream, seats);
                return memoryStream.ToArray();
            }
        }

        private TravelClass GetSelectedTravelClass()
        {
            if (radioBtnFirstClass.Checked)
            {
                return TravelClass.FIRST_CLASS;
            }
            else if (radioBtnEconomyClass.Checked)
            {
                return TravelClass.ECONOMY_CLASS;
            }
            else
            {
                // Default to Economy Class if none selected
                return TravelClass.ECONOMY_CLASS;
            }
        }

        private SeatType GetSelectedSeatType()
        {
            if (radioBtnWindow.Checked)
            {
                return SeatType.WINDOW;
            }
            else if (radioBtnCenter.Checked)
            {
                return SeatType.CENTER;
            }
            else if (radioBtnAisle.Checked)
            {
                return SeatType.AISLE;
            }
            else
            {
                // Default to Window if none selected
                return SeatType.WINDOW;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string passengerNameToDelete = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(passengerNameToDelete))
            {
                MessageBox.Show("Please enter a passenger name to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TravelClass classTypeToDelete = radioBtnFirstClass.Checked ? TravelClass.FIRST_CLASS : TravelClass.ECONOMY_CLASS;

            bool seatDeleted = DeleteSeat(passengerNameToDelete, classTypeToDelete);

            if (seatDeleted)
            {
                MessageBox.Show($"Seat for passenger '{passengerNameToDelete}' in {classTypeToDelete} class deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //UpdateSeatsGrid();
            }
            else
            {
                MessageBox.Show($"No seat found for passenger '{passengerNameToDelete}' in {classTypeToDelete} class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteSeat(string passengerName, TravelClass classType)
        {
            List<Seat> seatsToDeleteFrom;

            if (classType == TravelClass.FIRST_CLASS)
            {
                seatsToDeleteFrom = firstClassSeats;
            }
            else
            {
                seatsToDeleteFrom = economyClassSeats;
            }

            Seat seatToDelete = seatsToDeleteFrom.FirstOrDefault(seat => seat.PassengerName == passengerName);

            if (seatToDelete != null)
            {
                seatToDelete.PassengerName = "";
                seatToDelete.IsAssigned = false;
                return true;
            }

            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

