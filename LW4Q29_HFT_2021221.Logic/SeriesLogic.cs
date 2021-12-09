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

        public SeriesLogic(ISeriesRepository repo)
        {
            this.serRepo = repo;
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

        public Series GetNvidiaById(int id)
        {
            throw new NotImplementedException();
        }
        public Series GetNvidiaGeneration(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> MinerCounter()
        {
            return from Series x in serRepo.GetAll()
                   where x.isMiner == true
                   select x;
        }
        public Series Read(int id)
        {
            return serRepo.Read(id);
        }

        public void Update(Series ser)
        {
            serRepo.Update(ser);
        }
    }

}
