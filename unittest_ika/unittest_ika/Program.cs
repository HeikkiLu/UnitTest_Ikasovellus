using System;
// Tekijä: Heikki Luukkonen
namespace unittest_ika
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ika;
            Console.WriteLine("Kerro ikäsi: ");
            ika = Console.ReadLine();
            ikatsek ikatsek = new ikatsek();
            Console.WriteLine(ikatsek.Aloitus(ika));
            Console.ReadKey();
        }
    }
    public class ikatsek
    {
        public string Aloitus(string syote)
        {
            try
            {
                int ika = int.Parse(syote);
                return Ika(ika);
            }
            catch (FormatException)
            {
                return "Virheellinen syöte, syötteen tulee sisältää vain numeroita.";
            }
        }
        public string Ika(int ika)
        {
            string lapsi = "Olet lapsi";
            string aikuinen = "Olet aikuinen";
            string elakelainen = "Olet eläkeläinen";

            if (ika >= 70)
            {
                return elakelainen;
            }
            else if (ika <= 70 && ika >= 18)
            {
                return aikuinen;
            }
            else if (ika <= 18 && ika >= 0)
            {
                return lapsi;
            }
            else
            {
                return "Syötetty arvo oli virheellinen.";
            }
        }
    }
}