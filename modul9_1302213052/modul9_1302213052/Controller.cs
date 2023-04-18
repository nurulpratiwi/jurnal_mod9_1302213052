using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302213052.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {


        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Name = "Afny Latifa", Nim = "1302210071", Year = 2021, Course = new List<string> { "Basis Data", "KPL", "PBO" } },
            new Mahasiswa { Name = "Herlin Priatna", Nim = "1302213018", Year = 2021, Course = new List<string> { "Basis Data", "KPL", "PBO" } },
            new Mahasiswa { Name = "Muhammad Zulfadly", Nim = "1302210046", Year = 2021, Course = new List<string> { "Basis Data", "KPL", "PBO" } },
            new Mahasiswa { Name = "Nurul Pratiwi", Nim = "1302213052", Year = 2021, Course = new List<string> { "Basis Data", "KPL", "PBO" } },
            new Mahasiswa { Name = "Syahran Syahputra", Nim = "1302210021", Year = 2021, Course = new List<string> { "Basis Data", "KPL", "PBO" } }
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa updateMahasiswa)
        {
            mahasiswaList[id] = updateMahasiswa;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }
    }
}


