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
            db.Add(generation);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var generationToDelete = Read(id);
            db.Remove(generationToDelete);
            db.SaveChanges();
        }

        public IQueryable<Generation> GetAll()
        {
            return db.generations;
        }

        public Generation Read(int id)
        {
            return db.generations.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Generation newGen)
        {
            var genToUpdate = Read(newGen.Id);
            genToUpdate.Name = newGen.Name;
            genToUpdate.Price = newGen.Price;
            genToUpdate.MemoryType = newGen.MemoryType;
            genToUpdate.LHR = newGen.LHR;
            genToUpdate.SeriesID = newGen.SeriesID;
            
            db.SaveChanges();
        }
    }
}
