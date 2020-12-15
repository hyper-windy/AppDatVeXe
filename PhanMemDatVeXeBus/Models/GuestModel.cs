using System.Collections.Generic;
using System.Diagnostics;

namespace PhanMemDatVeXeBus
{
    public class GuestModel
    {
        public static int Counter = 0;

        public int Id { get; set;} //Thêm set!!
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public GuestModel(string name, string phoneNumber, string username, string password, string address, int id = -1)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Username = username;
            Password = password;
            Address = address;
            if (id == -1) // created in main by default method
            {
                Id = Counter;
                Counter++;
            }
            else // Load from DB
                Id = id;

            string info = $"new GuestModel(\"{ name }\", \"{ phoneNumber }\", \"{ username }\", \"{ password }\")";
            Debug.WriteLine(info);
        }
        public GuestModel() {}
    }
}
