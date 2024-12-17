using System;

class Program
{
    static void Main(string[] args)
    {
        // Appeler la procédure pour déclarer et initialiser le tableau
        DeclarerEtInitialiserTableau();
    }

    static void DeclarerEtInitialiserTableau()
    {
        // Déclaration et initialisation du tableau
        int[] notes = new int[4] { 15, 18, 12, 20 };

        // Affichage des notes
        Console.WriteLine("Les notes sont :");
        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine($"Note {i + 1} : {notes[i]}");
        }
    }
}

