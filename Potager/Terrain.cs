public abstract class Terrain
{
    public string Nom { get; protected set; }

    // Type de sol (sable, terre, argile…)
    public string TypeSol { get; set; }

    // Pourcentage d'eau retenue dans le sol (0 à 1)
    public float TeneurEau { get; set; }

    // Liste des plantes plantées sur ce terrain
    public List<Plante> Plantes { get; set; }

    protected Terrain()
    {
        Plantes = new List<Plante>();
    }

    public virtual void AjouterPlante(Plante plante)
    {
        Plantes.Add(plante);
        Console.WriteLine($"→ {plante.Nom} planté(e) sur terrain {TypeSol}.");
    }
}
