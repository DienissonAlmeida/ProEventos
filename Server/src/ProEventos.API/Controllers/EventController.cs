using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;
        public EventController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events.ToList();
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _context.Events.Find(id);
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
