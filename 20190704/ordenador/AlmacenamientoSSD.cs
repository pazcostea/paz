namespace ordenador
{
    public class AlmacenamientoSSD : Almacenamiento
    {
        private double capacidadSSD;
        private double vLecturaSSD;
        private double vEscrituraSSD;
       
        //Constructor
        public AlmacenamientoSSD (double capacidadSSD, double vLecturaSSD, double vEscrituraSSD)
        {
            this.setCapacidadSSD(capacidadSSD);
            this.setVLecturaSSD(vLecturaSSD);
            this.setVEscrituraSSD(vEscrituraSSD);      

        }

        public double getCapacidadSSD()
        {
            return this.capacidadSSD;
        }

        public void setCapacidadSSD(double capacidadSSD)
        {
            this.capacidadSSD = capacidadSSD;
        }
        public double getVLecturaSSD()
        {
            return this.vLecturaSSD;
        }

        public void setVLecturaSSD(double vLecturaSSD)
        {
            this.vLecturaSSD = vLecturaSSD;
        }
        public double getVEscrituraSSD()
        {
            return this.vEscrituraSSD;
        }

        public void setVEscrituraSSD(double vEscrituraSSD)
        {
            this.vEscrituraSSD = vEscrituraSSD;
        }
        public override string ToString()
        {            
            return string.Format("Las caracteristicas del almacenamiento SSD: Capacidad: {0}, Velocidad de lectura: {1}, velocidad de escritura: {2}", this.capacidadSSD, this.vLecturaSSD, this.vEscrituraSSD);
        } 
    }
}