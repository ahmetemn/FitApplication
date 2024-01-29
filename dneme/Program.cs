using Di_Station.DATA.Concrete;
using Di_Station.REPO.Context;

namespace dneme
{

    internal class Program
    {
        private readonly DietContext _db;


        static void Main(string[] args)
        {
           
            using( var  _db= new DietContext()) { 

                UserDetail userDetail = new UserDetail();

                userDetail.Gender = false;
                userDetail.BirthDate = new DateTime(2000, 5, 15); 
                userDetail.Weight = 180;
                userDetail.Height = 90;
                userDetail.City = "İstanbul";
                userDetail.Job = "Yazılımcı"; 
                userDetail.CreatedDate = DateTime.Now;  
                userDetail.UpdatedDate = DateTime.Now; 
                userDetail.DeletedDate = DateTime.Now;

                _db.UserDetail.Add(userDetail);



          
                _db.SaveChanges();

            }   

        

        }
    }
}