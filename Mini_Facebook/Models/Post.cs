using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Facebook.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Post msut has Body")]
        public string Body { get; set; }

        public DateTime Date { get; set; }

        public bool Deleted { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }

        public User User { get; set; }

        public ICollection<Like> Likes { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
