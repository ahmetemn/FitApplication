using Di_Station.DATA.Concrete;
using Di_Station.Service.Concrate;
using Di_Station.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Di_Base.UI
{
    public partial class UygulamaAcilis : Form
    {

        IUserDetailSERVICE _userDetailService;


        public UygulamaAcilis()
        {
            InitializeComponent();
            _userDetailService = new UserDetailSERVICE();
        }



        private void button_DevamEt_Click(object sender, EventArgs e)
        {
            DateTime birthDate = new DateTime(
              dateTimePicker_DogumTarihi.Value.Year,
              dateTimePicker_DogumTarihi.Value.Month,
              dateTimePicker_DogumTarihi.Value.Day
              );

            var result = _userDetailService.Create(new UserDetail
            {

                Gender = radioButton_Erkek.Checked ? true : false,
                BirthDate = birthDate,
                Weight = (double)numericUpDown_Kilo.Value,
                Height = (double)numericUpDown_Boy.Value,
                City = textBox_Sehir.Text,
                Job = textBox_Meslek.Text,


            });
         





            KayıtDevam kayıtDevam = new KayıtDevam(); 
            kayıtDevam.ShowDialog();
        }
    }
}
