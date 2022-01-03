using LW4Q29_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public class SeriesLogic : ISeriesLogic
    {
        ISeriesRepository serRepo;
        IGenerationRepository genRepo;
        IGpuRepository gpuRepo;
        public SeriesLogic(ISeriesRepository repo,IGenerationRepository genRep,IGpuRepository gpuRep)
        {
            this.serRepo = repo;
            this.genRepo = genRep;
            this.gpuRepo = gpuRep;
        }
        public void Create(Series ser)
        {
            serRepo.Create(ser);
        }
        public void Delete(int id)
        {
            serRepo.Delete(id);
        }
        public IQueryable<Series> GetAll()
        {
           return serRepo.GetAll();
        }
        public Series Read(int id)
        {
            return serRepo.Read(id);
        }
        public void Update(Series ser)
        {
            serRepo.Update(ser);
        }


        //NON CRUD 
        public IEnumerable<string> SeriesName()
        {

            var sNames = from series in serRepo.GetAll().ToList()
                        select series.Name;

            return sNames;
        }
    }
}
