using System.Windows.Forms;
using System.Drawing;
using System;

namespace PhanMemDatVeXeBus
{
    public partial class BusInfoForm : Form
    {
        static BusModel bus = new BusModel();

        public BusInfoForm()
        {
            InitializeComponent();
            bus = GlobalConfig.currentBus;
            LoadBusinfo();
        }

        private void LoadBusinfo()
        {
            LoadSeatMap();
            var owner = GlobalConfig.Owner_byId(GlobalConfig.currentBus.OwnerId)[0];
            name.Text = owner.Name;
            phonenumber.Text = owner.PhoneNumber;
            start.Text = GlobalConfig.currentBus.Start;
            end.Text = GlobalConfig.currentBus.End;
            // TODO: điểm đến vs thời gian đi
            departtime.Text = GlobalConfig.currentBus.DepartTime;
            expecttime.Text = "!!!"; // ??
            price.Text = GlobalConfig.currentBus.Price.ToString();
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

        private void Seat_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            if (but.BackColor == Color.Red)
                MessageBox.Show("Chỗ này đã được đặt\n Vui lòng chọn chỗ ngồi khác!");
            else if (but.BackColor == Color.Yellow)
                but.BackColor = Color.White;
            else
                but.BackColor = Color.Yellow;
        }

        private void buyTicket_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.GuestUser != -1)
            {
                int counter = 0;
                foreach (Button but in TangDuoi.Controls)
                {
                    if (but.BackColor == Color.Yellow)
                    {
                        GlobalConfig.AddTicket(bus, but.Text, but.Name);
                        counter++;
                    }
                }
                foreach (Button but in TangTren.Controls)
                {
                    if (but.BackColor == Color.Yellow)
                    {
                        GlobalConfig.AddTicket(bus, but.Text, but.Name);
                        counter++;
                    }
                }
                if (counter > 0)
                    MessageBox.Show("Thành công!");
                else
                    MessageBox.Show("Bạn chưa chọn ghế");
                this.Close();
                GuestForm form = new GuestForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!");
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
        }
    }
}
