using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Church_Web.Db_Model
{
    public class EbuCusComments
    {
        [Key]
        public int EbuCusCommentsId { get; set; }
        //public string FullName { get; set; }
        public string Comments { get; set; }
        public DateTime CommentDate { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
