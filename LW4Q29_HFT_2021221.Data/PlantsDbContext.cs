using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Data
{
    class PlantsDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tree>()
                .HasOne(pl => pl.plant)
                .WithMany(tr => tr.Trees)
                .HasForeignKey(pl => pl.PlantId);
        }
    }
}
