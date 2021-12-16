using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logisctisc_Template_DB.Models
{
    public class Teams
    {

        [Key]

        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageTeam { get; set; }

        public string NameTeam { get; set; }

        public string NamePosition { get; set; }

        public string ContentTeam { get; set; }
    }
}
