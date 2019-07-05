using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using videojuego.Models;
using videojuego.utils;

namespace videojuego.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private Store store = Store.Instance; 

        //Creamos un constructor
        public ToDoController()
        {
            Console.WriteLine(store.todos.Count);            
        }
        

    }
}