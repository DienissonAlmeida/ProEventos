using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        Event[] _events = new Event[] {

                new Event() {
                EventId = 1,
                Tema = "Angular 11",
                Local = "Rio Grande do Sul",
                Lote = "1º Lote",
                QuantityPeoples = 250,
                EventDate = DateTime.Now.AddDays(2).ToString(),
                UrlImage = "foto.png"
                },

                                new Event() {
                EventId = 2,
                Tema = ".NET 5",
                Local = "Rio Grande do Sul",
                Lote = "2º Lote",
                QuantityPeoples = 250,
                EventDate = DateTime.Now.AddDays(2).ToString(),
                UrlImage = "foto2.png"
                },

            };

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _events.FirstOrDefault(x => x.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Example Post";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"Example Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Example Delete {id}";
        }
    }
}
