using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Church_Web.Db_Model
{
    public class ParentComment
    {
        [Key]
        public int ParentCommentID { get; set; }
        public string CommentM { get; set; }
        public DateTime CommentDate { get; set; }
        public string VID { get; set; }
        public string CID { get; set; }


        [ForeignKey("Id")]
        public string UserId{ get; set; }
        public User User { get; set; }

        public ICollection<ChildComment> ChildComment { get; set; }
        
    }
}
