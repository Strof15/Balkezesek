







using _2023._05._25;


internal class prog {

    static  List<Jatekos> balkezeseklista = new List<Jatekos>();

    static void Main(string[] args)
    {
        Beolvasas();
        negyedik();
        otodik();   
    }



    static void Beolvasas()
    {
        
            StreamReader sor = new StreamReader("balkezesek.csv");
            sor.ReadLine();
            while (!sor.EndOfStream)
            {
                string[] adatok = sor.ReadLine().Split(";");
                balkezeseklista.Add(new Jatekos(adatok[0], adatok[1], adatok[2], int.Parse(adatok[3]), int.Parse(adatok[4])));
            }

            Console.WriteLine($"2. feladat: {balkezeseklista.Count}");
           
      

    }

    static void negyedik()
    {
        //1inch=2,54cm
        Console.WriteLine("4. feladat:");
        foreach (var i in balkezeseklista)
        {
            if (i.Utolso.Contains("1999-10"))
            {
                Console.WriteLine($"\t{i.Nev}, {Math.Round(i.Magassag * 2.54),1}cm");
            }
        }
    }


    static void otodik()
    {
        while (true)
        {
            Console.WriteLine("5. feladat:");
            Console.Write("Írjon be egy 1990 és 1999 közötti évszámot!");
            int  bekertadat = int.Parse(Console.ReadLine());
            if (bekertadat >= 1990 && bekertadat <= 1999)
            {
                break;
            }
            else
            {
                Console.WriteLine("Hibás adat! Kérek egy 1990 és 1999 közötti számot!");
            }
        }
    }


}






