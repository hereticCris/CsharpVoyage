Console.WriteLine("Bienvenu dane le programme ");
string choix = "9";
while (choix != "0" && choix != "1" && choix != "2" && choix != "3")
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
}
