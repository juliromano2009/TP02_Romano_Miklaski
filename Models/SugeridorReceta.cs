namespace TP02.Models;

public class SugeridorRecetas
{
    public string nombreCocinero {get; set;};
    public date fechaNacimiento {private get; set;};
    public string comidaPreferida {private get; set;};
    public double presupuestoDisponible {private get; set;};
    public int cantComensales {private get; set;};

    public int calcularEdad()
    {
        int edad;
        int hoy = DateTime.Today;

        edad = hoy - fechaNacimiento;

        return edad;
    }
}