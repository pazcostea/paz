namespace ordenador
{
    public class AlmacenamientoHDD : Almacenamiento
    {
        private double capacidadHDD;
        private double vLecturaHDD;
        private double vEscrituraHDD;
    

    //Constructor 
    public AlmacenamientoHDD(double capacidadHDD, double vLecturaHDD, double vEscrituraHDD)
    {
        this.setCapacidadHDD(capacidadHDD);
        this.setVLecturaHDD(vLecturaHDD);
        this.setVEscrituraHDD(vEscrituraHDD);
    }

    public double getCapacidadHDD()
    {
        return this.capacidadHDD;
    }

    public void setCapacidadHDD(double capacidadHDD)
    {
        this.capacidadHDD = capacidadHDD;
    }

    public double getVLecturaHDD()
    {
        return this.vLecturaHDD;
    }

    public void setVLecturaHDD(double vLecturaHDD)
    {
        this.vLecturaHDD = vLecturaHDD;
    }
    public double getVEscrituraHDD()
    {
        return this.vEscrituraHDD;
    }

    public void setVEscrituraHDD(double vEscrituraHDD)
    {
        this.vEscrituraHDD = vEscrituraHDD;
    }
    public override string ToString()
        {            
            return string.Format("Las caracteristicas del almacenamiento HHD: Capacidad: {0}, Velocidad de lectura: {1}, velocidad de escritura: {2}", this.capacidadHDD, this.vLecturaHDD, this.vEscrituraHDD);
        } 
    
    }
}