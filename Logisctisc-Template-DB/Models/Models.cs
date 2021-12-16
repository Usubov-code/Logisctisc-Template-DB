using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class Models
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Brands")]
        public int BrandId { get; set; }

        public Brands Brands { get; set; }
    }
}
