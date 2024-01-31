using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Di_Station.DATA.Concrete;
using Di_Station.Service.Interface;
using Di_Station.Service.Concrate;

namespace Di_Base.UI
{
    public partial class KayıtDevam : Form
    {

        private UserDetail _userDetail;

        private readonly IUserSERVICE _userService; 
        public KayıtDevam(UserDetail userDetail)
        {


            InitializeComponent();
            _userDetail = userDetail; 
            _userService = new UserSERVICE(); 
        }


        private void button_KayıtOl_Click(object sender, EventArgs e)
        {
            User user = new User
            {

                UserDetailId=_userDetail.ID,
                UserName=textBox_KullaniciAdi.Text,
                Password=textBox_Password.Text,
                FirstName=textBox_Adı.Text,
                LastName=textBox_SoyAdı.Text,   
                Email=textBox_Email.Text,       

            };
                  _userService.Create(user);
                MessageBox.Show("Kayıt Başarılı Login Olunuz"); 
                this.Close();   
            

                 
        }

    }
}












//Random rnd = new Random();
//string onayKodu;


//onayKodu = rnd.Next(100, 999).ToString();

//MailMessage mailMessage = new MailMessage("hasanozdemir.244@gmail.com", textBox_Email.Text, "Güvenlik Kodu", "Güvenlik kodu: " + onayKodu);

//SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
//smtpClient.EnableSsl = true;

//// Gmail üzerinden gönderiyorsanız, Gmail hesap bilgilerinizi aşağıdaki satırda belirtin
//smtpClient.Credentials = new NetworkCredential(textBox_Email.Text, textBox_Password.Text);

//try
//{
//    smtpClient.Send(mailMessage);
//    MessageBox.Show("Mailinizi Kontrol edin");
//}
//catch (Exception ex)
//{
//    MessageBox.Show("Mail gönderme hatası: " + ex.Message);
//}