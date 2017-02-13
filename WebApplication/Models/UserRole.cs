namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRole")]
    public partial class UserRole
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoleTypeId { get; set; }

        public virtual RoleType RoleType { get; set; }

        public virtual User User { get; set; }
    }
}
