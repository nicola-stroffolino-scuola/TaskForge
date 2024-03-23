using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskForge.Models;

namespace TaskForge.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser>(options) {    
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppUser>()
            .Ignore(u => u.EmailConfirmed)
            .Ignore(u => u.PhoneNumber)
            .Ignore(u => u.PhoneNumberConfirmed)
            .Ignore(u => u.TwoFactorEnabled)
            .Ignore(u => u.LockoutEnabled)
            .Ignore(u => u.LockoutEnd)
            .Ignore(u => u.AccessFailedCount)
            .Property(e => e.Id).HasColumnName("UserId");
        modelBuilder.Entity<AppUser>()
            .HasData(
                new AppUser() {
                    Id = "1",
                    Name = "Admin",
                    Surname = "Admin",
                    UserName = "admin.admin",
                    Email = "admin@gmail.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(2005, 09, 17),
                    Nationality = "Italian",
                    Languages = "Italian,English",
                    ProfilePicture = "default.png"
                }
            );

        modelBuilder.Entity<IdentityRole>()
            .HasData(
                new List<object> {
                    new IdentityRole() { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole() { Id = "2", Name = "User", NormalizedName = "USER" }
                }
            );

        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(
                new List<object> {
                    new IdentityUserRole<string>() { UserId = "1", RoleId = "1" },
                    new IdentityUserRole<string>() { UserId = "1", RoleId = "2" }
                }
            );

        modelBuilder.Entity<AppUser>().ToTable("Users");
        modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
    }
}

public class AppUser : IdentityUser {
    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Surname { get; set; }
    
    [Required]
    public required string Gender { get; set; }

    [Required]
    public required DateOnly DateOfBirth { get; set; }

    [Required]
    public required string Nationality { get; set; }
    
    [Required]
    public required string Languages { get; set; }

    [Required]
    public required string ProfilePicture { get; set; }
}

