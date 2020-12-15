using System.Diagnostics;

namespace PhanMemDatVeXeBus
{
    public class TicketModel
    {
        public static int Counter = 0;

        public int Id { get; set; } // Thêm set!!!
        public int BusId { get; set; }
        public int GuestId { get; set; }
        public string Seat { get; set; }
        public string Button { get; set; } // 1 || 2
        public TicketModel(int busId, int guestId, string seat, string button, int id = -1)
        {
            BusId = busId;
            GuestId = guestId;
            Seat = seat;
            Button = button;

            if (id == -1)
            {
                Id = Counter;
                Counter++;
            }
            else
                Id = id;

            string info = $"new TicketModel('{busId}', '{guestId}', '{seat}', '{button}', '{Id}')";
            Debug.WriteLine(info);
        }
        public TicketModel() { }
    }
}
