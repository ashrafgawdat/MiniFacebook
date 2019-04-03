using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Facebook.Models
{
    public class User:IdentityUser
    {
        public User():base()
        {

        }
        //[Key]
        //public int ID { get; set; }

        [Required(ErrorMessage ="You must Enter your First Name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[EmailAddress]
        //[Required(ErrorMessage = "You must Enter your Email")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "You must Enter Password")]
        //[MinLength(6)]
        //public string Password { get; set; }

        public string PhotoSrc { get; set; }

        [Required(ErrorMessage = "You must Enter your Gender")]
        public bool Gender { get; set; }

        public bool Deleted { get; set; }

        [MaxLength(50)]
        public string Bio { get; set; }
        public DateTime Birthday { get; set; }

        

        [ForeignKey("Role")]
        public string RoleID { get; set; }

        public Role Role { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<Friendship> Friends { get; set; }
        public ICollection<Friendship> Users { get; set; }

        public ICollection<Like> Likes { get; set; }

    }
}
