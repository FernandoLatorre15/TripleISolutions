using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TripleISolutions.Exam.Web.Models;
using System.Data;

namespace TripleISolutions.Exam.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<CatSongs> CatSongs { get; set; }
    }
}
