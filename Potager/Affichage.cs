public class Affichage
{
    public void AfficherPotager(List<Plante> plantes)
    {
        Console.WriteLine("État du potager :");
        foreach (var plante in plantes)
        {
            Console.Write($"| {GetSymbole(plante)} ");
        }
        Console.WriteLine("|");
    }

    public void AfficherDebut()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n⚠️  ATTENTION : Ce simulateur est une œuvre fictionnelle.");
        Console.WriteLine("Toutes les substances cultivées ici sont illégales dans la vraie vie.");
        Console.WriteLine("Ce jeu est une satire pédagogique. Ne reproduisez RIEN chez vous. ");
        Console.ResetColor();
    }

    public void AfficherMenuClassique() //une lecture des touches données par le joueur est à faire
    {
        Console.WriteLine("\n--- Menu ---");
        Console.WriteLine("1. Arroser");
        Console.WriteLine("2. Récolter");
        Console.WriteLine("3. Passer à la semaine suivante");
    }

    public void AfficherAlerte(string message) // voir pour le type de message entre alerte
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n⚠️ {message} ⚠️");
        Console.ResetColor();
    }

    private string GetSymbole(Plante plante) //à voir
    {
        if (!plante.EstVivante)
            return "💀";
        if (plante.EstMature)
            return "🍅";
        return "🌱";
    }
}
