using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreWebAPI
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlite("Data Source=blogging.db");
            optionsBuilder.UseSqlServer(@"Server=CPBC-WS007\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;");
        }
    }
}