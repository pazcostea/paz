using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace videojuego.Models
{
    [Serializable]
    public class Datosvideoj
    {
        public long Id {get; set;}
        public string Titulo {get; set;}
        public int anyolanzamiento {get; set;}
        public Genero genero {get; set;}
        public int edadMinima {get; set;}
        public string companyia {get; set;}

        public static void Save(Datosvideoj videoj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("c:/tests/video/" + videoj.Id, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, videoj);
            stream.Close();
        }
        public static Datosvideoj Load(string ruta)
        {
            Datosvideoj videoj;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
            videoj = (Datosvideoj)formatter.Deserialize(stream);
            stream.Close(); return videoj;
        }
    }
    
}