namespace sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slova = System.IO.File.ReadAllLines("TextFile1.txt");

            Random slovo = new Random();

            string vybraneSlovo = slova[slovo.Next(slova.Length)].ToLower();

            char[] vybraneSlovoPismena = vybraneSlovo.ToCharArray();

            char[] podtrzitka = new string('_', vybraneSlovo.Length).ToCharArray();

            int pokusy = 6;

            while (pokusy > 0 && podtrzitka.Contains('_'))
            {
                Console.WriteLine(podtrzitka);

                char hrac = Console.ReadLine().ToLower()[0];

                if (vybraneSlovoPismena.Contains(hrac))
                {
                    for (int i = 0; i < vybraneSlovoPismena.Length; i++)
                    {
                        if (vybraneSlovoPismena[i] == hrac)
                        {
                            podtrzitka[i] = hrac
                            ;
                        }
                    }
                    Console.WriteLine("Uhodl jsi písmeno!");

                }
                else
                {
                    pokusy--;
                    Console.WriteLine($"Špatně! Zbývá ti {pokusy} pokusů.");
                }
                if (!podtrzitka.Contains('_'))
                {
                    Console.WriteLine("Vyhrál jsi!");
                    break;
                }
                else if (pokusy == 0)
                {
                    Console.WriteLine($"Prohrál jsi! Správné slovo bylo: {vybraneSlovo}");
                    break;
                }


            }
            




        }
    }
}
