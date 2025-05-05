public abstract class Plante
{
    public string Nature { get; set; }
    public string Nom { get; protected set; }
    public List<Saison> SaisonsSemis { get; set; }
    public float EspaceNecessaire { get; set; }
    public float VitesseDeCroissance { get; set; }
    public float BesoinsEau { get; set; }
    public float BesoinsLuminosite { get; set; }
    public float TemperatureMin { get; set; }
    public float TemperatureMax { get; set; }
    public int EsperanceVie { get; set; }
    public double Production { get; set; } = 0;
    public int Age { get; set; } = 0;
    public bool EstVivante { get; set; } = true;
    public bool EstMature { get; set; } = false;
    public bool EstMalade { get; set; } = false;
    public string Maladie { get; set; }
    public double ProbaTomberMalade { get; set; }

    public Plante()
    {
        SaisonsSemis = new List<Saison>();
    }

    public string GetSymbole()
    {
        if (Nature == null)
            return ""; // Sol vide
        if (EstVivante == false)
            return "💀";
        else if (EstMature == false)
            return "🌱";
        else if (Nature == "Cannabis") //comme les noms des plantes seront associées à un numéro le contains parait nécessaire
            return "🌿";
        else if (Nature == "Pavot" && EstMature == true)
            return "🌸";
        else if (Nature == "Coca" && EstMature == true)
            return "🌵";
        else
            Console.WriteLine("cette plante n'existe pas dans le jeu ");
        return "";
    }

    public void Croitre(double eauDispo, double temperature, Saison saison)
    {
        // 1) On ne croît que si la saison est bonne et si la plante est vivante
        if (!EstVivante)
            return;

        // 2) Calcul des facteurs eau et température
        double fe = Math.Min(eauDispo / BesoinsEau, 1.0);
        // double fl = Math.Min(lumDispo / BesoinsLuminausite, 1.0);
        double ft = (temperature < TemperatureMin || temperature > TemperatureMax) ? 0.5 : 1.0;

        // 3) Incrémenter âge et production
        double delta = VitesseDeCroissance * fe * ft; //fl
        Age += 1;
        Production += delta;
        if (delta > 1)
        {
            EstMature = true;
            Console.WriteLine($"la plante {Nom} a atteint ça maturitée");
        }
        // 4) Si on dépasse l'espérance de vie, la plante meurt
        if (Age >= EsperanceVie)
        {
            EstVivante = false;
        }
    }

    public void DevenirMalade()
    {
        Random rand = new Random();
        if (rand.NextDouble() < ProbaTomberMalade)
        {
            Console.WriteLine($"La plante {Nom} est affectée par la maladie : {Maladie}");
            EstMalade = true;
        }
        else
        {
            Console.WriteLine($"La plante {Nom} résiste à la maladie {Maladie}");
        }
    }
}
