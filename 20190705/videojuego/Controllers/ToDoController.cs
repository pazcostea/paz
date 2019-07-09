using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using videojuego.Models;
using videojuego.utils;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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

        //Método para obtener la lista de videojuegos que se han introducido
        [HttpGet]
        public List<Datosvideoj> getTodoVideo()
        {
            List<Datosvideoj> d = new List<Datosvideoj>();
            foreach (string f in Directory.GetFiles("C:/tests/video"))
            {
                d.Add(Datosvideoj.Load(f));
            }
            return d;
            //Datosvideoj.Load();
            //return this.store.todos;
        }
        //Método para introducir videojuegos
        [HttpPost]
        public Datosvideoj PostTodo (Datosvideoj item)
        {
            item.Id=store.todos.Count; //Incrementamos el Id
            Datosvideoj.Save(item);
            this.store.todos.Add(item);            
            return item;
        }       

        //Método para obtener la información de un videojuego por id
        [HttpGet("{Id}")]
        public Datosvideoj getTodoItems(long Id)
        {
            return this.store.todos.Find(todo => todo.Id == Id);            
        }
        //Método para buscar en la lista de videojuegos por una cadena de texto
         [HttpGet("buscar/{Cadena}")]
        public List<Datosvideoj> buscar(string Cadena)
        {            
            return this.store.todos.FindAll(Datosvideoj => 
            {
                int anyo = Datosvideoj.anyolanzamiento;
                string cadAnnyo = anyo.ToString();
                //|| Datosvideoj.anyolanzamiento == anyo
               return Datosvideoj.companyia.Contains(Cadena) || Datosvideoj.Titulo.Contains(Cadena) || cadAnnyo.Contains(Cadena);
            });
        }
        //PUT /api/videojuegos/[id], le paso todas las propiedades que tiene el objeto para modificar la información de un Id
        //[HttpPut("{Id}")]

        
        //DELETE /api/videojuego/[id] --> Borra
        [HttpDelete("{Id}")]
        public void eliminar(int Id)
        {
            this.store.todos.RemoveAt(Id);
        }
    }
}