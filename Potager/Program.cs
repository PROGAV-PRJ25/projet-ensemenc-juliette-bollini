string meteo = ChangementDeMeteo(0.4, 0.3, 0.3);
var semisPavots = new List<Pavot>();
int temperature = ChangementDeTemperature();
var semisCannabis = new List<Cannabis>();
var semisCoca = new List<Coca>();
var terrainsArgiles = new List<TerrainArgile>();
var terrainsTerre = new List<TerrainTerre>();
var terrainsSableux = new List<TerrainSableux>();
var boutique = new Boutique();
int nombreDeSemaine;
var affichage = new Affichage();
terrainsArgiles.Add(new TerrainArgile());
terrainsSableux.Add(new TerrainSableux());
terrainsTerre.Add(new TerrainTerre());

affichage.AfficherDebut();

Console.WriteLine("combien de semaine voulez vous jouer?");
nombreDeSemaine = int.Parse(Console.ReadLine()!);

int jour = 1;
while (jour <= nombreDeSemaine * 7) // la boucle while sert à pouvoir effectuer plusieurs actions le même jour
{
    Console.WriteLine($"jour: {jour}");
    Console.WriteLine($"Le ciel est {meteo}");
    Console.WriteLine($"la température est de {temperature} degrès celcius");
    bool choixValide = false;
    bool jourEnCours = true; // variable qui change pour changer de jour

    while (!choixValide && jourEnCours == true)
    {
        Console.WriteLine("Que voulez-vous faire aujourd'hui?");
        affichage.AfficherMenuClassique();

        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // on lit les touches que l'utilisateur fait
        char touche = keyInfo.KeyChar;

        if (touche == '1')
        {
            if (boutique.Argent >= 1)
            {
                Console.WriteLine("\nVous avez choisi de planter un semis !");
                choixValide = true;
                bool choix2Valide = false;

                while (!choix2Valide)
                {
                    Console.WriteLine("sur quel type de terrain voulez vous planter?");
                    Console.WriteLine("1)Terre 2)Sable 3)Argile");

                    ConsoleKeyInfo keyInfo2 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                    char touche2 = keyInfo2.KeyChar;
                    if (touche2 == '1')
                    {
                        Console.WriteLine("\nVous avez choisi Terre!");
                        choix2Valide = true;
                        Console.WriteLine("Sur le quel voulez vous planter?");
                        int numeroTerrain;
                        for (int i = 1; i <= terrainsTerre.Count; i++)
                        {
                            Console.Write($"{i}){terrainsTerre[i - 1].Nom} ");
                        }
                        Console.WriteLine("\nchoisissez puis entrer");
                        numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                        if (terrainsTerre[numeroTerrain].Place > 0)
                        {
                            Console.WriteLine(
                                $"Vous avez décidé de planter sur {terrainsTerre[numeroTerrain].Nom}"
                            );
                            bool choix3Valide = false;

                            while (!choix3Valide)
                            {
                                Console.WriteLine("Quelle type de plante voulez vous planter?");
                                Console.Write("1)Coca 2)Canabis 3)Pavot");

                                ConsoleKeyInfo keyInfo3 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                                char touche3 = keyInfo3.KeyChar;

                                if (touche3 == '1')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter de la Coca");
                                    choix3Valide = true;
                                    semisCoca.Add(new Coca());
                                    terrainsTerre[numeroTerrain].AjouterPlante(semisCoca[0]);
                                    semisCoca.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                                }
                                else if (touche3 == '2')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter du Canabis");
                                    choix3Valide = true;
                                    semisCannabis.Add(new Cannabis());
                                    terrainsTerre[numeroTerrain].AjouterPlante(semisCannabis[0]);
                                    semisCannabis.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                                }
                                else if (touche3 == '3')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter du Pavot");
                                    choix3Valide = true;
                                    semisPavots.Add(new Pavot());
                                    terrainsTerre[numeroTerrain].AjouterPlante(semisPavots[0]);
                                    semisPavots.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                                }
                                else
                                {
                                    Console.WriteLine("\nSaisie invalide.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("il n'y a plus de place dans ce terrain");
                        }
                    }
                    else if (touche2 == '2')
                    {
                        Console.WriteLine("\nVous avez choisi Sable");
                        choix2Valide = true;
                        Console.WriteLine("Sur le quel voulez vous planter?");
                        int numeroTerrain;
                        for (int i = 1; i <= terrainsSableux.Count; i++)
                        {
                            Console.Write($"{i}){terrainsSableux[i - 1].Nom} ");
                        }
                        Console.WriteLine("\nchoisissez puis entrer");
                        numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                        if (terrainsSableux[numeroTerrain].Place > 0)
                        {
                            Console.WriteLine(
                                $"Vous avez décidé de planter sur {terrainsSableux[numeroTerrain].Nom}"
                            );
                            bool choix3Valide = false;

                            while (!choix3Valide)
                            {
                                Console.WriteLine("Quelle type de plante voulez vous planter?");
                                Console.Write("1)Coca 2)Canabis 3)Pavot");

                                ConsoleKeyInfo keyInfo3 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                                char touche3 = keyInfo3.KeyChar;

                                if (touche3 == '1')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter de ma Coca");
                                    choix3Valide = true;
                                    semisCoca.Add(new Coca());
                                    terrainsSableux[numeroTerrain].AjouterPlante(semisCoca[0]);
                                    semisCoca.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsSableux[numeroTerrain]);
                                }
                                else if (touche3 == '2')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter du Canabis");
                                    choix3Valide = true;
                                    semisCannabis.Add(new Cannabis());
                                    terrainsSableux[numeroTerrain].AjouterPlante(semisCannabis[0]);
                                    semisCannabis.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsSableux[numeroTerrain]);
                                }
                                else if (touche3 == '3')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter du Pavot");
                                    choix3Valide = true;
                                    semisPavots.Add(new Pavot());
                                    terrainsSableux[numeroTerrain].AjouterPlante(semisPavots[0]);
                                    semisPavots.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsSableux[numeroTerrain]);
                                }
                                else
                                {
                                    Console.WriteLine("\nSaisie invalide.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("il n'y a plus de place dans ce terrain");
                        }
                    }
                    else if (touche2 == '3')
                    {
                        Console.WriteLine("\nVous avez choisi Argile");
                        choix2Valide = true;
                        Console.WriteLine("Sur le quel voulez vous planter?");
                        int numeroTerrain;
                        for (int i = 1; i <= terrainsArgiles.Count; i++)
                        {
                            Console.Write($"{i}){terrainsArgiles[i - 1].Nom} ");
                        }
                        Console.WriteLine("\nchoisissez puis entrer");
                        numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                        if (terrainsArgiles[numeroTerrain].Place > 0)
                        {
                            Console.WriteLine(
                                $"Vous avez décidé de planter sur {terrainsArgiles[numeroTerrain].Nom}"
                            );
                            bool choix3Valide = false;

                            while (!choix3Valide)
                            {
                                Console.WriteLine("Quelle type de plante voulez vous planter?");
                                Console.Write("1)Coca 2)Canabis 3)Pavot");

                                ConsoleKeyInfo keyInfo3 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                                char touche3 = keyInfo3.KeyChar;

                                if (touche3 == '1')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter de ma Coca");
                                    choix3Valide = true;
                                    semisCoca.Add(new Coca());
                                    terrainsArgiles[numeroTerrain].AjouterPlante(semisCoca[0]);
                                    semisCoca.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsArgiles[numeroTerrain]);
                                }
                                else if (touche3 == '2')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter du Canabis");
                                    choix3Valide = true;
                                    semisCannabis.Add(new Cannabis());
                                    terrainsArgiles[numeroTerrain].AjouterPlante(semisCannabis[0]);
                                    semisCannabis.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsArgiles[numeroTerrain]);
                                }
                                else if (touche3 == '3')
                                {
                                    Console.WriteLine("\nVous avez choisi de planter du Pavot");
                                    choix3Valide = true;
                                    semisPavots.Add(new Pavot());
                                    terrainsArgiles[numeroTerrain].AjouterPlante(semisPavots[0]);
                                    semisPavots.RemoveAt(0);
                                    affichage.AfficherTerrain(terrainsArgiles[numeroTerrain]);
                                }
                                else
                                {
                                    Console.WriteLine("\nSaisie invalide.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("il n'y a plus de place dans ce terrain");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSaisie invalide.");
                    }
                }
                boutique.Argent--;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas asser d'argent pour achetter un semis");
            }
        }
        else if (touche == '2') //Arroser
        {
            if (boutique.Argent >= 1)
            {
                Console.WriteLine("\nVous avez choisi d'arroser'.");
                bool choix2Valide = false;

                while (!choix2Valide)
                {
                    Console.WriteLine("quel type de terrain voulez vous arroser ?");
                    Console.WriteLine("1)Terre 2)Sable 3)Argile");

                    ConsoleKeyInfo keyInfo2 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                    char touche2 = keyInfo2.KeyChar;
                    if (touche2 == '1')
                    {
                        Console.WriteLine("\nVous avez choisi Terre!");
                        choix2Valide = true;
                        Console.WriteLine(" Lequel voulez vous arroser ?");
                        int numeroTerrain;
                        for (int i = 1; i <= terrainsTerre.Count; i++)
                        {
                            Console.Write($"{i}){terrainsTerre[i - 1].Nom} ");
                        }
                        Console.WriteLine("\nchoisissez puis entrer");
                        numeroTerrain = int.Parse(Console.ReadLine()!) - 1;

                        if (terrainsTerre[numeroTerrain].Place > 0)
                        {
                            Console.WriteLine(
                                $"Vous avez décidé d'arroser {terrainsTerre[numeroTerrain].Nom}"
                            );
                            terrainsTerre[numeroTerrain].ArroserTerrain();
                        }
                        else
                        {
                            Console.WriteLine("il n'y a plus de place dans ce terrain");
                        }
                    }
                    else if (touche2 == '2')
                    {
                        Console.WriteLine("\nVous avez choisi Sable");
                        choix2Valide = true;
                        Console.WriteLine(" Lequel voulez vous arroser ?");
                        int numeroTerrain;
                        for (int i = 1; i <= terrainsSableux.Count; i++)
                        {
                            Console.Write($"{i}){terrainsSableux[i - 1].Nom} ");
                        }
                        Console.WriteLine("\nchoisissez puis entrer");
                        numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                        if (terrainsSableux[numeroTerrain].Place > 0)
                        {
                            Console.WriteLine(
                                $"Vous avez décidé d'arroser {terrainsSableux[numeroTerrain].Nom}"
                            );
                            terrainsSableux[numeroTerrain].ArroserTerrain();
                        }
                    }
                    else if (touche2 == '3')
                    {
                        Console.WriteLine("\nVous avez choisi Argile");
                        choix2Valide = true;
                        Console.WriteLine(" Le quel voulez vous arroser ?");
                        int numeroTerrain;
                        for (int i = 1; i <= terrainsArgiles.Count; i++)
                        {
                            Console.Write($"{i}){terrainsArgiles[i - 1].Nom} ");
                        }
                        Console.WriteLine("\nchoisissez puis entrer");
                        numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                        if (terrainsArgiles[numeroTerrain].Place > 0)
                        {
                            Console.WriteLine(
                                $"Vous avez décidé d'arroser {terrainsArgiles[numeroTerrain].Nom}"
                            );
                            terrainsArgiles[numeroTerrain].ArroserTerrain();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSaisie invalide.");
                    }
                }
                boutique.Argent--;
            }
            else
            {
                Console.WriteLine(
                    "Vous n'avez pas asser d'argent pour achetter la quantité d'eau necessaire a l'arosage d'un terrain"
                );
            }
        }
        else if (touche == '3') //Récolter
        {
            Console.WriteLine("\nVous avez choisi de récolter.");
            bool choix2Valide = false;

            while (!choix2Valide)
            {
                Console.WriteLine("quel type de terrain voulez vous récolter ?");
                Console.WriteLine("1)Terre 2)Sable 3)Argile");

                ConsoleKeyInfo keyInfo2 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                char touche2 = keyInfo2.KeyChar;
                if (touche2 == '1')
                {
                    Console.WriteLine("\nVous avez choisi Terre!");
                    choix2Valide = true;
                    Console.WriteLine("Sur le quel voulez vous recolter ?");
                    int numeroTerrain;
                    for (int i = 1; i <= terrainsTerre.Count; i++)
                    {
                        Console.Write($"{i}){terrainsTerre[i - 1].Nom} ");
                    }
                    Console.WriteLine("\nchoisissez puis entrer");
                    numeroTerrain = int.Parse(Console.ReadLine()!) - 1;

                    if (terrainsTerre[numeroTerrain].Place > 0)
                    {
                        Console.WriteLine(
                            $"Vous avez décidé de récolter sur {terrainsTerre[numeroTerrain].Nom}"
                        );
                        terrainsTerre[numeroTerrain].RecolterTerrain();
                    }
                    else
                    {
                        Console.WriteLine("il n'y a plus de place dans ce terrain");
                    }
                }
                else if (touche2 == '2')
                {
                    Console.WriteLine("\nVous avez choisi Sable");
                    choix2Valide = true;
                    Console.WriteLine("Sur le quel voulez vous recolter ?");
                    int numeroTerrain;
                    for (int i = 1; i <= terrainsSableux.Count; i++)
                    {
                        Console.Write($"{i}){terrainsSableux[i - 1].Nom} ");
                    }
                    Console.WriteLine("\nchoisissez puis entrer");
                    numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                    if (terrainsSableux[numeroTerrain].Place > 0)
                    {
                        Console.WriteLine(
                            $"Vous avez décidé de récolter sur {terrainsSableux[numeroTerrain].Nom}"
                        );
                        terrainsSableux[numeroTerrain].RecolterTerrain();
                    }
                }
                else if (touche2 == '3')
                {
                    Console.WriteLine("\nVous avez choisi Argile");
                    choix2Valide = true;
                    Console.WriteLine("Sur le quel voulez vous récolter ?");
                    int numeroTerrain;
                    for (int i = 1; i <= terrainsArgiles.Count; i++)
                    {
                        Console.Write($"{i}){terrainsArgiles[i - 1].Nom} ");
                    }
                    Console.WriteLine("\nchoisissez puis entrer");
                    numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                    if (terrainsArgiles[numeroTerrain].Place > 0)
                    {
                        Console.WriteLine(
                            $"Vous avez décidé de récolter {terrainsArgiles[numeroTerrain].Nom}"
                        );
                        terrainsArgiles[numeroTerrain].RecolterTerrain();
                    }
                }
                else
                {
                    Console.WriteLine("\nSaisie invalide.");
                }
            }
        }
        else if (touche == '4') // Ratisser
        {
            Console.WriteLine("\nVous avez choisi de ratisser.");
            bool choix2Valide = false;

            while (!choix2Valide)
            {
                Console.WriteLine("quel type de terrain voulez vous ratisser ?");
                Console.WriteLine("1)Terre 2)Sable 3)Argile");

                ConsoleKeyInfo keyInfo2 = Console.ReadKey(intercept: true); // ne pas afficher la touche
                char touche2 = keyInfo2.KeyChar;
                if (touche2 == '1')
                {
                    Console.WriteLine("\nVous avez choisi Terre!");
                    choix2Valide = true;
                    Console.WriteLine("Sur le quel voulez vous recolter ?");
                    int numeroTerrain;
                    for (int i = 1; i <= terrainsTerre.Count; i++)
                    {
                        Console.Write($"{i}){terrainsTerre[i - 1].Nom} ");
                    }
                    Console.WriteLine("\nchoisissez puis entrer");
                    numeroTerrain = int.Parse(Console.ReadLine()!) - 1;

                    if (terrainsTerre[numeroTerrain].Place > 0)
                    {
                        Console.WriteLine(
                            $"Vous avez décidé de ratisser sur {terrainsTerre[numeroTerrain].Nom}"
                        );
                        terrainsTerre[numeroTerrain].RatisserTerrain();
                    }
                    else
                    {
                        Console.WriteLine("il n'y a plus de place dans ce terrain");
                    }
                }
                else if (touche2 == '2')
                {
                    Console.WriteLine("\nVous avez choisi Sable");
                    choix2Valide = true;
                    Console.WriteLine("Sur le quel voulez vous recolter ?");
                    int numeroTerrain;
                    for (int i = 1; i <= terrainsSableux.Count; i++)
                    {
                        Console.Write($"{i}){terrainsSableux[i - 1].Nom} ");
                    }
                    Console.WriteLine("\nchoisissez puis entrer");
                    numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                    if (terrainsSableux[numeroTerrain].Place > 0)
                    {
                        Console.WriteLine(
                            $"Vous avez décidé de ratisser sur {terrainsSableux[numeroTerrain].Nom}"
                        );
                        terrainsSableux[numeroTerrain].RatisserTerrain();
                    }
                }
                else if (touche2 == '3')
                {
                    Console.WriteLine("\nVous avez choisi Argile");
                    choix2Valide = true;
                    Console.WriteLine("Sur le quel voulez vous récolter ?");
                    int numeroTerrain;
                    for (int i = 1; i <= terrainsArgiles.Count; i++)
                    {
                        Console.Write($"{i}){terrainsArgiles[i - 1].Nom} ");
                    }
                    Console.WriteLine("\nchoisissez puis entrer");
                    numeroTerrain = int.Parse(Console.ReadLine()!) - 1;
                    if (terrainsArgiles[numeroTerrain].Place > 0)
                    {
                        Console.WriteLine(
                            $"Vous avez décidé de ratisser {terrainsArgiles[numeroTerrain].Nom}"
                        );
                        terrainsArgiles[numeroTerrain].RatisserTerrain();
                    }
                }
                else
                {
                    Console.WriteLine("\nSaisie invalide.");
                }
            }
        }
        else if (touche == '5')
        {
            Console.WriteLine("\nVous avez décider de visualiser tous vos terrains.");
            affichage.AfficherTousLesTerrainsAvecNavigation(
                terrainsTerre
                    .Cast<Terrain>()
                    .Concat(terrainsArgiles)
                    .Concat(terrainsSableux)
                    .ToList()
            );
        }
        else if (touche == '6') // Boutique
        {
            Console.WriteLine(
                $"\n-Vous avez dans votre stock {Pavot.TotalHarvested} de Pavot \n-Vous avez dans votre stock {Cannabis.TotalHarvested} de Cannabis \n-Vous avez dans votre stock {Coca.TotalHarvested} de Cocaïne"
            );
            boutique.VendreTout();
        }
        else if (touche == '7') // Passer au jour suivant
        {
            Console.WriteLine("\nVous passez au jour suivant.");
            Console.WriteLine(
                $"\n-Vous avez dans votre stock {Pavot.TotalHarvested} de Pavot \n-Vous avez dans votre stock {Cannabis.TotalHarvested} de Cannabis \n-Vous avez dans votre stock {Coca.TotalHarvested} de Cocaïne"
            );
            boutique.AfficherArgent();
            jourEnCours = false;
            jour++;
            temperature = ChangementDeTemperature();
            meteo = ChangementDeMeteo(0.4, 0.3, 0.3);
            for (int i = 0; i < terrainsSableux.Count; i++)
            {
                for (int ii = 0; ii < terrainsSableux[i].Plantes.Count; ii++)
                {
                    terrainsSableux[i]
                        .Plantes[ii]
                        .Croitre(terrainsSableux[i].TeneurEau, temperature, meteo);
                    terrainsSableux[i].Plantes[ii].TomberMalade();
                }
                terrainsSableux[i].Assecher();
            }
            for (int i = 0; i < terrainsTerre.Count; i++)
            {
                for (int ii = 0; ii < terrainsTerre[i].Plantes.Count; ii++)
                {
                    terrainsTerre[i]
                        .Plantes[ii]
                        .Croitre(terrainsTerre[i].TeneurEau, temperature, meteo);
                    terrainsTerre[i].Plantes[ii].TomberMalade();
                }
                terrainsTerre[i].Assecher();
            }
            for (int i = 0; i < terrainsArgiles.Count; i++)
            {
                for (int ii = 0; ii < terrainsArgiles[i].Plantes.Count; ii++)
                {
                    terrainsArgiles[i]
                        .Plantes[ii]
                        .Croitre(terrainsArgiles[i].TeneurEau, temperature, meteo);
                    terrainsArgiles[i].Plantes[ii].TomberMalade();
                }
                terrainsArgiles[i].Assecher();
            }
        }
        else
        {
            Console.WriteLine("\nSaisie invalide. Veuillez appuyer sur une touche valide.");
        }
    }
}

int ChangementDeTemperature()
{
    Random rnd = new Random();
    return rnd.Next(18, 25);
}
string ChangementDeMeteo(double probaEnsoleiller, double probaNuageux, double probapluvieux)
{
    Random rnd = new Random();
    double tirage = rnd.NextDouble();

    if (tirage < probaEnsoleiller)
    {
        return "ensoleiller";
    }
    else if (tirage < probaEnsoleiller + probaNuageux)
    {
        return "nuageux";
    }
    else
    {
        return "pluvieux";
    }
}
