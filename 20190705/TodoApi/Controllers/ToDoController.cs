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
            item.Id=store.todos.Count; //Incrementamos el Id
            this.store.todos.Add(item);            
            return item;
        }
        [HttpGet("{Id}")]
        public Todoitem getTodoItems(long Id)
        {
            //return this.store.todos.Find(todo => todo.Id == Id);
            //find es una funcion que recibo la información que hay almacenada en ToDO
            //busca dentro del parámetro Id lo que coincida con el Id introducido por parámetro
            return this.store.todos.Find(todo => {
                System.Console.WriteLine("Todo: " + todo.Id);
                return todo.Id == Id;
            });
        }
        //Buscar una cadena de texto
        [HttpGet("buscar/{Cadena}")]
        public List<Todoitem> buscar(string Cadena)
        {
            return this.store.todos.FindAll(Todoitem => Todoitem.Name.Contains(Cadena));
            
        }
        //Mostrar los que esten completos
        [HttpGet("done")]
        public List<Todoitem> getTodoItems(bool isComplete)
        {          
            return this.store.todos.FindAll(Todoitem => Todoitem.IsComplete == true);           
        }
        [HttpPatch("done/{Id}")]
         public Todoitem marcaCompletado(int Id)
        {
            //Creamos una variable para almacenar la posición del ID
            int indice=this.store.todos.FindIndex(Todoitem => Todoitem.Id == Id);
            //Vamos a la posición para cambiarle el estado
            this.store.todos[indice].IsComplete=true;
            return this.store.todos[indice];            
        }
        //Método para eliminar un ID
        [HttpDelete("{Id}")]
        public void eliminar(int Id)
        {
            this.store.todos.RemoveAt(Id);
        }


    }

}