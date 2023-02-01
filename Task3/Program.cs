namespace Task3;
class Program
{
    /*Вибрати каталог на своєму диску.Вивести на консоль всі файли з
    розширенням*.exe*/

    static void Main(string[] args)
    {
        string path = "/Users/bugay/test/testDir/";
        Console.WriteLine("Файли");
        string[] files = Directory.GetFiles(path, "*.exe");
        foreach (string f in files)
            {
            Console.WriteLine(f);
            }
        }
}

