using Di_Station.DATA.Concrete;
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
    public partial class KullaniciArayuzu : Form
    {

        private User _user;
        public KullaniciArayuzu(User user)
        {
            InitializeComponent();

            _user = user;
        }

        private void KullaniciArayuzu_Load(object sender, EventArgs e)
        {
            label_KarsilamaLabel.Text =   _user.FirstName.ToUpper() + " " + _user.LastName.ToUpper();
        }
    }
}
