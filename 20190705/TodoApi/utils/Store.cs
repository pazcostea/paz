using System.Collections.Generic;
using TodoApi.Models;
namespace TodoApi.utils
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<Todoitem> todos = new List<Todoitem>();

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