using Church_Web.Db_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Church_Web.Models
{
    public class CreateEventViewModel
    {
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime StartTime { get; set; }

    }

    public class EventViewModel : CreateEventViewModel
    {
        public int EventID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ID { get; set; }
    }

}
