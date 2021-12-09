using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Repository
{
    public interface ISeriesRepository
    {
        void Create(Series car);
        void Delete(int id);
        IQueryable<Series> GetAll();
        Series Read(int id);
        void Update(Series car);
    }
}
