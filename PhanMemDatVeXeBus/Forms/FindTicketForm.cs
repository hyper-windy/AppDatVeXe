using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace PhanMemDatVeXeBus
{
    public partial class FindTicketForm : Form
    {
        public FindTicketForm()
        {
            InitializeComponent();
            LoadList();
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
        private void BusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // GlobalConfig.currentBus = get from UI
            if (e.RowIndex >= 0)
            {
                this.Close();
                foreach (BusModel bus in GlobalConfig.Buses)
                {
                    var owner = GlobalConfig.Owner_byId(bus.OwnerId)[0];
                    if (bus.Start == BusList.Rows[e.RowIndex].Cells[1].Value.ToString()
                        && bus.End == BusList.Rows[e.RowIndex].Cells[2].Value.ToString() &&
                        bus.Price.ToString() == BusList.Rows[e.RowIndex].Cells[4].Value.ToString()
                        && owner.Name == BusList.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        GlobalConfig.currentBus = bus;
                        break;
                    }
                }
                BusInfoForm businfo = new BusInfoForm();
                businfo.ShowDialog();
            }
             
        }

        private void buttonFindTicket_Click(object sender, EventArgs e)
        {
            LoadList();
        }


        private void LoadList()
        {
            // TODO: Fix DataGridView
            List<tempBusInfo> alist = new List<tempBusInfo>();
            var buses = GlobalConfig.Bus_byInfo(startingpoint.Text, endingpoint.Text);
            
            foreach (var bus in buses)
            {
                var owner = GlobalConfig.Owner_byId(bus.OwnerId)[0];
                alist.Add(new tempBusInfo(owner.Name, bus.Start, bus.End, bus.DepartTime, bus.Price));
            }

            if (alist.Count <= 0) MessageBox.Show("Hiện tại không có chuyến đi này!");
            else
            {
                BusList.DataSource = alist;
                BusList.Update();
                BusList.Refresh();
            }
        }
    }
}
