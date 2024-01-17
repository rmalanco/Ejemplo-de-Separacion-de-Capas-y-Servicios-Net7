using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Models.Entities
{
    public class UsersDetails
    {
        [Key]
        public int IdUserDetail { get; set; }
        // UserDetail
        [ForeignKey("IdUserDetail")]
        public UserDetails UserDetails { get; set; }
        public int IdUser { get; set; }
        // User
        [ForeignKey("IdUser")]
        public Users Users { get; set; }
    }
}
