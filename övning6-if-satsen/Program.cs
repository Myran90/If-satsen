using System;

namespace övning6_if_satsen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kontrollera värdet (del 1)
            Skapa ett program som ställer frågan ”Är det fint väder?”.
            Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”.
            Annars händer ingenting.*/
            Console.Write("Är det fint väder? ( j/n )");
            while (true)
            {
            string svar = Console.ReadLine();
            if (svar == "j" || svar=="J")
            {
                Console.Write("Då går vi och tar en picknick!");
                break;
            }
            /*Kontrollera värdet (del 2)
            Arbeta vidare på övningen ovanför men lägg till att användaren kan
            svara ”n”. Då skriver programmet ut ”Vi stannar inne och läser en bok”.
            Det ska inte spela någon roll om användaren matar in stor eller liten bokstav.
            */
            else if (svar == "n" || svar =="N" )
            {
                Console.Write("Vi stannar inne och läser en bok istället!");
                break;
            }
            /*Kontrollera värdet (del 3)
            Arbeta vidare på övningen. Gör så att om användaren matar in något annat
            än ”J”, ”j”, ”n”, ”N” så skriver programmet ut ”Jag förstår inte!”. */
            else
            {
                Console.Write("Förstod inte ditt svar. Svara med (j/n eller J/N):");
            }
        }
    }
}
}