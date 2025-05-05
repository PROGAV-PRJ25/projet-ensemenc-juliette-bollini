var semisPavots = new List<Pavot>();
var semisCannabis = new List<Cannabis>();
var semisCoca = new List<Coca>();
var terrainsArgiles = new List<TerrainArgile>();
var terrainsTerre = new List<TerrainTerre>();
var terrainsSableux = new List<TerrainSableux>();
var terrains = new List<List<Terrain>>();
int nombreDeSemaine;
var affichage = new Affichage();
terrainsArgiles.Add(new TerrainArgile());
terrainsSableux.Add(new TerrainSableux());
terrainsTerre.Add(new TerrainTerre());
for (int i = 0; i < 5; i++)
{
    semisPavots.Add(new Pavot());
}

Console.WriteLine("combien de semaine voulez vous jouer?");
nombreDeSemaine = int.Parse(Console.ReadLine()!);

for (int j = 1; j < nombreDeSemaine * 7 + 1; j++)
{
    Console.WriteLine($"jour: {j}");
    bool choixValide = false;

    while (!choixValide)
    {
        Console.WriteLine("Voulez-vous planter un semis ?");
        Console.WriteLine("Appuyez sur 1 pour OUI, 2 pour NON :");

        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
        char touche = keyInfo.KeyChar;

        if (touche == '1')
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
                                Console.WriteLine("\nVous avez choisi de planter de ma Coca");
                                choix3Valide = true;
                                semisCoca.Add(new Coca());
                                terrainsTerre[numeroTerrain].AjouterPlante(semisCoca[0]);
                                semisCoca.RemoveAt(0);
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
                                affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                            }
                            else if (touche3 == '2')
                            {
                                Console.WriteLine("\nVous avez choisi de planter du Canabis");
                                choix3Valide = true;
                                semisCannabis.Add(new Cannabis());
                                terrainsSableux[numeroTerrain].AjouterPlante(semisCannabis[0]);
                                semisCannabis.RemoveAt(0);
                                affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                            }
                            else if (touche3 == '3')
                            {
                                Console.WriteLine("\nVous avez choisi de planter du Pavot");
                                choix3Valide = true;
                                semisPavots.Add(new Pavot());
                                terrainsSableux[numeroTerrain].AjouterPlante(semisPavots[0]);
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
                                affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                            }
                            else if (touche3 == '2')
                            {
                                Console.WriteLine("\nVous avez choisi de planter du Canabis");
                                choix3Valide = true;
                                semisCannabis.Add(new Cannabis());
                                terrainsArgiles[numeroTerrain].AjouterPlante(semisCannabis[0]);
                                semisCannabis.RemoveAt(0);
                                affichage.AfficherTerrain(terrainsTerre[numeroTerrain]);
                            }
                            else if (touche3 == '3')
                            {
                                Console.WriteLine("\nVous avez choisi de planter du Pavot");
                                choix3Valide = true;
                                semisPavots.Add(new Pavot());
                                terrainsArgiles[numeroTerrain].AjouterPlante(semisPavots[0]);
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
                else
                {
                    Console.WriteLine("\nSaisie invalide.");
                }
            }
        }
        else if (touche == '2')
        {
            Console.WriteLine("\nVous avez choisi de ne rien faire.");
            choixValide = true;
        }
        else
        {
            Console.WriteLine("\nSaisie invalide. Veuillez appuyer sur 1 pour OUI ou 2 pour NON.");
        }
    }
    
}

for (int i = 0; i < 6; i++)
{
    semisPavots.Add(new Pavot());
}

for (int i = 0; i < semisPavots.Count; i++)
{
    Console.WriteLine($"Semis #{i + 1}");
}

for (int i = 0; i < 3; i++)
{
    terrainsArgiles[0].AjouterPlante(semisPavots[0]);
    semisPavots.RemoveAt(0);
}

for (int i = 0; i < 2; i++)
{
    terrainsTerre[0].AjouterPlante(semisPavots[0]);
    semisPavots.RemoveAt(0);
}
