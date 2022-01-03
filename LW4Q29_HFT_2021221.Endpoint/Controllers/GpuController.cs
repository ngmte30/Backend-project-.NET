using LW4Q29_HFT_2021221.Logic;
using LW4Q29_HFT_2021221.Models;
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
    public class GpuController : ControllerBase
    {
        IGraphicCardLogic gLogic;
        public GpuController(IGraphicCardLogic gLogic)
        {
            this.gLogic = gLogic;
        }
        // GET:/gpu
        [HttpGet]
        public IEnumerable<GraphicCard> Get()
        {
            return gLogic.GetAllGpus();
        }
        // GET api/<AmdController>/5
        [HttpGet("{id}")]
        public GraphicCard Get(int id)
        {
            return gLogic.Read(id);
        }

        // POST api/<AmdController>
        [HttpPost]
        public void Post([FromBody] GraphicCard value)
        {
            gLogic.Create(value);
        }

        // PUT api/<AmdController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GraphicCard value)
        {
            gLogic.Update(value);
        }

        // DELETE api/<AmdController>/5
        [HttpDelete("{id}")]
        public void Delete(GraphicCard gpu)
        {
            gLogic.Update(gpu);

        }
      
        
        
    }
}
