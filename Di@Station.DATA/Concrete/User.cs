using Di_Station.DATA.Abstract;
using Di_Station.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Concrete
{
	public class User :BaseDiet
	{
        public string  UserName { get; set; }
		public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; } = "User"; 
        public int UserDetailId { get; set; }
        public UserDetail UserDetail { get; set; }      
        public ICollection<UserOgunYemekCesidi> UserOgunYemekCesidis { get; set; }

    }
}
