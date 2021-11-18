using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Models;

namespace LW4Q29_HFT_2021221.Logic
{
    public interface IAmdLogic
    {
        Amd GetAmdId(int id);
        void ChangeAmdTitle(int id, string newTitle);
        IList<Amd> GetAllAmd();
    }
}
