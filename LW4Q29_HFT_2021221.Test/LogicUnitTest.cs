using LW4Q29_HFT_2021221.Logic;
using LW4Q29_HFT_2021221.Repository;
using LW4Q29_HFT_2021221.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Test
{
    [TestFixture]
    public class LogicUnitTest
    {
        GraphicCardLogic gpuLogic;
        SeriesLogic seriesLogic;
        GenerationLogic genLogic;
        [SetUp]      
        public void Init()
        {
           
            var mockGenRepo = new Mock<IGenerationRepository>();
            var mockGpuRepo = new Mock<IGpuRepository>();
            var mockSerRepo = new Mock<ISeriesRepository>();

            var fakeGen = new List<Generation>()
            {
                new Generation() { Id = 01, Name = "RTX 3070", Price = 500000, LHR = false,MemoryType = "Samsung",SeriesID = 11},
                new Generation() { Id = 02, Name = "RTX 3090", Price = 999000, LHR = false,MemoryType = "Hynix",SeriesID = 11},
                new Generation() { Id = 03, Name = "GTX 1660", Price = 200000, LHR = true,MemoryType = "Micron",SeriesID = 12},
                new Generation() { Id = 04, Name = "Radeon 6900", Price = 400000, LHR = false,MemoryType = "Hynix",SeriesID = 21}
            }.AsQueryable();
            var fakeGpu = new List<GraphicCard>()
            {
                new GraphicCard() {Id = 1, Name = "NVIDIA", Employees = 900},
                new GraphicCard() {Id = 2, Name = "AMD", Employees = 570}
            }.AsQueryable();
            var fakeSeries = new List<Series>()
            {
                new Series() { Id = 11, Name = "RTX", isMiner = true, GraphicCardID =1},
                new Series() { Id = 12, Name = "GTX", isMiner = false, GraphicCardID =1},
                new Series() { Id = 21, Name = "Radeon", isMiner = false, GraphicCardID =2}
            }.AsQueryable();

            mockGenRepo.Setup((t) => t.GetAll()).Returns(fakeGen);
            mockGpuRepo.Setup((t) => t.GetAll()).Returns(fakeGpu);
            mockSerRepo.Setup((t) => t.GetAll()).Returns(fakeSeries);
            genLogic = new GenerationLogic(mockGenRepo.Object, mockGpuRepo.Object,mockSerRepo.Object);
            seriesLogic = new SeriesLogic(mockSerRepo.Object, mockGenRepo.Object,mockGpuRepo.Object);
            gpuLogic = new GraphicCardLogic(mockGpuRepo.Object);

       
        }
        [Test]
        public void TestNoncrud1() 
        {
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("GTX", 12));
            var result = genLogic.CheapestLHRSeries();

            CollectionAssert.AreEquivalent(result, list);
        }
        [Test]
        public void TestNoncrud2()
        {
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("RTX 3070", 1));
            list.Add(new KeyValuePair<string, int>("RTX 3090", 2));
            list.Add(new KeyValuePair<string, int>("GTX 1660", 3));
            list.Add(new KeyValuePair<string, int>("Radeon 6900", 4));
            var result= genLogic.HugeGpuFactory();

            CollectionAssert.AreEquivalent(result, list);
        }
        [Test]
        public void TestNoncrud3()
        {
            var result = genLogic.NvidiaGpus();
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("RTX 3070", 1));
            list.Add(new KeyValuePair<string, int>("RTX 3090", 2));
            list.Add(new KeyValuePair<string, int>("GTX 1660", 3));

            CollectionAssert.AreEquivalent(result, list);
        }
        [Test]
        public void TestNoncrud4()
        {
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("RTX 3070", 1));
            list.Add(new KeyValuePair<string, int>("RTX 3090", 2));
            var result = genLogic.MinerCard();
            CollectionAssert.AreEquivalent(result, list);


        }
        [Test]
        public void TestNoncrud5() 
        {
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("RTX 3070", 1));
            var result = genLogic.NvidiaSamsungRam();
            CollectionAssert.AreEquivalent(result, list);
        }

        [Test]
        public void TestCreate()
        {
            var fakeSeries = new List<Generation>()
            {
                new Generation() {},

            };
            var testGpu = new Generation()
            {
                Id = 01,
                Name = "RTX 3050",
                Price = 200000,
                LHR = true,
                MemoryType = "Samsung",
                SeriesID = 11
            };
            genLogic.Create(testGpu);
            Assert.IsTrue(testGpu.Id > 0);
        }
        [Test]
        public void TestUpdate()
        {
            var fakeSeries = new List<Generation>()
            {
                new Generation() { Id = 01, Name = "RTX 3050", Price = 200000, LHR = true,MemoryType = "Samsung",SeriesID = 11},

            };
            var testGpu = new Generation()
            {
                Id = 01,
                Name = "RTX 3060",
                Price = 200000,
                LHR = true,
                MemoryType = "Samsung",
                SeriesID = 11
            };
            genLogic.Update(testGpu);
            Assert.IsTrue(testGpu.Name =="RTX 3060");
        }
        [Test]
        public void SeriesNameTest()
        {
            string[] sr = new string[]{ "RTX", "GTX", "Radeon" };
            var result = seriesLogic.SeriesName();
            CollectionAssert.AreEquivalent(result, sr);
        
        }
        [Test]
        public void ExpensiveTest()
        {
            string[] sr = new string[] { "RTX 3070", "RTX 3090"};
            var result = genLogic.Expensive();
            CollectionAssert.AreEquivalent(result, sr);

        }
        [Test]
        public void AmdGpusEmployeeTest()
        {
            int[] sr = new int[] {900};
            var result = gpuLogic.AmdGpus();
            CollectionAssert.AreEquivalent(result, sr);
        }

    }
}
