namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusType")]
    public partial class StatusType
    {
        public StatusType()
        {
            Status = new HashSet<Status>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public virtual ICollection<Status> Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
