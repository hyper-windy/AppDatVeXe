using System;
using System.Windows.Forms;

namespace PhanMemDatVeXeBus
{
    public partial class DashboardForm : Form
    {
        // TODO: Add mysite button
        public DashboardForm()
        {
            InitializeComponent();
        }
        
        private void buttonBooking_Click(object sender, EventArgs e)
        {
            FindTicketForm tkb = new FindTicketForm();
            tkb.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát phần mềm?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.ShowDialog();

            if (GlobalConfig.GuestUser != -1) // Guest logged in
            {
                GuestForm form = new GuestForm();
                form.ShowDialog();
            }
            else if (GlobalConfig.OwnerUser != -1) // Owner logged in
            {
                BusOwnerForm form = new BusOwnerForm();
                form.ShowDialog();
            }
        }

        private void guestRegisterButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Show();
            GuestRegisterForm log = new GuestRegisterForm();
            log.ShowDialog();
        }

        private void ownerRegisterButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Show();
            BusOwnerRegisterForm log = new BusOwnerRegisterForm();
            log.ShowDialog();
        }
    }
}
