using System.Windows.Forms;

namespace PhanMemDatVeXeBus
{
    public partial class AccountProfileForm : Form
    {
        public AccountProfileForm()
        {
            InitializeComponent();
            LoadInfo(); 
        }

        public void LoadInfo() {
            if (GlobalConfig.GuestUser != -1) {
                name.Text = GlobalConfig.Guests[GlobalConfig.GuestUser].Username;
                phonenumber.Text = GlobalConfig.Guests[GlobalConfig.GuestUser].PhoneNumber;
                username.Text = GlobalConfig.Guests[GlobalConfig.GuestUser].Username;
                password.Text = GlobalConfig.Guests[GlobalConfig.GuestUser].Password; 
            }
            else if (GlobalConfig.OwnerUser != -1)
            {
                name.Text = GlobalConfig.Owners[GlobalConfig.OwnerUser].Name;
                phonenumber.Text = GlobalConfig.Owners[GlobalConfig.OwnerUser].PhoneNumber;
                username.Text = GlobalConfig.Owners[GlobalConfig.OwnerUser].Username;
                password.Text = GlobalConfig.Owners[GlobalConfig.OwnerUser].Password;
            }
        }
    }
}
