using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
namespace PhanMemDatVeXeBus
{
    public partial class BusOwnerForm : Form
    {
        private void BusListInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Hide();
                // reference to the selected bus 
                foreach (BusModel bus in GlobalConfig.Buses)
                {
                    if (bus.Start == BusListInfo.Rows[e.RowIndex].Cells[0].Value.ToString()
                        && bus.End == BusListInfo.Rows[e.RowIndex].Cells[1].Value.ToString()
                        && bus.DepartTime == BusListInfo.Rows[e.RowIndex].Cells[2].Value.ToString()
                        && bus.Price.ToString() == BusListInfo.Rows[e.RowIndex].Cells[3].Value.ToString()
                        )
                    {
                        GlobalConfig.currentBus = bus;
                        break;
                    }
                }
                // BusListInfo
                BusInfoBusOwnerForm businfoBO = new BusInfoBusOwnerForm();
                businfoBO.ShowDialog();
                this.Show();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalConfig.OwnerUser = -1;
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountProfileForm ac = new AccountProfileForm();
            ac.ShowDialog();
            this.Show();
        }

        private bool ValidInformation()
        {
            bool valid = true;

            if (startingpointing.Text == "")
                valid = false;

            if (endingpointing.Text == "")
                valid = false;

            int int_holder = 0;
            if (!int.TryParse(expecttime.Text, out int_holder))
                valid = false;
            double double_hodler = 0.0;
            if (!double.TryParse(price.Text, out double_hodler))
                valid = false;
            return valid;
        }

        public BusOwnerForm()
        {
            InitializeComponent();
            LoadBusListInfo();
        }

        private void LoadBusListInfo()
        {
            var alist = from bus in GlobalConfig.Buses
                        where bus.OwnerId == GlobalConfig.OwnerUser
                        select new
                        {
                            StartingPoint = bus.Start,
                            EndingPoint = bus.End,
                            Time = bus.DepartTime,
                            TicketPrice = bus.Price
                        };

            BusListInfo.DataSource = alist.ToList();
            BusListInfo.Update();
            BusListInfo.Refresh();
        }

        private void button_AddBus_Click(object sender, EventArgs e)
        {
            if (!ValidInformation()) MessageBox.Show("Invalid information.\nPlease try again!");
            else
            {
                int owner = GlobalConfig.OwnerUser;
                BusModel newbus = new BusModel(owner, startingpointing.Text,
                                                      endingpointing.Text,
                                                     // expecttime.Text,
                                                     dateTimePicker1.Value.ToShortDateString(),
                                                      price.Text);
                GlobalConfig.Buses.Add(newbus);
                LoadBusListInfo();
            }
        }
    }
}
