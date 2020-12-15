using System.Windows.Forms;
using System.Drawing;
using System;

namespace PhanMemDatVeXeBus
{
    public partial class BusInfoGuestForm : Form
    {
        BusModel bus = new BusModel();

        public BusInfoGuestForm()
        {
            InitializeComponent();
            bus = GlobalConfig.currentBus;
            LoadBusinfo();
        }

        private void LoadBusinfo()
        {
            LoadSeatMap();
            var owner = GlobalConfig.Owner_byId(bus.OwnerId)[0];
            name.Text = owner.Name;
            phonenumber.Text = owner.PhoneNumber;
            start.Text = bus.Start;
            end.Text = bus.End;
            // TODO: điểm đến vs thời gian đi
            departtime.Text = bus.DepartTime;
            expecttime.Text = "!!!"; // ??
            price.Text = bus.Price.ToString();
        }


        private void LoadSeatMap()
        {
            var takenSeats = GlobalConfig.SeatMap(bus.Id);

            foreach (Button but in TangDuoi.Controls)
            {
                if (takenSeats.Contains(but.Name)) but.BackColor = Color.Red;
                else but.BackColor = Color.White;
            }
            foreach (Button but in TangTren.Controls)
            {
                if (takenSeats.Contains(but.Name)) but.BackColor = Color.Red;
                else but.BackColor = Color.White;
            }
        }
    }
}
