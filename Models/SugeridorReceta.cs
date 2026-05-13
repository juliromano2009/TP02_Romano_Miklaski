namespace TP02.Models;

public class SugeridorRecetas
{
    public string nombreCocinero {get; set;};
    public date fechaNacimiento {private get; set;};
    public string TipoComida {private get; set;};
    public double presupuestoDisponible {private get; set;};
    public int cantComensales {private get; set;};

    public int calcularEdad()
    {
        int edad;
        int hoy = DateTime.Today;

        edad = hoy - fechaNacimiento;

        return edad;
    }

    public string determinarPlato()
    {
        if(TipoComida == "caliente")
        {
            if(presupuesto  < 3000)
            {
                return "Fideos con manteca";
            }
            else if(presupuesto >= 3000 && presupuesto <= 7000)
            {
                return "Arroz con verduras salteadas";
            }
            else if(presupuesto > 7000)
            {
                return "Pollo al horno con guarnición";
            }
        }
        else if(TipoComida == "fria")
        {
            if(presupuesto  < 3000)
            {
                return "Ensalada simple";
            }
            else if(presupuesto >= 3000 && presupuesto <= 7000)
            {
                return "Ensalada completa con proteína";
            }
            else if(presupuesto > 7000)
            {
                return "Tabla de fiambres y quesos";
            }
        }
    }
}