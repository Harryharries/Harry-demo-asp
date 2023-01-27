using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace _7XConnectApi.Models
{
    public class Event
    {
        public long Id { get; set; }
        
        [Required]
        public string EventName { get; set; }
        
        [Required]
        public DateTime EventTime { get; set; }

        [Required]
        public DateTime EventEndTime { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

    }
}
