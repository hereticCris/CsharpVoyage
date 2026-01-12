using cSharp120126.Struct;

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
            break;
        case "2":
            Console.WriteLine("Voyages");
            break;
        case "3":
            Console.WriteLine("Resa");
            break;
        case "0":
            Console.WriteLine("Aurevoir");
            break;
        default:
            Console.WriteLine("Choix invalide");
            break;
    }
}