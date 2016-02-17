using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MyWebApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        
        // GET: api/values
        [HttpGet]
        public List<User> Get()
        {           
            List<User> user= new List<User>();
            user.Add(new User(){ ID=1, Name="Bora", SurName="Kasmer", Interested = Hobi.Music });
            user.Add(new User(){ ID=2, Name="Engin", SurName="Polat", Interested = Hobi.Sport });
            user.Add(new User(){ ID=3, Name="Mehmet", SurName="Karli", Interested = Hobi.Picture });
            user.Add(new User(){ ID=4, Name="Cihan", SurName="Dokur", Interested = Hobi.Game });
            user.Add(new User(){ ID=5, Name="Vural", SurName="Pekyilmaz", Interested = Hobi.Picture });
            return user;            
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
