using BookStoreWeb.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStoreWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
