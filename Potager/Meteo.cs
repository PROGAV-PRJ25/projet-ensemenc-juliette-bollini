using System;

public class Meteo
{
    private Random rnd;

    public Meteo()
    {
        rnd = new Random();
    }

    public int ChangementDeTemperature()
    {
        // Température aléatoire entre 18 et 24 inclus
        return rnd.Next(18, 25);
    }

    public string ChangementDeMeteo(
        double probaEnsoleille,
        double probaNuageux,
        double probaPluvieux
    )
    {
        double tirage = rnd.NextDouble();

        if (tirage < probaEnsoleille)
        {
            return "ensoleillé";
        }
        else if (tirage < probaEnsoleille + probaNuageux)
        {
            return "nuageux";
        }
        else
        {
            return "pluvieux";
        }
    }
}
