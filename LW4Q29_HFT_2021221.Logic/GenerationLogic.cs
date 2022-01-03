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
        IGpuRepository gpuRepo;
        ISeriesRepository serRepo;

        public GenerationLogic(IGenerationRepository repo,IGpuRepository grepo,ISeriesRepository srepo)
        {
            this.genRepo = repo;
            this.gpuRepo = grepo;
            this.serRepo = srepo;

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


        //----NON CRUD

        public IEnumerable<KeyValuePair<string, int>> CheapestLHRSeries()
        {
            var q1 = from gpu in gpuRepo.GetAll().ToList()
                     join ser in serRepo.GetAll().ToList() on gpu.Id equals ser.GraphicCardID
                     join gen in genRepo.GetAll().ToList() on ser.Id equals gen.SeriesID
                     where gen.LHR==true
                     orderby gen.Price
                     select new KeyValuePair<string, int>(ser.Name, ser.Id);

            return q1;

        }

        public IEnumerable<KeyValuePair<string, int>> HugeGpuFactory()
        {
            var q1 = from gpu in gpuRepo.GetAll().ToList()
                     join ser in serRepo.GetAll().ToList() on gpu.Id equals ser.GraphicCardID
                     join gen in genRepo.GetAll().ToList() on ser.Id equals gen.SeriesID
                     where gpu.Employees > 500
                     select new KeyValuePair<string, int> (gen.Name,gen.Id);

            return q1;
        }
        public IEnumerable<KeyValuePair<string, int>> NvidiaGpus()
        {
            var q1 = from gpu in gpuRepo.GetAll().ToList()
                     join ser in serRepo.GetAll().ToList() on gpu.Id equals ser.GraphicCardID
                     join gen in genRepo.GetAll().ToList() on ser.Id equals gen.SeriesID
                     where gpu.Name == "NVIDIA"
                     select new KeyValuePair<string, int>(gen.Name, gen.Id);


            return q1;
        }
        public IEnumerable<KeyValuePair<string, int>> MinerCard()
        {
            var q1 = from gpu in gpuRepo.GetAll().ToList()
                     join ser in serRepo.GetAll().ToList() on gpu.Id equals ser.GraphicCardID
                     join gen in genRepo.GetAll().ToList() on ser.Id equals gen.SeriesID
                     where ser.isMiner == true
                     select new KeyValuePair<string, int>(gen.Name, gen.Id);

            return q1;
        }

        public IEnumerable<KeyValuePair<string, int>> NvidiaSamsungRam()
        {
            var q1 = from gpu in gpuRepo.GetAll().ToList()
                     join ser in serRepo.GetAll().ToList() on gpu.Id equals ser.GraphicCardID
                     join gen in genRepo.GetAll().ToList() on ser.Id equals gen.SeriesID
                     where gen.MemoryType == "Samsung"                   
                     where gpu.Name=="NVIDIA"
                     select new KeyValuePair<string, int>(gen.Name, gen.Id);

            return q1;
        }

        public IEnumerable<string> Expensive()
        {
            var q1 = from gen in genRepo.GetAll().ToList()                  
                     where gen.Price > 400000
                     select gen.Name;

            return q1;
        }


    }
}
