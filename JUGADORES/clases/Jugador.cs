
public class Jugador : IJugador
{
    private string nombre;
    private string posicion;
    private int rendimiento;

    public Jugador(string nombre, string posicion, int rendimiento)
    {
        this.nombre = nombre;
        this.posicion = posicion;
        this.rendimiento = rendimiento;
    }

    public string Nombre => nombre;
    public string Posicion => posicion;
    public int Rendimiento => rendimiento;
}
