namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public User()
        {
            Requests = new HashSet<Request>();
            UserRoles = new HashSet<UserRole>();
            UserTeams = new HashSet<UserTeam>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Email { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }

        [Required]
        [StringLength(128)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartWork { get; set; }

        public int StatusTypeId { get; set; }

        public int LevelTypeId { get; set; }

        public int RoleTypeId { get; set; }

        public int TeamId { get; set; }

        public virtual LevelType LevelType { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual RoleType RoleType { get; set; }

        public virtual StatusType StatusType { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<UserTeam> UserTeams { get; set; }
    }
}
