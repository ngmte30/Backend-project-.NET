using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Logic
{
    public interface IGenerationLogic
    {
        Generation GetId(int id);
        void ChangeGen(int id, string newTitle);
        IEnumerable<Generation> GetAll();

        object AvgGraphiccardPrice();

        void Create(Generation amd);
        void Delete(int id);
        void Read();
        void Update();
       
    }
}
