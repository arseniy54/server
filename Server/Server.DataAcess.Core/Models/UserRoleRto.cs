using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.DataAcess.Core.Models
{
   [Table("User")]
    class UserRoleRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}
