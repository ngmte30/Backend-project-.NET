using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Repository
{
    public interface IGpuRepository
    {
        void Create(GraphicCards gpu);
        void Delete(int id);
        IQueryable<GraphicCards> GetAll();
        GraphicCards Read(int id);
        void Update(GraphicCards car);
    }
}
