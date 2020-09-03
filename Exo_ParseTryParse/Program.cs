using System;

namespace Exo_ParseTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo1 - Parse
            //Console.WriteLine("Veuillez introduire un nombre :");
            //string number1 = Console.ReadLine();
            //int nb1 = int.Parse(number1);
            //Console.WriteLine("Veuillez introduire un second nombre :");
            //int nb2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Votre addition a pour résultat : {nb1 + nb2}");
            #endregion


            #region Exo2 - TryParse
            Console.WriteLine("Veuillez introduire un nombre :");
            bool tp;
            string number1 = Console.ReadLine();
            int nb1;
            tp = int.TryParse(number1, out nb1);
            Console.WriteLine("Veuillez introduire un second nombre :");
            int.TryParse(Console.ReadLine(), out int nb2);
            Console.WriteLine($"Votre addition a pour résultat : {nb1 + nb2}");
            #endregion
        }
    }
}
