namespace ordenador
{
//Creamos una clase memoria, que va a tener como variables el tamaño y un array de celdas
//que tendrá el mismo tamaño que lo indicado en la memoria
    public class Memoria
    {
        //Definición de las variables que tiene la clase Memoria
        private int tamanyo;
        private int [] celdas;

        //Constructor por defecto
        public Memoria()
        {
        }
        //Constructor que recibe valores
        public Memoria(int tamanyo)
        {
            this.setTamanyo(tamanyo);
            int [] celdas = new int [tamanyo];
            
        }
        
        //Declaramos los setter y los getter
        public int getTamanyo()
        {
            return this.tamanyo;
        }

        public void setTamanyo(int tamanyo)
        {
            this.tamanyo = tamanyo;
        }        
}
}