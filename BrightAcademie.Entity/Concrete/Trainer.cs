using BrightAcademie.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BrightAcademie.Entity.Concrete
{
    public class Trainer :IdentityUser
    {
        public string Gender;
        public string Address;
        public string City;
        public DateTime DateOfBirth;

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool  IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthOfYear { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Url { get; set; }
        public string About { get; set; }
        public string PhotoUrl { get; set; }
        public string Field { get; set; }   
        public  decimal Evaluation {  get; set; }
        public List<Course> Course { get; set; }
    }


}
