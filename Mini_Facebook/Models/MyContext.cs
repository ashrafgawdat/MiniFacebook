using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Facebook.Models
{
    public class MyContext//:DbContext
    {
        //public DbSet<User> Users { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<Post> Posts { get; set; }
        //public DbSet<Like> Likes { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<Friendship> Friendships { get; set; }

        //public MyContext(DbContextOptions options):base(options)
        //{
                
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Like>()
        //        .HasKey(c => new { c.PostID, c.UserID });

        //    modelBuilder.Entity<Like>()
        //        .HasOne(b => b.User)
        //        .WithMany(a => a.Likes)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    //modelBuilder.Entity<User>()
        //    //    .HasMany(e => e.Users)
        //    //    .WithMany(e=>e.Friends)
        //    //    .Map(m => m.ToTable("Friendship").MapLeftKey("UserID").MapRightKey("FriendID"));

        //    modelBuilder.Entity<Friendship>()
        //        .HasKey(c => new { c.UserID, c.FriendID });

        //    modelBuilder.Entity<Friendship>()
        //        .HasOne(pt => pt.User)
        //        .WithMany(p => p.Users) // <--
        //        .HasForeignKey(pt => pt.UserID)
        //        .OnDelete(DeleteBehavior.Restrict); // see the note at the end

        //    modelBuilder.Entity<Friendship>()
        //        .HasOne(pt => pt.Friend)
        //        .WithMany(t => t.Friends)
        //        .HasForeignKey(pt => pt.FriendID);
        //}

    }
}
