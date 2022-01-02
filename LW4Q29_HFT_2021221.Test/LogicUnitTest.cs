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
            var mockGpuReo = new Mock<IGpuRepository>();
            var mockSerRepo = new Mock<ISeriesRepository>();

            var fakeGen = new List<Generation>()
            {
                new Generation() { Id = 01, Name = "RTX 3070", Price = 500000, LHR = false,MemoryType = "Samsung",SeriesID = 11}
            }.AsQueryable();
            var fakeGpu = new List<GraphicCard>()
            {
                new GraphicCard() {Id = 11, Name = "NVIDIA", Employees = 900}
            }.AsQueryable();
            var fakeSeries = new List<Series>()
            {
                new Series() { Id = 11, Name = "RTX", isMiner = true, GraphicCardID =1}
            }.AsQueryable();

            mockGenRepo.Setup((t) => t.GetAll()).Returns(fakeGen);
            mockGpuReo.Setup((t) => t.GetAll()).Returns(fakeGpu);
            mockSerRepo.Setup((t) => t.GetAll()).Returns(fakeSeries);
            genLogic = new GenerationLogic(mockGenRepo.Object);

        }
        [Test]
        public void TestMethod1a() 
        {
            var exp = new List<int>();
            Assert.That(genLogic.CheapestLHR(), Is.EqualTo(exp));
        }
        [TestCase]
        public void TestMethod2()
        {

        }
        [TestCase]
        public void TestMethod3()
        {

        }
        [TestCase]
        public void TestMethod4()
        {

        }
        [TestCase]
        public void TestMethod5() 
        {

        }
       
    }
}
