using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Repository
{
    class AmdRepository : IAmdRepository
    {
        GpuDbContext db;
        public AmdRepository(GpuDbContext db)
        {
            this.db = db;
        }
        public void Create(Amd amd)
        {
            db.amds.Add(amd);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var amdToDelete = Read(id);
            db.amds.Remove(amdToDelete);
            db.SaveChanges();
        }

        public IQueryable<Amd> GetAll()
        {
            return db.amds;
        }

        public Amd Read(int id)
        {
            return db.amds.FirstOrDefault(t => t.amd_cardId == id);
        }

        public void Update(Amd amd)
        {
            var amdToUpdate = Read(amd.amd_cardId);
            amdToUpdate.Brand = amd.Brand;
            amdToUpdate.Generation = amd.Generation;
            db.SaveChanges();
        }
    }
}
