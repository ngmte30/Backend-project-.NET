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
        public void ChangeGen(int id, string newTitle)
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

        public void Read(int id)
        {
            genRepo.Read(id);
        }

        public void Update(Generation gen)
        {
            genRepo.Update(gen);
        }

        public object AvgGraphiccardPrice()
        {
            throw new NotImplementedException();
        }

        //public object AvgGraphiccardPrice()
        //{
        //    return from x in genRepo.GetAll()
        //           group x by xAmds into h
        //           select new
        //           {
        //               GpuAmd = h.Key,
        //               GpuAvgPrice = h.Average(z => z.Price)
        //           };
        //}
        //public IEnumerable<KeyValuePair<string, double>> BrandAvgPrice()
        //{
        //    return from x in amdRepo.GetAll()
        //           group x by x.aminto h
        //           select new KeyValuePair<string, double>
        //           (h.Key.,h.Average(t => t.Price));
        //    return null;

        //public IEnumerable<Amd> DesignerCard()
        //{
        //    return null;
        //    //return from x in amdRepo.GetAll()
        //    //       where x.Usability == "Designer"
        //    //       select new
        //    //       {


        //    //       };

        //}
    }
}
