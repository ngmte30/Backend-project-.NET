using LW4Q29_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public class NvidiaLogic : INvidiaLogic
    {
        INvidiaRepository nvidiaRepo;

        public NvidiaLogic(INvidiaRepository repo)
        {
            this.nvidiaRepo = repo;
        }
        public void ChangeNvidiaTitle(int id, string newTitle)
        {
            throw new NotImplementedException();
        }

        public IList<Nvidia> GetAllNvidias()
        {
            throw new NotImplementedException();
        }

        public Nvidia GetNvidiaById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
