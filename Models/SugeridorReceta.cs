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
}