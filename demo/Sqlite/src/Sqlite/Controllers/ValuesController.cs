using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sqlite.Model;
using Microsoft.AspNetCore.Hosting.Internal;

namespace Sqlite.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private DatabaseContext _db;
        //public ValuesController(DatabaseContext databaseContext)
        //{
        //    _db = databaseContext;
        //}


        // GET api/values
        [HttpGet]
        public object Get()
        {
            //return _db.Tests.ToList();
            using (DatabaseContext db = new DatabaseContext())
            {
                return db.Tests.ToList();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(string value)
        {
            
            //using (DatabaseContext db = new DatabaseContext())
            //{
            //    db.Tests.Add(t);
            //    db.SaveChanges();
            //}
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
