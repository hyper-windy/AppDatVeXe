using System.Collections.Generic;
using System.Linq;

namespace PhanMemDatVeXeBus
{
    public static class GlobalConfig
    {
        public static List<GuestModel> Guests { get; set; }
        public static List<OwnerModel> Owners { get; set; }
        public static List<BusModel> Buses { get; set; }
        public static List<TicketModel> Tickets { get; set; }
        public static int GuestUser { get; set; }
        public static int OwnerUser { get; set; }
        public static BusModel currentBus { get; set; }
        public static void Init()
        {
            Guests = new List<GuestModel>();
            Owners = new List<OwnerModel>();
            Buses = new List<BusModel>();
            Tickets = new List<TicketModel>();
            GuestUser = -1;
            OwnerUser = -1;
            currentBus = new BusModel();

            // Testing
            Owners.Add(new OwnerModel("admin", "0123", "admin", ""));
            Buses.Add(new BusModel(0, "TP. Hồ Chí Minh", "Vũng Tàu", "100", "3000"));
            Buses.Add(new BusModel(0, "Đà Nẵng", "Vũng Tàu", "1000", "7000"));
            Guests.Add(new GuestModel("phuc guest", "911", "phuc", "", "hcm"));
            currentBus = Buses[0];
        }

        public static GuestModel CurrentGuest()
        {
            var alist = from guest in GlobalConfig.Guests
                        where guest.Id == GlobalConfig.GuestUser
                        select guest;
            return alist.First();
        }
        public static OwnerModel CurrentOwner()
        {
            var alist = from user in GlobalConfig.Owners
                        where user.Id == GlobalConfig.OwnerUser
                        select user;
            return alist.First();
        }

        public static List<GuestModel> Guest_byUsername(string username)
        {
            var alist = from user in Guests
                        where user.Username == username
                        select user;
            return alist.ToList();
        }

        public static List<GuestModel> Guest_byId(int id)
        {
            var alist = from user in Guests
                        where user.Id == id
                        select user;
            return alist.ToList();
        }

        public static List<OwnerModel> Owner_byUsername(string username)
        {
            var alist = from user in Owners
                        where user.Username == username
                        select user;
            return alist.ToList();
        }

        public static List<OwnerModel> Owner_byId(int id)
        {
            var alist = from user in Owners
                        where user.Id == id
                        select user;
            return alist.ToList();
        }
        
        public static List<string> SeatMap(int busId)
        {
            var alist = from ticket in Tickets
                        where ticket.BusId == busId
                        select ticket.Button;
            return alist.ToList();
        }
        public static List<BusModel> Bus_byInfo(string start, string end)
        {
            var alist = from bus in Buses
                        where (bus.Start == start || start == "")
                        where (bus.End == end || end == "")
                        select bus;
            return alist.ToList();
        }

        public static void AddTicket(BusModel bus, string seat, string button)
        {
            var t = new TicketModel(bus.Id, GuestUser, seat, button);
            Tickets.Add(t);
        }


    }
}
