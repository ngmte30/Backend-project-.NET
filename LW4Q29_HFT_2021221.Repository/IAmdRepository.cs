using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Repository
{
    public interface IAmdRepository
    {
        void Create(Amd car);
        void Delete(int id);
        IQueryable<Amd> GetAll();
        Amd Read(int id);
        void Update(Amd car);
    }
}
