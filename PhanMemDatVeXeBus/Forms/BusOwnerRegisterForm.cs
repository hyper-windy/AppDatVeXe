using System;
using System.Windows.Forms;

namespace PhanMemDatVeXeBus
{
    public partial class BusOwnerRegisterForm : Form
    {
        public BusOwnerRegisterForm()
        {
            InitializeComponent();
        }

        private void registerSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidInformation())
            {
                System.Windows.Forms.MessageBox.Show("Invalid information.\nPlease try again!");
                return;
            }

            if (GlobalConfig.Guest_byUsername(username.Text).Count > 0 ||
                GlobalConfig.Owner_byUsername(username.Text).Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("This username has been used.\nPlease try a different one!");
            }
            else
            {
                OwnerModel aguest = new OwnerModel(name.Text, phonenumber.Text, username.Text, password.Text);
                GlobalConfig.Owners.Add(aguest);
                GlobalConfig.OwnerUser = aguest.Id;

                this.Close();
                BusOwnerForm form = new BusOwnerForm();
                form.ShowDialog();
            }
        }

        private bool ValidInformation()
        {
            bool valid = true;

            if (name.Text.Length < 1)
                valid = false;

            int int_holder = 0;
            if (!int.TryParse(phonenumber.Text, out int_holder))
                valid = false;

            if (password.Text != password2.Text)
                valid = false;

            return valid;
        }
    }
}
