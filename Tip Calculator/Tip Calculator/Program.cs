using System;


namespace Tip_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the special signs as they are
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Guten Tag!");
            Console.WriteLine("Liegt eine Rechnung vor Ihnen und Sie wissen nicht wie viel Tipp Sie geben sollten?");
            Console.WriteLine("Ich werde Ihnen jetzt helfen.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Was ist der Preis auf der Rechnung?: ");
            string price = Console.ReadLine();
            //If the user uses "." instead of "," , change it not to have a wrong calculation
            string newPrice = price.Replace(".", ",");
            //Convert the price into double to make calculations
            double latestPrice = Convert.ToDouble(newPrice);
            Console.Write("Wie viel Prozent Tipp möchten Sie geben?: ");
            int percentage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele Personen werden den Tipp teilen?: ");
            int people = Convert.ToInt32(Console.ReadLine());
            //Calculate the tip and show the price with max 2 numbers after comma
            Double result = Math.Round(((latestPrice * percentage / 100) / people), 2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Das ist aber einfach!");
            Console.WriteLine("Jeder sollte " + result + "€ Tipp geben.");
            Console.WriteLine("Kann ich für Sie noch was tun [j / n]?");
            
            string answer = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.Green;
            string messageJa = "Ich wollte nur höflich sein. Ich bin ein Single-Purpose Program. Auf Wiedersehen!";
            string messageNein = "Ich wünsche Ihnen alles Gute.";
            //If answer is not j, then show the messageNein; else, show the messageJa
            Console.WriteLine((answer != "J") ? messageNein : messageJa);
            Console.ReadLine();
        }
    }
}
