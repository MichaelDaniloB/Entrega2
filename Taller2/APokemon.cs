using System.Diagnostics.Contracts;

namespace Taller2.clases;

public abstract class APokemon : IPokemon
{
    public int atacar(Pokemon pokemon)
    {
        int valorAtaque = pokemon.getAtaque();
        Random random = new Random();
        int valorRandom=random.Next(0, 2);
        valorAtaque *= valorRandom ;

        return valorAtaque;
    }
    public int defender(Pokemon pokemon)
    {
        int valorDefensa = pokemon.getDefensa();
        Random random = new Random();
        double randomFactor = random.Next(0,2);
        if(randomFactor==0){
            randomFactor=0.5;
        }
        double valorDefensaModificado = valorDefensa * randomFactor;
        return (int)valorDefensaModificado;
    }


}