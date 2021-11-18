using LW4Q29_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Data;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public class GraphicCardLogic : IGraphicCardLogic
    {
        IGpuRepository gpuRepo;

        public GraphicCardLogic(IGpuRepository repo)
        {
            this.gpuRepo = repo;
        }
        
        public void ChangeGpuTitle(int id, string newTitle)
        {

        }

        public IList<GraphicCards> GetAllGpus()
        {
            throw new NotImplementedException();
        }

        public GraphicCards GetGpuById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
