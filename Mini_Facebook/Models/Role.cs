using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Facebook.Models
{
    public class Role:IdentityRole
    {
        public Role():base()
        {

        }
        //[Key]
        //public int ID { get; set; }

        //[Required(ErrorMessage ="You must enter Role Name")]
        //public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool Deleted { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Admin> Admins { get; set; }

    }
}
