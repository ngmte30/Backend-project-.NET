using LW4Q29_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public class AmdLogic : IAmdLogic
    {
        IAmdRepository amdRepo;

        public AmdLogic(IAmdRepository repo)
        {
            this.amdRepo = repo;
        }
        public void ChangeAmdTitle(int id, string newTitle)
        {
            throw new NotImplementedException();
        }

        public IList<Amd> GetAllAmd()
        {
            throw new NotImplementedException();
        }

        public Amd GetAmdId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
