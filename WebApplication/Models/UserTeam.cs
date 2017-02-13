namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTeam")]
    public partial class UserTeam
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

        public virtual User User { get; set; }
    }
}
