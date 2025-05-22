public abstract class Terrain
{
    public int Place { get; set; } = 9;
    public string? Nom { get; protected set; }

    // Type de sol (sable, terre, argile…)
    public string? TypeSol { get; set; }

    // Pourcentage d'eau retenue dans le sol (0 à 1)
    public int TeneurEau { get; set; }

    // Liste des plantes plantées sur ce terrain
    public List<Plante> Plantes { get; set; }

    protected Terrain()
    {
        Plantes = new List<Plante>();
    }

    public virtual void AjouterPlante(Plante plante)
    {
        Plantes.Add(plante);
        Console.WriteLine($"→ {plante.Nom} planté(e) sur terrain {Nom}.");
    }

    public void ArroserTerrain()
    {
        TeneurEau = 100;
    }

    public virtual void RecolterTerrain()
    {
        for (int i = 0; i < Plantes.Count; i++)
        {
            Plantes[i].Recolter();
        }
    }

    public void RatisserTerrain()
    {
        for (int i = 0; i < Plantes.Count; i++)
        {
            if (!Plantes[i].EstVivante)
            {
                Plantes.RemoveAt(i);
            }
        }
    }

    public virtual void Assecher() { }
}
