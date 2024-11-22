StreamReader ATrozvrhReader = new StreamReader("");
StreamReader AIrozvrhReader = new StreamReader("");
StreamReader AMrozvrhReader = new StreamReader("");
StreamReader AErozvrhReader = new StreamReader("");

//zistit ako funguje streamreader

List<string> ATrozvrh = new List<string>();
List<string> AIrozvrh = new List<string>();
List<string> AMrozvrh = new List<string>();
List<string> AErozvrh = new List<string>();

//vytvorit 20 listov pre kazdy den pre kazdu triedu??

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
