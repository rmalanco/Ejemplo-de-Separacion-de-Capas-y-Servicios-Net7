using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Models.Entities
{
    public class Roles
    {
        [Key]
        public int IdRole { get; set; }
        public string Name { get; set; }
    }
}
