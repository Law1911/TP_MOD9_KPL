using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TP_MOD9_KPL_1302210106.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Stevent Rangga Ramaditya","1302210106"),
            new Mahasiswa ("Muhammad Risjad Shidqi Febian","1302213045"),
            new Mahasiswa ("Zhafran Hafizh Izdihar Riyadi","1302210036"),
            new Mahasiswa ("Gifari Juliandri","1302210087" ),
            new Mahasiswa ("Surya Aulia","1302210084"),
            new Mahasiswa ("Ashar Syahbudi Saleh","1302210070")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= ListMahasiswa.Count)
            {
                NotFound();
            }
            return ListMahasiswa[id];
        }


        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            ListMahasiswa.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= ListMahasiswa.Count)
            {
                NotFound();
            }
            ListMahasiswa.RemoveAt(id);
        }


    }
}
