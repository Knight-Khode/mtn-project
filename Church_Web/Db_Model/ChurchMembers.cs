using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Church_Web.Db_Model
{
    public class ChurchMembers
    {
        [Key]
        public int ChurchMemberID { get; set; }
        public DateTime DateSubscribe { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public User User { get; set; }

       [ForeignKey("Church")]
        public int ChurchId { get; set; }
        public Church Church { get; set; }

        public ICollection<Payment> Payments { get; set; }

    }
}
