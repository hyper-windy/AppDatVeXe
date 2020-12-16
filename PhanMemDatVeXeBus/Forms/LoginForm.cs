using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PhanMemDatVeXeBus
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            GlobalConfig.GuestUser = -1;
            GlobalConfig.OwnerUser = -1;

            var userId = from guest in GlobalConfig.Guests
                         where guest.Username == username.Text
                         where guest.Password == password.Text
                         select guest.Id;

            if (userId.Count() > 0)
            {
                GlobalConfig.GuestUser = userId.First();
                this.Close();
                return;
            }


            userId = from owner in GlobalConfig.Owners
                     where owner.Username == username.Text
                     where owner.Password == password.Text
                     select owner.Id;

            if (userId.Count() > 0)
            {
                GlobalConfig.OwnerUser = userId.First();
                this.Close();
                return;
            }

            // Login again
            // TODO: Vieejt hoa
            {
                MessageBox.Show("Incorrect login info.\nPlease try again!");
                password.Text = "";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GuestRegisterForm form = new GuestRegisterForm();
            form.ShowDialog();
        }
    }
}
