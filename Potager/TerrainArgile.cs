public class TerrainArgile : Terrain
{
    private static int _compteur = 0;

    public TerrainArgile()
    {
        _compteur++;
        Nom = $"Terrain d'argile{_compteur}";
        TypeSol = "Argile";
        TeneurEau = 0.9f;
    }
}
