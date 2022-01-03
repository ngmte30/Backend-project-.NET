using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Data;
using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public interface IGraphicCardLogic
    {
        IQueryable<GraphicCard> GetAllGpus();
        void Create(GraphicCard gpu);
        void Delete(int id);
        GraphicCard Read(int id);
        void Update(GraphicCard gpu);
        void ReadAll();

        //--NON CRUD
        IEnumerable<GraphicCard> AmdCards();
        IEnumerable<GraphicCard> NvidiaCards();
       
        


    }
}
