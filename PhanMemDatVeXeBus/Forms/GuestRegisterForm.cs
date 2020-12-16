using System;
using System.Windows.Forms;

namespace PhanMemDatVeXeBus
{
    public partial class GuestRegisterForm : Form
    {
        public GuestRegisterForm()
        {
            InitializeComponent();
        }

        private void GuestRegisterSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidInformation())
            {
                System.Windows.Forms.MessageBox.Show("Invalid information.\nPlease try again!");
            }
            else if (GlobalConfig.Guest_byUsername(username.Text).Count > 0 ||
                     GlobalConfig.Owner_byUsername(username.Text).Count > 0)
            {
                // Notify that user has been used
                System.Windows.Forms.MessageBox.Show("This username has been used.\nPlease try a different one!");
            }
            else
            {
                GuestModel aguest = new GuestModel(name.Text, phonenumber.Text, username.Text, password.Text, address.Text);
                GlobalConfig.Guests.Add(aguest);
                GlobalConfig.GuestUser = aguest.Id;
                this.Close();
            }
        }

        private bool ValidInformation()
        {
            bool valid = true;

            if (name.Text.Length < 1)
                valid = false;

            //if (address.Text.Length < 1)
            //    valid = false;

           // if (!int.TryParse(phonenumber.Text, out int int_holder))
            //    valid = false;
            int int_holder; 
            if (!int.TryParse(phonenumber.Text, out  int_holder))
                valid = false;


            if (password.Text != password2.Text)
                valid = false;

            return valid;
        }
    }
}
