StreamReader ATrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAT.txt");
StreamReader AIrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAI.txt");
StreamReader AMrozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAM.txt");
StreamReader AErozvrhReader = new StreamReader(@"/Users/rechtphl/Documents/skola spsit/remis programko/projekt programko/projekt-programko-rozvrh/projekt programko/rozvrhAE.txt");



List<List<string>> ATrozvrh = new List<List<string>>();
List<List<string>> AIrozvrh = new List<List<string>>();
List<List<string>> AMrozvrh = new List<List<string>>();
List<List<string>> AErozvrh = new List<List<string>>();


while (true)
{
    string obsah = ATrozvrhReader.ReadLine();
    int riadok = 0;



    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');

    for (int i = 0; i < poleRiadku.Length; i++)
    {
        if (ATrozvrh.Count <= riadok)
        {
            ATrozvrh.Add(new List<string>());
        }
        while (ATrozvrh[riadok].Count <= i)
        {
            ATrozvrh[riadok].Add("");
        }
        ATrozvrh[riadok][i] = poleRiadku[i];
    }

    riadok++;
}

/*
while (true)
{
    string obsah = AIrozvrhReader.ReadLine();
    int riadok = 0;

    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');
    for (int i = 0; i < poleRiadku.Length; i++)
    {
        AIrozvrh[riadok][i] = poleRiadku[i];
    }

    riadok++;
}

while (true)
{
    string obsah = AMrozvrhReader.ReadLine();
    int riadok = 0;

    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');
    for (int i = 0; i < poleRiadku.Length; i++)
    {
        AMrozvrh[riadok][i] = poleRiadku[i];
    }

    riadok++;
}

while (true)
{
    string obsah = AErozvrhReader.ReadLine();
    int riadok = 0;

    if (obsah == null)
    {
        break;
    }

    string[] poleRiadku = obsah.Split(';');
    for (int i = 0; i < poleRiadku.Length; i++)
    {
        AErozvrh[riadok][i] = poleRiadku[i];
    }

    riadok++;
}
*/

ATrozvrhReader.Close();
AIrozvrhReader.Close();
AMrozvrhReader.Close();
AErozvrhReader.Close();


while (true)
{
    Console.WriteLine("Zadaj triedu (at/ai/am/ae):");
    string zvolenaTrieda = Console.ReadLine();
    Console.WriteLine("Zadaj den (po/ut/st/št/pi):");
    string zvolenyDen = Console.ReadLine();
    Console.WriteLine("Zadaj hodinu (1-7):");
    int zvolenaHodina = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < ATrozvrh.Count; i++)
    {
        Console.WriteLine(ATrozvrh[i]);
    }

    //s ifkami spravit pristup ku konkretnym datam


    Console.ReadKey();
}