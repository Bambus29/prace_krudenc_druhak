namespace kamen_nuzky_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moznosti = { "kámen", "nůžky", "papír" };

            Console.WriteLine("Vyber si kámen, nůžky nebo papír");
            string uzivatel = Console.ReadLine().ToLower();
            
            Random program = new Random();

            string pocitac = moznosti[program.Next(moznosti.Length)]; // náhodný výběr počítače

            while (true)
            {
                while (uzivatel != "kámen" && uzivatel != "nůžky" && uzivatel != "papír")
                {
                    Console.WriteLine("Neplatná volba, zkus to znovu.");
                    uzivatel = Console.ReadLine().ToLower();
                }

                Console.WriteLine($"Počítač si vybral: {pocitac}");

                if (pocitac == "kámen" && uzivatel == "nůžky" ||
                     pocitac == "nůžky" && uzivatel == "papír" ||
                     pocitac == "papír" && uzivatel == "kámen")
                {
                    Console.WriteLine("Prohrál jsi!");
                    
                }
                else if (pocitac == "kámen" && uzivatel == "papír" ||
                          pocitac == "nůžky" && uzivatel == "kámen" ||
                          pocitac == "papír" && uzivatel == "nůžky")
                {
                    Console.WriteLine("Vyhrál jsi!");
                    
                }
                else
                {
                    Console.WriteLine("Remíza!");
                    
                }
                Console.WriteLine("Chceš hrát znovu? (ano/ne)");
                string znovu = Console.ReadLine().ToLower();
                if (znovu == "ano")
                {
                    Console.WriteLine("Vyber si kámen, nůžky nebo papír");
                    uzivatel = Console.ReadLine().ToLower();
                    pocitac = moznosti[program.Next(moznosti.Length)];
                }
                else
                {
                    break;
                }
            }


        }
    }
}
