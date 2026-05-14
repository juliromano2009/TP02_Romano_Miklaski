namespace TP02.Models;

public class SugeridorRecetas
{
    public string nombreCocinero {get; set;}
    public DateTime fechaNacimiento {private get; set;}
    public string TipoComida {private get; set;}
    public double presupuestoDisponible {private get; set;}
    public int cantComensales {private get; set;}

    public int calcularEdad()
    {
        int edad = DateTime.Today.Year - fechaNacimiento.Year;

        if(DateTime.Today.Month < fechaNacimiento.Month && DateTime.Today.Day < fechaNacimiento.Day)
        {
            edad--;
        }

        return edad;
    }

    public string determinarPlato()
    {
        string devolucion = null;
        if(TipoComida == "caliente")
        {
            if(presupuestoDisponible  < 3000)
            {
                devolucion = "Fideos con manteca";
            }
            else if(presupuestoDisponible >= 3000 && presupuestoDisponible <= 7000)
            {
                devolucion = "Arroz con verduras salteadas";
            }
            else if(presupuestoDisponible > 7000)
            {
                devolucion = "Pollo al horno con guarnición";
            }
        }
        else if(TipoComida == "fria")
        {
            if(presupuestoDisponible  < 3000)
            {
                devolucion = "Ensalada simple";
            }
            else if(presupuestoDisponible >= 3000 && presupuestoDisponible <= 7000)
            {
                devolucion = "Ensalada completa con proteína";
            }
            else if(presupuestoDisponible > 7000)
            {
                devolucion = "Tabla de fiambres y quesos";
            }
        }
        return devolucion;
    }

    public int determinarTiempo()
    {
        int tiempoEsperado;
        if(TipoComida == "caliente")
        {
            if(cantComensales >= 1 && cantComensales <= 3)
            {
                tiempoEsperado = 20;
            }
            else if(cantComensales >= 4 && cantComensales <= 7)
            {
                tiempoEsperado = 40;
            }
            else if(cantComensales >= 8)
            {
                tiempoEsperado = 80;
            }
        }
        else if(TipoComida == "fria")
        {
            if(cantComensales >= 1 && cantComensales <= 3)
            {
                tiempoEsperado = 10;
            }
            else if(cantComensales >= 4 && cantComensales <= 7)
            {
                tiempoEsperado = 20;
            }
            else if(cantComensales >= 8)
            {
                tiempoEsperado = 40;
            }
        }
    }

    public string determinarDificultar()
    {
        string dificultad;

        if(cantComensales <= 7)
        {
            if(presupuestoDisponible < 3000)
            {
                if(cantComensales >= 1 && cantComensales <= 3)
                {
                    dificultad = "Principiante";
                }
                else if(cantComensales >= 4 && cantComensales <= 7)
                {
                    dificultad = "Intermedio";
                }
            }
            else if(presupuestoDisponible >= 3000)
            {
                dificultad = "Intermedio"; 
            }
        }
        else if(cantComensales >= 8)
        {
            dificultad = "Avanzado";
        }
    }
}