using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum SeatType
    {
        WINDOW,
        CENTER,
        AISLE,
        UNKNOWN
    }

    public enum TravelClass
    {
        FIRST_CLASS = 1,
        ECONOMY_CLASS = 2
    }
    [Serializable]
    public class Seat
    {
        public string SeatNumber { get; set; }
        public string PassengerName { get; set; }
        public bool IsAssigned { get; set; }
        public SeatType SeatType { get; set; }
        public TravelClass Class { get; set; }

        public Seat(SeatType seatType, TravelClass travelClass)
        {
            this.SeatType = seatType;
            this.Class = travelClass;
            this.SeatNumber = GenerateSeatNumber();
            this.PassengerName = "";
            this.IsAssigned = false;
        }

        private string GenerateSeatNumber()
        {
            // Implement your seat number generation logic here
            // For simplicity, you can use a counter or any other method
            return "Seat" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
        }
    }
}
