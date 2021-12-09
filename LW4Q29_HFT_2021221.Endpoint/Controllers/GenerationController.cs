﻿using LW4Q29_HFT_2021221.Logic;
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
    public class GenerationController : ControllerBase
    {
        IGenerationLogic gLogic;
        public GenerationController(IGenerationLogic gLogic)
        {
            this.gLogic = gLogic;
        }
        // GET: /generation
        [HttpGet]
        public IEnumerable<Generation> Get()
        {
            return gLogic.GetAll();
        }

        // GET api/<GenerationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GenerationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GenerationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenerationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
