using Demo2022.Model;
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
            IList<MyPlantDiary.Specimen> allSpecimens = SpecimenRoster.allSpecimens;

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
        public Shortcut Get(int id)
        {
            IList<MyPlantDiary.Specimen> allSpecimens = SpecimenRoster.allSpecimens;

            Shortcut controlC = new Shortcut();
            controlC.FirstName = "Betty";
            controlC.LastName = "White";
            controlC.Software = "Microsoft";
            controlC.KeyboardShortcut = "Control C";
            controlC.WhatDo = "Copy";
            
            return controlC;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Shortcut value)
        {
            IList<MyPlantDiary.Specimen> allSpecimens = SpecimenRoster.allSpecimens;

            Console.WriteLine(value);
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
