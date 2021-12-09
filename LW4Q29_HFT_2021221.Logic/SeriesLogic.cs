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
        public void ChangeNvidiaTitle(int id, string newTitle)
        {
            throw new NotImplementedException();
        }

        public void Create(Series amd)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Series> GetAll()
        {
            throw new NotImplementedException();
        }

        public Series GetNvidiaById(int id)
        {
            throw new NotImplementedException();
        }
        public Series GetNvidiaGeneration(int id)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

}
