using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "tecleado.txt";

        StreamWriter file = new StreamWriter(fileName, false);

        string phrase;
        do
        {
            Console.Write("Introduce una frase (escribe 'off' para terminar): ");
            phrase = Console.ReadLine();

            if (phrase != "off")
            {
                file.WriteLine(phrase);
            }
        } while (phrase != "off");

        file.Close();

        Console.WriteLine("Se ha guardado el texto en el archivo " + fileName);
        Console.WriteLine("Pulsa una tecla para salir.");
        Console.ReadKey();
    }
}
