using Church_Web.Db_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Church_Web.Models
{
    public class ChurchMainPageViewModel
    {
        public IList<Event> Events { get; set; }
        public IList<Church> Churches { get; set; }
    }
}
