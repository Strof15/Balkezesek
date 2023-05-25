







using _2023._05._25;


internal class prog {

    static List<Jatekos> balkezeseklista = new List<Jatekos>();

    static void Main(string[] args)
    {
        Beolvasas();
        harmasfeladat();
    }



    static void Beolvasas()
    {
        StreamReader olvas = new StreamReader("balkezesek.csv");
        balkezeseklista.Skip(1);
        while (!olvas.EndOfStream)
        {
            string[] adatok = olvas.ReadLine().Split(';');
            balkezeseklista.Add(adatok[0], adatok[1], adatok[2], int.Parse(adatok[3]), int.Parse(adatok[4]));

        }



        olvas.Close();



    }
    static void harmasfeladat() 
    
    {
        Console.WriteLine(balkezeseklista.Count());
    }





}






