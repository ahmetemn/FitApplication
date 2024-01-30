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

namespace Di_Base.UI
{
    public partial class KayıtDevam : Form
    {
        public KayıtDevam()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        string onayKodu;
        private void button_KayıtOl_Click(object sender, EventArgs e)
        {
            onayKodu = rnd.Next(100, 999).ToString();

            MailMessage mailMessage = new MailMessage("hasanozdemir.244@gmail.com", textBox_Email.Text, "Güvenlik Kodu", "Güvenlik kodu: " + onayKodu);

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;

            // Gmail üzerinden gönderiyorsanız, Gmail hesap bilgilerinizi aşağıdaki satırda belirtin
            smtpClient.Credentials = new NetworkCredential( textBox_Email.Text, textBox_Password.Text);

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Mailinizi Kontrol edin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme hatası: " + ex.Message);
            }
        }

    }
}
