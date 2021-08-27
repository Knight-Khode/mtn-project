using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Church_Web.Db_Model
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
       // public string PayerID { get; set; }
        public string Currency { get; set; }
        public string Amount { get; set; }
        public string  PaymentType { get; set; }
        public string Remark { get; set; }
        public DateTime PaymentDate { get; set; }
        public string OPAtransID { get; set; }
        public string XReferenceID { get; set; }
        public string Desc { get; set; }

        [ForeignKey("Id")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("ChurchMember")]
        public string ChurchMembersID { get; set; }
        public ChurchMembers ChurchMembers { get; set; }

    }
}
