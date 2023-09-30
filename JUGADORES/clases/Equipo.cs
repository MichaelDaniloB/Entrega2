

public class Equipo
{
    private List<IJugador> jugadores = new List<IJugador>();

    public void AgregarJugador(IJugador jugador)
    {
        if (jugadores.Count < 3)
        {
            jugadores.Add(jugador);
            Console.WriteLine($"{jugador.Nombre},{jugador.Posicion} se ha unido al equipo.");
        }
        
    }

    public int CalcularPuntaje()
    {
        int puntajeTotal = 0;
        foreach (var jugador in jugadores)
        {
            puntajeTotal += jugador.Rendimiento;
        }
        return puntajeTotal;
    }
}
