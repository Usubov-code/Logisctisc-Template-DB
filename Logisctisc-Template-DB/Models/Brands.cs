using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class Brands
    {
        [Key]

        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        public List<Models> Models { get; set; }
    }
}
