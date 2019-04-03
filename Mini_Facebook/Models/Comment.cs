using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Facebook.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Comment must has Body")]
        public string Body { get; set; }

        public bool Deleted { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }

        public Post Post { get; set; }
    }
}
