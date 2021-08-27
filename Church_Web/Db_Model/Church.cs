using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Church_Web.Db_Model
{
    public class Church
    {
        [Key]
        public int ChurchID { get; set; }
        public string ChurchName { get; set; }
        public string ChurchDetails { get; set; }
        public string ChurchMsisdn { get; set; }
        public string ChurchAddress { get; set; }
        public string ChurchCounty { get; set; }
        public string AppPassword { get; set; }
        public string AppUser { get; set; }
        public DateTime ChurchDateCreated { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<ChurchMembers> ChurchMembers { get; set; }
        public ICollection<VideoList> VideoLists { get; set; }
    }
}
