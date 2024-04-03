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
                    Name = "Admin",
                    Surname = "Admin",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(2000, 01, 01),
                    Nationality = "Italian",
                    Languages = "English,Italian",
                    ProfilePicture = "default.png",
                    PasswordHash = "AQAAAAIAAYagAAAAEGCS/ZW/brIXoz5cp3HLH+hWlgQg2gLtVrkkfXw+xSiNpHWS0NCcTD+5X57xfi5Z/w=="
                }
            );

        modelBuilder.Entity<IdentityRole>()
            .HasData(
                new List<IdentityRole> {
                    new() { Name = "Admin", NormalizedName = "ADMIN" },
                    new() { Name = "User", NormalizedName = "USER" }
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

