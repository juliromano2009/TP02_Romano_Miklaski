namespace TP02.Models;

public class SugeridorRecetas
{
    public string NombreCocinero {get; set;}
    public DateTime fechaNacimiento {get; set;}
    public string TipoComida {get; set;}
    public double presupuestoDisponible {get; set;}
    public int cantComensales {get; set;}

    public int calcularEdad()
    {
        int edad = DateTime.Today.Year - fechaNacimiento.Year;

        if(DateTime.Today.Month < fechaNacimiento.Month && DateTime.Today.Day < fechaNacimiento.Day)
        {
            edad--;
        }

        return edad;
    }

    public string generarSaludo()
    {
        int horario = DateTime.Now.Hour;
        string saludo = "";
        if(horario < 12)
        {
            saludo = "Buenos días!";
        }
        else if(horario >= 12 && horario <= 7)
        {
            saludo = "Buenas tardes!";
        }
        else if(horario > 7)
        {
            saludo = "Buenas noches!";
        }
        return saludo;
    }

    public string generarTip()
    {
        int edad = calcularEdad();
        string tip = "";
        if(edad < 18)
        {
            tip = "Ten cuidado con quienes compartís tus datos";
        }
        else if(edad >= 18 && edad < 60)
        {
            tip = "¡Sigue, tu puedes! 😁😁😁";
        }
        else if (edad >= 60)
        {
            tip = "Mensaje especial: Al que madriga Dios lo ayuda 😊";
        } 
        return tip;
    }

    public string determinarPlato()
    {
        string devolucion = "";
        if(TipoComida == "caliente")
        {
            if(presupuestoDisponible < 3000)
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
            if(presupuestoDisponible < 3000)
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
        int tiempoEsperado = 0;
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
        return tiempoEsperado;
    }

    public string determinarDificultar()
    {
        string dificultad = null;

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
        return dificultad;
    }
}