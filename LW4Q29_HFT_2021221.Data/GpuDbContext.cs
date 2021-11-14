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
        public virtual DbSet<GraphicCards> graphiccards { get; set; }
        public virtual DbSet<Nvidia> nvidias { get; set; }
        public virtual DbSet<Amd> amds { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            var rtx = new GraphicCards(){ GpuId = 1, Usability = "Desginer"};
            var gtx = new GraphicCards(){ GpuId = 2,Usability = "Gamer" };
            var r_series = new GraphicCards(){ GpuId = 4, Usability ="Gamer"};
            var rx_series = new GraphicCards(){ GpuId = 5, Usability = "Desginer" };

            builder.Entity<Nvidia>()
                .HasOne(gpu => gpu.graphic_card)
                .WithMany(nv => nv.Nvidias)
                .HasForeignKey(gpu => gpu.nvidia_cardId);
            builder.Entity<Amd>()
                .HasOne(gpu=>gpu.graphic_card)
                .WithMany(amd => amd.Amds)
                .HasForeignKey(gpu => gpu.amd_cardId);

            builder.Entity<GraphicCards>().HasData(rtx, gtx, r_series, r_series, rx_series);

            var nvidia_list = new List<Nvidia>
            {
                //Deciduous trees
                new Nvidia(){nvidia_cardId = 1,Brand = "Zotac",Generation = 3090,GpuId = rtx.GpuId=1},
                new Nvidia(){nvidia_cardId = 2,Brand = "Asus",Generation = 2080,GpuId = gtx.GpuId=2},
                new Nvidia(){nvidia_cardId = 3,Brand = "MSI",Generation = 1070,GpuId = gtx.GpuId=2},
               
                
            };
            var amd_list = new List<Amd>
            {
                new Amd(){amd_cardId= 4,Brand = "Gainward",Generation = 390 ,GpuId = r_series.GpuId=4},
                new Amd(){amd_cardId = 5,Brand = "Asus",Generation = 6800 ,GpuId = rx_series.GpuId=5},
                new Amd(){amd_cardId = 6,Brand = "Sapphire",Generation = 6900 ,GpuId = rx_series.GpuId=5}
            };
            builder.Entity<Nvidia>().HasData(nvidias);
            builder.Entity<Amd>().HasData(amds);
        }
    }
}
