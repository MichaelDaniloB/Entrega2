
using Taller2.clases;
string nombrePokemon = "";
String tipoPokemon = "";
int[] ataques;
int valorDefensa;
int opcion = 0;
int ataque;
List<Pokemon> listaPokemones = new List<Pokemon>();
Pokemon pokemon1 = new Pokemon();
Pokemon pokemon2 = new Pokemon();

do
{
    Console.WriteLine("Ingrese 1 para crear pokemon");
    Console.WriteLine("Ingrese 2 para iniciar ataque");
    Console.WriteLine("Ingrese 3 para salir");
    opcion = Int32.Parse(Console.ReadLine());
    if (opcion == 1)
    {
        Console.WriteLine("Ingrese nombre del pokemon 1: ");
        nombrePokemon = Console.ReadLine();
        Console.WriteLine("Ingrese tipo del pokemon 1: ");
        tipoPokemon = Console.ReadLine();
        ataques = new int[3];
        for (int i = 0; i < ataques.Length; i++)
        {

            Console.WriteLine($"ingrese el valor del ataque numero {i+1}");
            ataque = Int32.Parse(Console.ReadLine());
            ataques[i] = ataque;
        }
        Console.WriteLine("Ingrese defensa del pokemon 1: ");
        valorDefensa = Int32.Parse(Console.ReadLine());
        pokemon1 = new Pokemon(nombrePokemon, tipoPokemon, ataques, valorDefensa);
        listaPokemones.Add(pokemon1);

        Console.WriteLine($"se creo el pokemon 1 {pokemon1.getNombre()}");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Ingrese nombre del pokemon 2: ");
        nombrePokemon = Console.ReadLine();
        Console.WriteLine("Ingrese tipo del pokemon 2: ");
        tipoPokemon = Console.ReadLine();
        ataques = new int[3];
        for (int i = 0; i < ataques.Length; i++)
        {

            Console.WriteLine($"ingrese el valor del ataque numero {i + 1}");
            ataque = Int32.Parse(Console.ReadLine());
            ataques[i] = ataque;
        }
        Console.WriteLine("Ingrese defensa del pokemon 2: ");
        valorDefensa = Int32.Parse(Console.ReadLine());
        pokemon2 = new Pokemon(nombrePokemon, tipoPokemon, ataques, valorDefensa);
        listaPokemones.Add(pokemon2);
        Console.WriteLine($"se creo el pokemon 2 {pokemon2.getNombre()}");

    }
    if (opcion == 2)
    {
        int ataqueFinal = 0;
        int defensaFinal = 0;
        int puntosPokemon1 = 0;
        int puntosPokemon2 = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Turno de atacar pokemon 1");
            ataqueFinal = pokemon1.atacar(pokemon1);
            Console.WriteLine($"El ataque del pokemon 1: {ataqueFinal}");
            defensaFinal = pokemon2.defender(pokemon2);
            Console.WriteLine($"La defensa del pokemon 2 es: {defensaFinal}");

            if (ataqueFinal > defensaFinal)
            {

                puntosPokemon1++;
                Console.WriteLine($"El pokemon 1 gana esta ronda, lleva {puntosPokemon1} puntos");
            }
            else
            {
                puntosPokemon2++;
                Console.WriteLine($"El pokemon 2 gana esta ronda, lleva {puntosPokemon2} puntos");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Turno de atacar pokemon 2");
            ataqueFinal = pokemon2.atacar(pokemon2);
            Console.WriteLine($"El ataque del pokemon 2: {ataqueFinal}");
            defensaFinal = pokemon1.defender(pokemon1);
            Console.WriteLine($"La defensa del pokemon 1 es: {defensaFinal}");

            if (ataqueFinal > defensaFinal)
            {
                puntosPokemon2++;
                Console.WriteLine($"El pokemon 2 gana esta ronda, lleva {puntosPokemon2} puntos");
            }
            else
            {
                puntosPokemon1++;
                Console.WriteLine($"El pokemon 1 gana esta ronda, lleva {puntosPokemon1} puntos");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }
        Console.WriteLine($"Puntaje de pokemon 1: {puntosPokemon1}");
        Console.WriteLine($"Puntaje de pokemon 2: {puntosPokemon2}");
        if (puntosPokemon1 > puntosPokemon2)
        {
            Console.WriteLine($"El ganador es el pokemon {pokemon1.getNombre()}");
        }
        else if (puntosPokemon2 > puntosPokemon1)
        {
            Console.WriteLine($"El ganador es el pokemon 2 {pokemon2.getNombre()}");
        }
        else
        {
            Console.WriteLine($"Puntaje de pokemon 1: {puntosPokemon1}");
            Console.WriteLine($"Puntaje de pokemon 2: {puntosPokemon2}");
            Console.WriteLine($"Quedaron empatados");
        }

    }


} while (opcion != 3);

{
    throw new NotImplementedException();
}