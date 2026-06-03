using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HollowDesk.Models
{
    [Table("user_roles")]
    public class UserRole : BaseModel
    {
        [PrimaryKey("user_id", false)]
        public string UserId { get; set; } = string.Empty;

        [Column("role")]
        public string Role { get; set; } = string.Empty;
    }
}
