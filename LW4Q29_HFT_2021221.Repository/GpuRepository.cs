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
        public void Create(GraphicCards gpu)
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

        public IQueryable<GraphicCards> GetAll()
        {
           return db.graphiccards;
        }

        public GraphicCards Read(int id)
        {
            return db.graphiccards.FirstOrDefault(t => t.GpuId == id);
        }

        public void Update(GraphicCards gpu)
        {
            var gpuToUpdate = Read(gpu.GpuId);
            gpuToUpdate.Usability = gpu.Usability;
            db.SaveChanges();
        }
    }
}
