public class Maladie
{
    public string Nom { get; set; }
    public float Proba { get; set; }

    public Maladie(string nom, float proba)
    {
        Nom = nom;
        Proba = proba;
    }

    public void AffecterPlante(Plante p)
    {
        Random rand = new Random();
        if (rand.NextDouble() < Proba)
            Console.WriteLine($"La plante est affectée par la maladie : {Nom}");
        else
            Console.WriteLine("La plante résiste à la maladie " + Nom);
    }
}
