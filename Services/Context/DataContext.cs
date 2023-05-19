using BuildComp_Database.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildComp_Database.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; }
        public DbSet<WishlistItemModel> WishlistItemInfo { get; set; }
        public DbSet<CPUModel> CpuInfo { get; set; }
        public DbSet<GPUModel> GpuInfo {get; set;}
        public DbSet<MotherboardModel> MotherboardInfo { get; set; }
        public DbSet<CaseModel> CaseInfo {get; set; }
        public DbSet<RamModel> RamInfo {get; set;}
        public DbSet<HeatsinkModel> HeatsinkInfo {get; set;}
        public DbSet<PsModel> PsInfo {get; set; }
        public DbSet<HardDriveModel> HardDriveInfo {get; set; }
        public DataContext(DbContextOptions options): base(options)
        {}


        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
        }

    }
}