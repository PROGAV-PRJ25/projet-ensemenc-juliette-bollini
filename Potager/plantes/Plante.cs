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

    public void Croitre(double eauDispo, double temperature, string meteo)
    {
        // 1) On ne croît que si la saison est bonne et si la plante est vivante
        if (!EstVivante)
            return;

        // 2) Calcul des facteurs eau et température
        double fe = Math.Min(eauDispo / BesoinsEau * 100, 1.0);

        double fm = 1;

        if (meteo == "ensoleiller")
        {
            fm = 1;
            temperature += 2;
        }
        else if (meteo == "nuageux")
        {
            fm = 0.7;
        }
        else if (meteo == "pluvieux")
        {
            temperature -= 2;
            fm = 0.5;
        }
        double ft = (temperature < TemperatureMin || temperature > TemperatureMax) ? 0.5 : 1.0;
        // 3) Incrémenter âge et production
        double delta = VitesseDeCroissance * fe * ft * fm; //fl
        Age += 1;
        Production += delta;
        if (EstMalade)
        {
            Production -= 0.1;
        }
        if (Production >= 1 && !EstMature)
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

    public void Recolter()
    {
        if (!EstVivante || !EstMature)
            return;

        EstMature = false;
        Production = 0;
        AjouterAuPanier();
    }

    // Hook pour que chaque plante incremente son propre compteur
    protected virtual void AjouterAuPanier() { }

    public void TomberMalade()
    {
        Random rand = new Random();
        if (rand.NextDouble() < ProbaTomberMalade)
        {
            Console.WriteLine($"La plante {Nom} est affectée par la maladie : {Maladie}");
            EstMalade = true;
        }
    }
}
