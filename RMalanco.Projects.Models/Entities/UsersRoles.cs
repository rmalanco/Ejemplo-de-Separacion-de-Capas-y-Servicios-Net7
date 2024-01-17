using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Models.Entities
{
    public class UsersRoles
    {
        [Key]        
        public int IdRole { get; set; }
        // Role
        [ForeignKey("IdRole")]
        public Roles? Roles { get; set; }
        public int IdUser { get; set; }
        // User
        [ForeignKey("IdUser")]
        public Users? Users { get; set; }
    }
}
