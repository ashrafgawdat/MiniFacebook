using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Facebook.Models
{
    public class Friendship
    {
        [Key]
        //[ForeignKey("User")]
        public string UserID { get; set; }

        [Key]
        //[ForeignKey("Friend")]
        public string FriendID { get; set; }

        public bool Deleted { get; set; }

        public User User { get; set; }

        public User Friend { get; set; }
    }
}
