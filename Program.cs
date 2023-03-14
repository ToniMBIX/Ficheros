using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "tecleado.txt";
        int numLinesToRead = 20;
        
        try
        {
            using (StreamReader reader = File.OpenText(fileName))
            {
                string line;
                int linesRead = 0;

                while ((line = reader.ReadLine()) != null && linesRead < numLinesToRead)
                {
                    Console.WriteLine(line);
                    linesRead++;
                }

                reader.Close();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Error al leer el fichero: " + e.Message);
        }

        Console.ReadLine();
    }
}
