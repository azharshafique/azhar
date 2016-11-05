using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace newsAlert.Models
{
    public partial class Videopost
    {
        public int VideoId { get; set; }
        [Required]
        public string VideoDiscription { get; set; }
        [Required]
        public string VideoEmbed { get; set; }
        [Required]
        public string VideoCategory { get; set; }
        [Required]
        public string VideoName { get; set; }
    }
}
