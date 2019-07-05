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

        [HttpGet]
        public List<Datosvideoj> getTodoVideo()
        {
            return this.store.todos;
        }
        [HttpPost]
        public Datosvideoj PostTodo (Datosvideoj item)
        {
            item.Id=store.todos.Count; //Incrementamos el Id
            this.store.todos.Add(item);            
            return item;
        }


    }
}