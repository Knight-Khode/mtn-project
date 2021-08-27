using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Church_Web.Db_Model
{
    public class ChildComment
    {
        [Key]
        public int ChildCommentID { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }

        [ForeignKey("ParentComment")]
        public int ParentCommentID { get; set; }
        public ParentComment ParentComment { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
