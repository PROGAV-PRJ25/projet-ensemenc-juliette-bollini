public class TerrainSableux : Terrain
{
    private static int _compteur = 0;

    public TerrainSableux()
    {
        _compteur++;
        Nom = $"Terrain sableux{_compteur}";
        TypeSol = "sable";
        TeneurEau = 0.3f;
    }

    protected override void Arroser()
    {
        TeneurEau = 0.3f;
    }
}
