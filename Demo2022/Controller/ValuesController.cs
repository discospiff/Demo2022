using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo2022.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<Shortcut> Get()
        {
            IList<Shortcut> shortcuts = new List<Shortcut>();

            Shortcut controlV = new Shortcut();
            controlV.FirstName = "Brandan";
            controlV.LastName = "Jones";
            controlV.Software = "Microsoft";
            controlV.KeyboardShortcut = "Control V";
            controlV.WhatDo = "Paste";
            shortcuts.Add(controlV);

            Shortcut controlC = new Shortcut();
            controlC.FirstName = "Betty";
            controlC.LastName = "White";
            controlC.Software = "Microsoft";
            controlC.KeyboardShortcut = "Control C";
            controlC.WhatDo = "Copy";
            shortcuts.Add(controlC);

            return shortcuts;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            value = value + "";
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
