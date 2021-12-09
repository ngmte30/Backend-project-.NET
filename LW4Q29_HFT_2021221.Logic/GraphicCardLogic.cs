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

        public void Create(GraphicCard gpu)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GraphicCard> GetAllGpus()
        {
            return gpuRepo.GetAll();
        }

        public GraphicCard GetGpuById(int id)
        {
            throw new NotImplementedException();
        }
        public GraphicCard GetGpuGeneration(int id)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void ReadAll()
        {
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
