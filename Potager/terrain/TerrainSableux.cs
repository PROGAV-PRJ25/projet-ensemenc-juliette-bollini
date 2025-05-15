public class TerrainSableux : Terrain
{
    private static int _compteur = 0;

    public TerrainSableux()
    {
        _compteur++;
        Nom = $"Terrain sableux{_compteur}";
        TypeSol = "sable";
        TeneurEau = 100;
    }

    public override void Assecher()
    {
        TeneurEau -= 3;
    }
}
