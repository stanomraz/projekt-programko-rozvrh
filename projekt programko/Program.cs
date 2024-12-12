//nacitanie rozvrhu z textaku
StreamReader ATrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAT.txt");
StreamReader AIrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAI.txt");
StreamReader AMrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAM.txt");
StreamReader AErozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAE.txt");

//inicializovanie poli listov stringov
List<string>[] ATrozvrh = new List<string>[5];
List<string>[] AIrozvrh = new List<string>[5];
List<string>[] AMrozvrh = new List<string>[5];
List<string>[] AErozvrh = new List<string>[5];

//pridanie listu stringov do indexu pola
for (int i = 0; i < ATrozvrh.Length; i++)
    ATrozvrh[i] = new List<string>();

for (int i = 0; i < AIrozvrh.Length; i++)
    AIrozvrh[i] = new List<string>();

for (int i = 0; i < AMrozvrh.Length; i++)
    AMrozvrh[i] = new List<string>();

for (int i = 0; i < AErozvrh.Length; i++)
    AErozvrh[i] = new List<string>();

//precitanie suborov a ulozenie do listov
int riadok = 0;
while (true)
{
    string obsah = ATrozvrhReader.ReadLine();



    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');

    for (int i = 0; i < poleRiadku.Length; i++)
    {
        ATrozvrh[riadok].Add(poleRiadku[i]);
    }

    riadok++;
}

riadok = 0;
while (true)
{
    string obsah = AIrozvrhReader.ReadLine();



    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');

    for (int i = 0; i < poleRiadku.Length; i++)
    {
        AIrozvrh[riadok].Add(poleRiadku[i]);
    }

    riadok++;
}

riadok = 0;
while (true)
{
    string obsah = AMrozvrhReader.ReadLine();



    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');

    for (int i = 0; i < poleRiadku.Length; i++)
    {
        AMrozvrh[riadok].Add(poleRiadku[i]);
    }

    riadok++;
}

riadok = 0;
while (true)
{
    string obsah = AErozvrhReader.ReadLine();



    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');

    for (int i = 0; i < poleRiadku.Length; i++)
    {
        AErozvrh[riadok].Add(poleRiadku[i]);
    }

    riadok++;
}

//koniec prace so streamreaderom
ATrozvrhReader.Close();
AIrozvrhReader.Close();
AMrozvrhReader.Close();
AErozvrhReader.Close();

//program s vypisom
while (true)
{
    Console.WriteLine("Zadaj triedu (at/ai/am/ae):");
    string zvolenaTrieda = Console.ReadLine();

    if (zvolenaTrieda != "at" && zvolenaTrieda != "ai" && zvolenaTrieda != "am" && zvolenaTrieda != "ae")
    {
        Console.WriteLine("zadal si zlu moznost - program konci");
        Thread.Sleep(2000);
        break;
    }


    Console.WriteLine("Zadaj den (po/ut/st/št/pi):");
    string zvolenyDen = Console.ReadLine();

    if (zvolenyDen != "po" && zvolenyDen != "ut" && zvolenyDen != "st" && zvolenyDen != "št" && zvolenyDen != "pi")
    {
        Console.WriteLine("zadal si zlu moznost - program konci");
        Thread.Sleep(2000);
        break;
    }


    Console.WriteLine("Zadaj hodinu (1-8):");
    int zvolenaHodina = Convert.ToInt32(Console.ReadLine());

    if (zvolenaHodina <= 0 || zvolenaHodina > 8)
    {
        Console.WriteLine("zadal si zlu moznost - program konci");
        Thread.Sleep(2000);
        break;
    }

    int indexDna = 0;
    if (zvolenyDen == "po")
    {
        indexDna = 0;
    }
    else if (zvolenyDen == "ut")
    {
        indexDna = 1;
    }
    else if (zvolenyDen == "st")
    {
        indexDna = 2;
    }
    else if (zvolenyDen == "št")
    {
        indexDna = 3;
    }
    else if (zvolenyDen == "pi")
    {
        indexDna = 4;
    }


    if (zvolenaTrieda == "at")
    {
        Console.WriteLine("...");
        for (int i = 0; i < ATrozvrh.Length; i++)
        {
            string output = "";
            for (int j = 0; j < ATrozvrh[i].Count; j++)
            {
                output += ATrozvrh[i][j] + ";";
            }
            Console.WriteLine(output.TrimEnd(';'));
        }
        Console.WriteLine("...");
        Console.WriteLine(ATrozvrh[indexDna][zvolenaHodina - 1]);
    }
    else if (zvolenaTrieda == "ai")
    {
        Console.WriteLine("...");
        for (int i = 0; i < AIrozvrh.Length; i++)
        {
            string output = "";
            for (int j = 0; j < AIrozvrh[i].Count; j++)
            {
                output += AIrozvrh[i][j] + ";";
            }
            Console.WriteLine(output.TrimEnd(';'));
        }
        Console.WriteLine("...");
        Console.WriteLine(AIrozvrh[indexDna][zvolenaHodina - 1]);
    }
    else if (zvolenaTrieda == "am")
    {
        Console.WriteLine("...");
        for (int i = 0; i < AMrozvrh.Length; i++)
        {
            string output = "";
            for (int j = 0; j < AMrozvrh[i].Count; j++)
            {
                output += AMrozvrh[i][j] + ";";
            }
            Console.WriteLine(output.TrimEnd(';'));
        }
        Console.WriteLine("...");
        Console.WriteLine(AMrozvrh[indexDna][zvolenaHodina - 1]);
    }
    else if (zvolenaTrieda == "ae")
    {
        Console.WriteLine("...");
        for (int i = 0; i < AErozvrh.Length; i++)
        {
            string output = "";
            for (int j = 0; j < AErozvrh[i].Count; j++)
            {
                output += AErozvrh[i][j] + ";";
            }
            Console.WriteLine(output.TrimEnd(';'));
        }
        Console.WriteLine("...");
        Console.WriteLine(AErozvrh[indexDna][zvolenaHodina - 1]);
    }

    Console.ReadKey();
}