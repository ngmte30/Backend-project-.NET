using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Repository
{
    class NvidiaRepository : INvidiaRepository
    {
        GpuDbContext db;
        public NvidiaRepository(GpuDbContext db)
        {
            this.db = db;
        }
        
        public void Create(Nvidia nvidia)
        {
            db.nvidias.Add(nvidia);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var nvidiaToDelete = Read(id);
            db.nvidias.Remove(nvidiaToDelete);
            db.SaveChanges();
        }

        public IQueryable<Nvidia> GetAll()
        {
            return db.nvidias;
        }

        public Nvidia Read(int id)
        {
            return db.nvidias.FirstOrDefault(t => t.nvidia_cardId == id);
        }

        public void Update(Nvidia nvidia)
        {
            var nvidiaToUpdate = Read(nvidia.nvidia_cardId);
            nvidiaToUpdate.Brand = nvidia.Brand;
            nvidiaToUpdate.Generation = nvidia.Generation;
            db.SaveChanges();
        }
    }
}
