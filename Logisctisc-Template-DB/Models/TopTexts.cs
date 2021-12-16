using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class TopTexts
    {
         [Key]
        public int Id { get; set; }

        public string title  { get; set; }

        public string Subtitle { get; set; }


    }
}
