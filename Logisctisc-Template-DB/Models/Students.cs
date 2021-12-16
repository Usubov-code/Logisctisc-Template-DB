using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class Students
    {
         [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }

        public byte Age { get; set; }

        [ForeignKey("Groups")]
        public int GroupsId { get; set; }

        public Groups Groups { get; set; }
    }
}
