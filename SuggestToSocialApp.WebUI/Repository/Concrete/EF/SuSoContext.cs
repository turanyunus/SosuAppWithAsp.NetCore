using Microsoft.EntityFrameworkCore;
using SuggestToSocialApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Repository.Concrete.EF
{
    public class SuSoContext:DbContext
    {
        public SuSoContext(DbContextOptions<SuSoContext> options)
            :base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
