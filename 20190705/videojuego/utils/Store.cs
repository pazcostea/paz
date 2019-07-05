using System.Collections.Generic;
using videojuego.Models;

namespace videojuego.utils
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<Datosvideoj> todos = new List<Datosvideoj>();
                
        public Store()
        {
        }
        public static Store Instance
        {
            get
            {
                return _instance;
            }
        }
        
    }
}