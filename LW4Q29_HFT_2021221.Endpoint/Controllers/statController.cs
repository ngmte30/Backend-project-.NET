using LW4Q29_HFT_2021221.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LW4Q29_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class statController : ControllerBase
    {
        
        IGenerationLogic gLogic;
        public statController(IGenerationLogic gLogic)
        {
            this.gLogic = gLogic;
        }
      

        // GET api/<statController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<statController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<statController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<statController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet]
        public List<IEnumerable<KeyValuePair<string, int>>> NvidiaGpus()
        {
            var list = new List<IEnumerable<KeyValuePair<string, int>>>();
            list.Add(gLogic.NvidiaGpus());
            return list;
        }
        [HttpGet]
        public List<IEnumerable<KeyValuePair<string, int>>> NvidiaSamsung()
        {
            var list = new List<IEnumerable<KeyValuePair<string, int>>>();
            list.Add(gLogic.NvidiaSamsungRam());
            return list;
        }
        [HttpGet]
        public void HugeFactory()
        {
            gLogic.HugeGpuFactory();
        }
        [HttpGet]
        public void MinerCard()
        {
            gLogic.MinerCard();
        }
        [HttpGet]
        public void CheapLhrSer()
        {
            gLogic.CheapestLHRSeries();
        }
    }
}
