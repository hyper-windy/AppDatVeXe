using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PhanMemDatVeXeBus
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
            var guest = GlobalConfig.CurrentGuest();
            name.Text = guest.Username;
            phonenumber.Text = guest.PhoneNumber;
            address.Text = guest.Address;
            LoadBusList(); 
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountProfileForm ac = new AccountProfileForm();
            ac.ShowDialog();
            ac.Hide();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalConfig.GuestUser = -1; 
            this.Close(); 
        }

        private void buyticket_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindTicketForm findticket = new FindTicketForm();
            findticket.ShowDialog();
            LoadBusList(); 
            this.Show(); 
        }
        
        private void viewBusDetail(object sender, EventArgs e)
        {
            // TODO: GlobalConfig.currentBus = get from UI
            BusInfoGuestForm form = new BusInfoGuestForm();
            form.ShowDialog();
        }

        private void BusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Close();
                // GlobalConfig.currentBus = get from UI
                foreach (BusModel bus in GlobalConfig.Buses)
                {
                    var owner = GlobalConfig.Owner_byId(bus.OwnerId)[0];
                    if (bus.Start == dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()
                        && bus.End == dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() &&
                        bus.Price.ToString() == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()
                        && owner.Name == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        GlobalConfig.currentBus = bus;
                        break;
                    }
                }
                BusInfoForm businfo = new BusInfoForm();
                businfo.ShowDialog();
            }
        }
        public class tempBusInfo
        {
            public string BusOwnerName { get; set; }
            public string StartingPoint { get; set; }
            public string EndingPoint { get; set; }
            public string Time { get; set; }
            public double TicketPrize { get; set; }
            public tempBusInfo(string BusOwnerName, string StartingPoint, string EndingPoint, string Time, double TicketPrize)
            {
                this.BusOwnerName = BusOwnerName;
                this.StartingPoint = StartingPoint;
                this.EndingPoint = EndingPoint;
                this.Time = Time;
                this.TicketPrize = TicketPrize;
            }
        }

        private void LoadBusList() {
            List<tempBusInfo> alist = new List<tempBusInfo>();
            foreach (var ticket in GlobalConfig.Tickets) 
            {
                if (ticket.GuestId == GlobalConfig.GuestUser) 
                {
                    foreach (var bus in GlobalConfig.Buses) 
                    {
                        if (bus.Id == ticket.BusId) 
                        {
                            var owner = GlobalConfig.Owner_byId(bus.OwnerId)[0];
                            alist.Add(new tempBusInfo(owner.Name, bus.Start, bus.End, bus.DepartTime, bus.Price));
                        }
                    }
                }
            }

            dataGridView1.DataSource = alist;
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.DataSource = alist;
            dataGridView2.Update();
            dataGridView2.Refresh(); 
        }



    }
}
