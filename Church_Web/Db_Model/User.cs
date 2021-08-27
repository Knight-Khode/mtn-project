using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Church_Web.Db_Model
{
    public class User: IdentityUser
    {
        public  string FullName { get; set; }

        public ICollection<ChurchMembers> ChurchMembers { get; set; }
        public ICollection<ChildComment> ChildComments { get; set; }
        public ICollection<ParentComment> ParentComment { get; set; }
        public ICollection<EbuCusComments> EbuCusComments { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
