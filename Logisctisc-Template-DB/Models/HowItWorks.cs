using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class HowItWorks
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Number { get; set; }

        public string Content { get; set; }

        public string WorkCheck { get; set; }
        public string WorkCheck2 { get; set; }
        public string WorkCheck3 { get; set; }

    }
}
