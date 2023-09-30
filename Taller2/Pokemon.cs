namespace Taller2.clases;

public class Pokemon : APokemon
{
    private string Nombre { get; set; }
    private String tipo { get; set; }
    private int[] ataque { get; set; }
    private int defensa { get; set; }
    public Pokemon() { }

    public Pokemon(string Nombre, string tipo, int[] ataque, int defensa)
    {
        this.Nombre = Nombre;
        this.ataque = ataque;
        this.defensa = defensa;
        this.tipo = tipo;
    }
    public string getNombre()
    {
        return this.Nombre;
    }
    public int getAtaque()
    {
        Random random = new Random();
        int valorAleatorio = random.Next(0, ataque.Length);
        return ataque[valorAleatorio];
    }

    public int getDefensa()
    {
        return this.defensa;
    }
    public string getTipo()
    {
        return this.tipo;
    }
}