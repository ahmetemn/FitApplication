using Di_Station.Service.Concrate;
using Di_Station.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Di_Base.UI
{
    public partial class Login : Form
    {
        IUserSERVICE _userService;
        IUserDetailSERVICE _userDetailService;  
        public Login()
        {
            InitializeComponent();
            _userService = new UserSERVICE();
            _userDetailService = new UserDetailSERVICE();   
        }
        private void button_AnketeGit_Click(object sender, EventArgs e)
        {
            UygulamaAcilis uygulamaAcilis = new UygulamaAcilis();

            uygulamaAcilis.ShowDialog(this);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var userData = _userService.GetAll();
            foreach (var item in userData)
            {
                if (item.Email == textBox_LoginEmail.Text && item.Password == textBox_LoginPassword.Text && item.Roles == "Admin")
                {

                    AdminArayuzu adminArayuzu = new AdminArayuzu();
                    adminArayuzu.Show();
                    return;
                }

                else if (item.Email == textBox_LoginEmail.Text && item.Password == textBox_LoginPassword.Text)
                {
                    KullaniciArayuzu kullaniciArayuzu = new KullaniciArayuzu(item);
                    kullaniciArayuzu.Show();
                    return; 
                }

            }

            MessageBox.Show("Hatalı şifre veya olmayan kullanıcı adı");
        }


    }
}
