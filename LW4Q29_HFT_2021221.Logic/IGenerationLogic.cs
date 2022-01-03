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


        //---NON CRUD 2
        IEnumerable<Generation> AvgPrice();
        IEnumerable<KeyValuePair<string, int>> CheapestLHR();
        IEnumerable<KeyValuePair<string, int>> HugeGpuFactory();
        IEnumerable<KeyValuePair<string, int>> NvidiaGpus();
        IEnumerable<KeyValuePair<string, int>> MinerCard();
        IEnumerable<KeyValuePair<string, int>> NvidiaSamsungRam();





    }
}
