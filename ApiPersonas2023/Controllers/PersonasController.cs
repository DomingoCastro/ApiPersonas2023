using ApiPersonas2023.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        //CREAMOS UNA COLECCION DE PERSONAS PARA DEVOLVER DATOS EN NUESTRA APP
        List<Persona> personas;

        public PersonasController() 
        { 
            //CREAMOS UNAS CUANTAS PERSONAS PARA TENER DATOS EN EL SERVICIO
            this.personas= new List<Persona>()
            {
                new Persona { IdPersona = 1, Nombre = "Carlos", Edad = 20 },
                new Persona { IdPersona = 2, Nombre = "Adri", Edad = 28 },
                new Persona { IdPersona = 3, Nombre = "Jose", Edad = 22 },
                new Persona { IdPersona = 4, Nombre = "Fran", Edad = 22 },
                new Persona { IdPersona = 5, Nombre = "Antonio", Edad = 22 },
                new Persona { IdPersona = 6, Nombre = "Domi", Edad = 24 },
                new Persona { IdPersona = 7, Nombre = "Khatrix", Edad = 100 }
            };
        }

        //LOS METODOS GET DE UN SERVICIO API SIEMPRE TENDAN DECORACIO [HTTPGET]
        [HttpGet]
        public ActionResult <List<Persona>> GetPersonas()
        {
            return this.personas;
        }

        //EL METODO GET(ID) DEBE IR DECORADO CON [HTTPGET("{ID}")]
        [HttpGet("{id}")]
        
        public ActionResult<Persona> FindPersona (int id)
        {

            //VOY A  UTILIZAR UNA EXPRESION PARA BUSCAR UNA PERSONA

            Persona persona = this.personas.FirstOrDefault(x => x.IdPersona == id);
            return persona;
        }
    }
}
