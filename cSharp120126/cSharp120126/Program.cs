using cSharp120126.Factories;

Console.WriteLine("Bienvenu dane le programme ");
string choix = "9";
while (choix != "0")
{
    Console.WriteLine("Faitez votre choix entre :\n" +
        "1. Gérer les Clients\n" +
        "2. Gérer les Voyages\n" +
        "3. Gérer les Réservations \n" +
        "0. Quitter\n");
    Console.Write("Mettez votre choix ==> ");
    choix = Console.ReadLine();
    switch (choix)
    {
        case "1":
            Console.WriteLine("Gestion");
            string choixClient = "9";
            while (choixClient != "0")
            {
                Console.WriteLine("Faitez votre choix entre :\n" +
                    "1. Ajouter un Client\n" +
                    "2. Modifier un Client\n" +
                    "3. Supprimer un Client \n" +
                    "4. Afficher tous les clients\n" +
                    "0. Quitter\n");
                Console.Write("Mettez votre choix ==> ");
                choixClient = Console.ReadLine();
                switch (choixClient)
                {
                    case "1":
                        Console.WriteLine("Clients");
                        Console.Write("Mettez le nom de client ==> ");
                        string nom = Console.ReadLine() ?? string.Empty;
                        Console.Write("Mettez le prenom de client ==> ");
                        string prenom = Console.ReadLine() ?? string.Empty;
                        ClientFactory.CreateClient(nom, prenom);
                        break;
                    case "2":
                        Console.WriteLine("Modification");
                        Console.Write("Mettez le id à modifier ==> ");
                        int uID = int.Parse(Console.ReadLine());
                        Console.Write("Mettez le nouveau nom ==> ");
                        nom = Console.ReadLine() ?? string.Empty;
                        Console.Write("Mettez le nouveau prénom ==> ");
                        prenom = Console.ReadLine() ?? string.Empty;
                        ClientFactory.UpdateClient(uID, prenom, nom);
                        break;
                    case "3":
                        Console.WriteLine("Suppression");
                        Console.Write("Mettez le id à modifier ==> ");
                        uID = int.Parse(Console.ReadLine());
                        ClientFactory.DeleteClient(uID);
                        break;
                    case "4":
                        Console.WriteLine(ClientFactory.DisplayAllClients());
                        break;
                    case "0":
                        Console.WriteLine("Retour");
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            }
                break;
        case "2":
                    Console.WriteLine("Voyages");
                    string choixVoyages = "9";
                    while (choixVoyages != "0")
                    {
                        Console.WriteLine("Faitez votre choix entre :\n" +
                            "1. Ajouter un Voyage\n" +
                            "2. Modifier un Voyage\n" +
                            "3. Supprimer un Voyage \n" +
                            "0. Quitter\n");
                        Console.Write("Mettez votre choix ==> ");
                        choixVoyages = Console.ReadLine();
                        switch (choixVoyages)
                        {
                            case "1":
                                Console.WriteLine("Ajout");
                                break;
                            case "2":
                                Console.WriteLine("Modification");
                                break;
                            case "3":
                                Console.WriteLine("Suppression");
                                break;
                            case "0":
                                Console.WriteLine("Retour");
                                choix = "9";
                                break;
                            default:
                                Console.WriteLine("Choix invalide");
                                break;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Reservations");
                    string choixReservations = "9";
                    while (choixReservations != "0")
                    {
                        Console.WriteLine("Faitez votre choix entre :\n" +
                            "1. Ajouter une Reservation\n" +
                            "2. Modifier une Reservation\n" +
                            "3. Supprimer une Reservation \n" +
                            "0. Quitter\n");
                        Console.Write("Mettez votre choix ==> ");
                        choixVoyages = Console.ReadLine();
                        switch (choixReservations)
                        {
                            case "1":
                                Console.WriteLine("Ajout");
                                break;
                            case "2":
                                Console.WriteLine("Modification");
                                break;
                            case "3":
                                Console.WriteLine("Suppression");
                                break;
                            case "0":
                                Console.WriteLine("Retour");
                                choix = "9";
                                break;
                            default:
                                Console.WriteLine("Choix invalide");
                                break;
                        }
                    }
                    break;
                case "0":
                    Console.WriteLine("Aurevoir");
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
                }
            };