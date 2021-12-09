using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Repository
{
    public class SeriesRepository : ISeriesRepository
    {
        GpuDbContext db;
        public SeriesRepository(GpuDbContext db)
        {
            this.db = db;
        }
        public void Create(Series series)
        {
            db.Add(series);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var seriesToDelete = Read(id);
            db.serieses.Remove(seriesToDelete);
            db.SaveChanges();
        }

        public IQueryable<Series> GetAll()
        {
            return db.serieses;
        }

        public Series Read(int id)
        {
            return db.serieses.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Series series)
        {
            var sUpdate = Read(series.Id);
            sUpdate.Name = series.Name;
            sUpdate.isMiner = series.isMiner;
            sUpdate.Generations = series.Generations;
            sUpdate.Id = series.Id;
            db.SaveChanges();
        }
    }
}
