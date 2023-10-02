﻿using Domain.Common;
using Domain.Entites;
using Domain.Entites.Config;
using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        #region DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRols { get; set; }
        public DbSet<Role> Rols { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        #endregion


        #region Config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<User>().HasData(new User() { Id = 1, FirstName = "Mohammad", LastName = "Zarrabi", Password = SecurityHelper.PasswordToSHA256("1234"), EmailAddress = "mhzsam@gmail.com" ,MobileNumber="09120198177"});
            modelBuilder.Entity<Role>().HasData(new Role() { Id = 1, IsActive = true, RoleName = "SuperAdmin" });
            modelBuilder.Entity<UserRole>().HasData(new UserRole() { Id = 1, RoleId = 1, UserId = 1 });
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionConfiguration());

        }
        #endregion
    }
}
