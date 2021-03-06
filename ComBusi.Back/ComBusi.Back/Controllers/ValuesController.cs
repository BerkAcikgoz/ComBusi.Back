﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComBusi.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComBusi.Back.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private ComBusiContext context;
    public ValuesController(ComBusiContext context)
    {
      this.context = context;
        
    }



    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      
      return new string[] { "test", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      
      var a =  context.Branches.FirstOrDefault();


       return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
