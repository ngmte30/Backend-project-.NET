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
        void ChangeGen(int id,string newGen);
        IEnumerable<Generation> GetAll();

        object AvgGraphiccardPrice();

        void Create(Generation amd);
        void Delete(int id);
        Generation Read(int id);
        void Update(Generation gen);

        IEnumerable<Generation> AvgPrice();
        IEnumerable<Generation> CheapestLHR();
        IEnumerable<Generation> SamsungMemory();
        IEnumerable<Generation> HynixAndLhr();
        IEnumerable<Generation> CheapestSamsungRam();


       
    }
}
