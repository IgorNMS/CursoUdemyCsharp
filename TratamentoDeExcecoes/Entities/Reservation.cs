using System;
using TratamentoDeExcecoes.Entities.Exceptions;

namespace TratamentoDeExcecoes.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
            
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(Checkin);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                   + RoomNumber
                   + ", check-in: "
                   + Checkin.ToString("dd/MM/yyyy")
                   + ", check-out: "
                   + CheckOut.ToString("dd/MM/yyyy")
                   + ", "
                   + Duration()
                   + " nights";
        }
    }
}