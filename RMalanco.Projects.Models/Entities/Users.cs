using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Models.Entities
{
    public class Users
    {
        [Key]
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool IsDeleted { get; set; }

        [NotMapped]
        public bool IsLoggedIn { get; set; }
        
        // UserRoles
        [ForeignKey("IdUser")]
        public UsersRoles? UsersRoles { get; set; }

        // UserDetail
        [ForeignKey("IdUser")]
        public UsersDetails? UsersDetails { get; set; }
    }
}
