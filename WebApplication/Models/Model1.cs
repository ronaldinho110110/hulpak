namespace WebApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<LevelType> LevelTypes { get; set; }
        public virtual DbSet<OfficialHoliday> OfficialHolidays { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusType> StatusTypes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserTeam> UserTeams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LevelType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LevelType>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.LevelType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficialHoliday>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RequestType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RequestType>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.RequestType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RoleType>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.RoleType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleType>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.RoleType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StatusType>()
                .HasMany(e => e.Status)
                .WithRequired(e => e.StatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusType>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.StatusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.UserTeams)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserTeams)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
