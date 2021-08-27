using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Church_Web.Db_Model
{
    public class VideoList
    {
        [Key]
        public int VideoListID { get; set; }
        public string VID { get; set; }
        public DateTime STRMDATE { get; set; }
        public string STRMURL { get; set; }
        public string EmbedHtml { get; set; }
        public DateTime Creationtime { get; set; }
        public string Description { get; set; }
        public string Churchthumbnail { get; set; }
        public string Alerts { get; set; }
        public string VidStatus { get; set; }
        public string Lblply { get; set; }
        public string ChurchPic { get; set; }

        [ForeignKey("Church")]
        public int ChurchId { get; set; }
        public Church Church { get; set; }
       


    }
}
