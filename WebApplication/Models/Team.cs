namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        public Team()
        {
            Users = new HashSet<User>();
            UserTeams = new HashSet<UserTeam>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string TeamName { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<UserTeam> UserTeams { get; set; }
    }
}
