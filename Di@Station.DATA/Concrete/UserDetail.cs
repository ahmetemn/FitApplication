using Di_Station.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
    public class UserDetail:BaseDiet
    {
        public bool Gender { get; set; }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }  private set {; } 
        }
        public double Weight { get; set; }

        private double _height;
        public double Height
        {
            get
            {
                return _height / 100;
            }

            set
            {
                _height = value; 
            }
        }
        public string City { get; set; }
        public string Job { get; set; }

        public User User { get; set; }
    }
}
