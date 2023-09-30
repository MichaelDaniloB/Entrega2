
class Program
{
    static void Main(string[] args)
    {
    
        IJugador jugador1 = new Jugador("Juan", "Delantero", 5);
        IJugador jugador2 = new Jugador("Elver", "Defensa", 7);
        IJugador jugador3 = new Jugador("Galarga", "Mediocampista", 6);
        IJugador jugador4 = new Jugador("Rosa", "Delantero", 9);
        IJugador jugador5 = new Jugador("Melano", "Defensa", 7);
        IJugador jugador6 = new Jugador("Pinocho", "Mediocampista", 8);

        
        Equipo equipo1 = new Equipo();
        Equipo equipo2 = new Equipo();

        
        var random = new Random();
        var TodoslosJugadores = new List<IJugador> { jugador1, jugador2, jugador3, jugador4, jugador5, jugador6 };

        while (TodoslosJugadores.Count > 0)
        {
            var JudaroAleatorio = random.Next(TodoslosJugadores.Count);
            var jugadorElegido = TodoslosJugadores[JudaroAleatorio];
            if (equipo1.CalcularPuntaje() <= equipo2.CalcularPuntaje())
            {
                equipo1.AgregarJugador(jugadorElegido);
            }
            else
            {
                equipo2.AgregarJugador(jugadorElegido);
            }
            TodoslosJugadores.RemoveAt(JudaroAleatorio );
        }

        
        int puntajeEquipo1 = equipo1.CalcularPuntaje();
        int puntajeEquipo2 = equipo2.CalcularPuntaje();

        Console.WriteLine($"Puntaje del Equipo 1: {puntajeEquipo1}");
        Console.WriteLine($"Puntaje del Equipo 2: {puntajeEquipo2}");

        if (puntajeEquipo1 > puntajeEquipo2)
        {
            Console.WriteLine("El Equipo 1 gana el partido.");
        }
        else if (puntajeEquipo2 > puntajeEquipo1)
        {
            Console.WriteLine("El Equipo 2 gana el partido.");
        }
        else
        {
            Console.WriteLine("El partido termina en empate.");
        }
    }
}
