public abstract class Plante
{
    public string Nature { get; set; }
    public List<string> SaisonsSemis { get; set; }
    public string TerrainPrefere { get; set; }
    public float Espacement { get; set; }
    public float EspaceNecessaire { get; set; }
    public float VitesseDeCroissance { get; set; }
    public float BesoinsEau { get; set; }
    public float BesoinsLuminosite { get; set; }
    public float TemperatureMin { get; set; }
    public float TemperatureMax { get; set; }
    public List<Maladie> Maladies { get; set; }
    public int EsperanceVie { get; set; }
    public int Production { get; set; }
    public int Age { get; set; } = 0;

    public Plante()
    {
        SaisonsSemis = new List<string>();
        Maladies = new List<Maladie>();
    }

    public virtual void GererCroissance()
    {
        Console.WriteLine("La plante " + Nature + " croît.");
    }

    public virtual void Produire()
    {
        Console.WriteLine("La plante produit " + Production + " produit(s).");
    }
}
