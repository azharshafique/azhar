using System;
using System.Collections.Generic;

namespace newsAlert.Models
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }
        public string PostCatagory { get; set; }
        public string PostImage { get; set; }
    }
}
