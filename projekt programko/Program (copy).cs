StreamReader ATrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko");


List<List<string>> ATrozvrh = new List<List<string>>();



while(true)
{
    string obsah = ATrozvrhReader.ReadLine();

    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');
    ATrozvrh.Add(new List<string> (poleRiadku[0]));
    ATrozvrh.Add(new List<string> );
    ATrozvrh.Add(new List<string> );
    ATrozvrh.Add(new List<string> );
    ATrozvrh.Add(new List<string> );
}


/*
while (true)
{
    Console.WriteLine("Zadaj triedu (at/ai/am/ae):");
    string zvolenaTrieda = Console.ReadLine();
    Console.WriteLine("Zadaj den (po/ut/st/št/pi):");
    string zvolenyDen = Console.ReadLine();
    Console.WriteLine("Zadaj hodinu (1-7):");
    int zvolenaHodina = Convert.ToInt32(Console.ReadLine());



    Console.ReadKey();
}

*/

