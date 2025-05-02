public abstract class Plante
{
    public string Nature { get; set; }
    public string Nom { get; protected set; }
    public List<string> SaisonsSemis { get; set; }
    public float Espacement { get; set; }
    public float EspaceNecessaire { get; set; }
    public float VitesseDeCroissance { get; set; }
    public float BesoinsEau { get; set; }
    public float BesoinsLuminosite { get; set; }
    public float TemperatureMin { get; set; }
    public float TemperatureMax { get; set; }
    public int EsperanceVie { get; set; }
    public int Production { get; set; }
    public int Age { get; set; } = 0;
    public bool EstVivante { get; set; } = true;
    public bool EstMature { get; set; } = false;
    public bool EstMalade { get; set; } = false;
    public string Maladie { get; set; }
    public double ProbaTomberMalade { get; set; }

    public Plante()
    {
        SaisonsSemis = new List<string>();
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
