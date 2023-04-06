using BuildComp___Database.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildComp___Database.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; }
        

        public DataContext(DbContextOptions options): base(options)
        {}


        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
        }

    }
}