using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.utils;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        //private List<Todoitem> todos = new List<Todoitem>();
        private Store store = Store.Instance;     
        
        //Creamos un constructor
        public ToDoController()
        {
            Console.WriteLine(store.todos.Count);
            
        }
        [HttpGet]
        public List<Todoitem> getTodoItems()
        {
            return this.store.todos;
        }
        [HttpPost]
        public Todoitem PostTodo (Todoitem item)
        {
            item.Id=store.todos.Count;
            this.store.todos.Add(item);
            
            return item;
        }
    }
}