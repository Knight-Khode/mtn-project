using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Church_Web.Db_Model
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartTime { get; set; }


        [ForeignKey("Church")]
        public int ChurchID { get; set; }
        public Church Church { get; set; }
    }
}
