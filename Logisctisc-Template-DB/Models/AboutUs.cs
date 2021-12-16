using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class AboutUs
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Checktext { get; set; }
        public string Checktext2 { get; set; }
        public string Checktext3 { get; set; }

        public int Image { get; set; }

    }
}
