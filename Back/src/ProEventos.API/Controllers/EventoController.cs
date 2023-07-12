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

        private readonly ILogger<EventoController> _logger;

        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[] {

                new Evento (){
                    EventoId = 1,
                    Tema = "Angular 11 e .Net 5",
                    Local = "Belo horizonte",
                    Lote = "1. lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new Evento (){
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "Sao paulo",
                    Lote = "2 Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {

            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {

            return $"Exemplo de Put com id = {id}";
        }


    }

}

