using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Repository
{
    public class GenerationRepository : IGenerationRepository
    {
        GpuDbContext db;
        public GenerationRepository(GpuDbContext db)
        {
            this.db = db;
        }
        
        public void Create(Generation generation)
        {
            db.nvidias.Add(generation);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var nvidiaToDelete = Read(id);
            db.nvidias.Remove(nvidiaToDelete);
            db.SaveChanges();
        }

        public IQueryable<Generation> GetAll()
        {
            return db.;
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
