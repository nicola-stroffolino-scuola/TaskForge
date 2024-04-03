using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskForge.Models;

namespace TaskForge.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser>(options) { 
    public DbSet<Service> Services { get; set; }  
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
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Gender { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string? Nationality { get; set; }
    public string? Languages { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Bio { get; set; }

    public virtual ICollection<Service> Services { get; set; } = [];
    public virtual ICollection<Order> Orders { get; set; } = [];
}

public class Service {
    public int ServiceId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? EstimatedTime { get; set; }
    public string? Images { get; set; }

    public string? ProviderId { get; set; }
    public AppUser? Provider { get; set; }
    public virtual ICollection<Order> Orders { get; set; } = [];
}

public class Order {
    public int OrderId { get; set; }
    public DateTime Timestamp { get; set; }

    public AppUser? Client { get; set; }
    public string? ClientId { get; set; }
    public Service? Service { get; set; }
    public int ServiceId { get; set; }
}

