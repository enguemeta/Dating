using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatingApp.Data
{
//     public partial class WorldWideContext : DbContext
//     {
//         public WorldWideContext()
//         {
//         }

//         public WorldWideContext(DbContextOptions<WorldWideContext> options)
//             : base(options)
//         {
//         }

//         public virtual DbSet<Blog> Blog { get; set; }
//         public virtual DbSet<Post> Post { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("Server=EMMANUEL-NF-PC\\SQLEXPRESS;Database=Blogging;Integrated Security=true;");
//             }
//         }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<Blog>(entity =>
//             {
//                 entity.Property(e => e.Url).IsRequired();
//             });

//             modelBuilder.Entity<Post>(entity =>
//             {
//                 entity.HasOne(d => d.Blog)
//                     .WithMany(p => p.Post)
//                     .HasForeignKey(d => d.BlogId);
//             });
//         }
//     }
}
