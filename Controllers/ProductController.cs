﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CornerShop.Model.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CornerShop.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _IProductService;

        public ProductController(IProductService prProductService)
        {
            _IProductService = prProductService;
        }

        [HttpGet]
        public Product Get()
        {
            return new Product();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

