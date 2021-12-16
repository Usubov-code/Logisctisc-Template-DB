using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class Groups
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public int Name { get; set; }

        public List<Students> Students { get; set; }
    }
}
