using System.Collections.Generic;
using System.Diagnostics;

namespace PhanMemDatVeXeBus
{
    public class OwnerModel
    {
        public static int counter = 0;
    
        public int Id { get; set;} // Thêm set!!
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public OwnerModel(string name, string phoneNumber, string username, string password, int id = -1)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Username = username;
            Password = password;

            if (id == -1)
            {
                Id = counter;
                counter++;
            }
            else
                Id = id;

            string info = $"new OwnerModel(\"{ name }\", \"{ phoneNumber }\", \"{ username }\", \"{ password }\")";
            Debug.WriteLine(info);
        }

        public OwnerModel() {}
    }
}
