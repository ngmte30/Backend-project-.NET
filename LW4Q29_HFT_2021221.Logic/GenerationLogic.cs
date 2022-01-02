using LW4Q29_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LW4Q29_HFT_2021221.Repository;

namespace LW4Q29_HFT_2021221.Logic
{
    public class GenerationLogic : IGenerationLogic
    {
        IGenerationRepository genRepo;

        public GenerationLogic(IGenerationRepository repo)
        {
            this.genRepo = repo;
        }
        public void ChangeGen(int id,string newGen)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Generation> GetAll()
        {
            return genRepo.GetAll();
        }

        public Generation GetId(int id)
        {
            throw new NotImplementedException();
        }
        public Generation GetGeneration(int id)
        {
            throw new NotImplementedException();
        }


        //CRUD METHODS---------------

        public void Create(Generation gen)
        {
            genRepo.Create(gen);
        }

        public void Delete(int id)
        {
            genRepo.Delete(id);
        }

        public Generation Read(int id)
        {
            return genRepo.Read(id);
        }

        public void Update(Generation gen)
        {
            genRepo.Update(gen);
        }

        public object AvgGraphiccardPrice()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Generation> AvgPrice()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<string, int>> CheapestLHR()
        {
            var chLhr = from x in genRepo.GetAll()
                        where x.LHR == true
                        orderby x.Price
                        select new KeyValuePair<string, int>(x.Name, x.Price);
            return chLhr;

        }

        

        
    }
}
