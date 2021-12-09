using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Repository
{
    public class GpuRepository : IGpuRepository
    {
        GpuDbContext db;
        public GpuRepository(GpuDbContext db)
        {
            this.db = db;
        }
        public void Create(GraphicCard gpu)
        {
            db.graphiccards.Add(gpu);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var gpuToDelete = Read(id);
            db.graphiccards.Remove(gpuToDelete);
            db.SaveChanges();
        }

        public IQueryable<GraphicCard> GetAll()
        {
           return db.graphiccards;
        }

        public GraphicCard Read(int id)
        {
            return db.graphiccards.FirstOrDefault(t => t.Id == id);
        }

        public void Update(GraphicCard gpu)
        {
            var gpuToUpdate = Read(gpu.Id);
            gpuToUpdate.Name = gpu.Name;
            gpuToUpdate.Serieses = gpu.Serieses;
            gpuToUpdate.Employees = gpu.Employees;
            db.SaveChanges();
        }
    }
}
