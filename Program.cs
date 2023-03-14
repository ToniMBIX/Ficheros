using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "C:/campions.txt";
        string anthem = "Himno random de un equipo random porqué necesito algo random que poner en el himno random, random";

        if (!File.Exists(fileName))
        {
            try
            {
                using (StreamWriter writer = File.CreateText(fileName))
                {
                    writer.WriteLine(anthem);
                    Console.WriteLine("Fichero creado y himno añadido.");
                    writer.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al crear el fichero: " + e.Message);
            }
        }
        else
        {
            try
            {
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine(anthem);
                    Console.WriteLine("Himno añadido.");
                    writer.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al añadir el himno al fichero: " + e.Message);
            }
        }

        Console.ReadLine(); // Esperamos a que el usuario presione Enter antes de salir
    }
}
