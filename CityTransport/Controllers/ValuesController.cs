﻿using CityTransport.Common;
using CityTransport.Interface.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace CityTransport.Web.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IAdminService m_AdminService;

        public ValuesController(IAdminService adminService)
        {
            m_AdminService = adminService;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { AppSettings.ConnectionString, m_AdminService.TestMethod() };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
