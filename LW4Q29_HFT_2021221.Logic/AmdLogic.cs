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
        public Amd GetAmdGeneration(int id)
        {
            throw new NotImplementedException();
        }


        //CRUD METHODS---------------

        public void Create(Amd amd)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public object AvgGraphiccardPrice()
        {
            return from x in amdRepo.GetAll()
                   group x by x.graphic_card.Amds into h
                   select new
                   {
                       GpuAmd = h.Key,
                       GpuAvgPrice = h.Average(z => z.Price)
                   };
        }
        public IEnumerable<KeyValuePair<string, double>> BrandAvgPrice()
        {
            //return from x in amdRepo.GetAll()
            //       group x by x.Amds into h
            //       select new KeyValuePair<string, double>
            //       (h.Average(t => t.Price));
            return null;
        }
        public IEnumerable<Amd> DesignerCard()
        {
            return null;
            //return from x in amdRepo.GetAll()
            //       where x.Usability == "Designer"
            //       select new
            //       {
                       

            //       };
                 
        }
    }
}
