using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhanMemDatVeXeBus
{
    public class BusModel
    {
        public static int Counter = 0;

        public int Id { get; set;} // Thêm set !!!
        public int OwnerId { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string DepartTime { get; set; }
        public double Price { get; set; }

        public BusModel (int ownerId, string start, string end, string departTime, string price, int id = -1)
        {
            OwnerId = ownerId;
            Start = start;
            End = end;
            DepartTime = departTime;
            Price = double.Parse(price);
            if (id == -1)
            {
                Id = Counter;
                Counter++;
            }
            else
                Id = id;

            string info = $"new BusModel (\"{ ownerId }\", \"{ start }\", \"{ end }\", \"{ departTime }\", \"{ price }\")";
            Debug.WriteLine(info);
        }

        public BusModel() {}
    }
}
