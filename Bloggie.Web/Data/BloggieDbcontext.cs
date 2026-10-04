using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class BloggieDbcontext : DbContext
    {
        public BloggieDbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<Tag> tags { get; set; }
    }
}
