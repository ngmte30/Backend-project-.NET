using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Data
{
    public class GpuDbContext:DbContext
    {
        public virtual DbSet<GraphicCard> GraphicCards { get; set; }
        public virtual DbSet<Series> Serieses { get; set; }
        public virtual DbSet<Generation> Generations { get; set; }
        public GpuDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            var amd = new GraphicCard() { Id = 1, Name = "AMD", Employees = 792 };
            var nvidia = new GraphicCard() { Id = 2, Name = "Nvidia", Employees = 828 };

            builder
                .Entity<Series>()
                .HasOne(sr => sr.GraphicCards)
                .WithMany(srt => srt.Serieses )
                .HasForeignKey(sr => sr.GraphicCardID);

            builder
                .Entity<Generation>()
                .HasOne(st => st.Series)
                .WithMany(sh => sh.Generations)
                .HasForeignKey(st => st.SeriesID);



            var Serieses = new List<Series>()
            {

               new Series{Id=11,isMiner=true,Name="Rtx",GraphicCardID=1},
               new Series{Id=12,isMiner=false,Name="Gtx",GraphicCardID=1},
               new Series{Id=21,isMiner=false,Name="R",GraphicCardID =2},
               new Series{Id=22,isMiner=true,Name="RX",GraphicCardID =2},
                
            };
            var Generations = new List<Generation>
            {
                new Generation{Id = 01,Name="RTX 3090",LHR = false,Price = 990000,MemoryType="Samsung",SeriesID=11},
                new Generation{Id = 02,Name="RTX 3080",LHR = true,Price = 650000,MemoryType="Hynix",SeriesID=11},
                new Generation{Id = 03,Name="RTX 1660",LHR = false,Price = 250000,MemoryType="Samsung",SeriesID=11},
                new Generation{Id = 04,Name="GTX 1070",LHR = false,Price = 150000,MemoryType="Samsung",SeriesID=12},
                new Generation{Id = 05,Name="Radeon 390",LHR = false,Price = 230000,MemoryType="Hynix",SeriesID=21},
                new Generation{Id = 06,Name="RX 6900",LHR = false,Price = 990000,MemoryType="Samsung",SeriesID=22}
            };
            builder.Entity<GraphicCard>().HasData(amd,nvidia);
            builder.Entity<Series>().HasData(Serieses);
            builder.Entity<Generation>().HasData(Generations);
        }
    }
}
