namespace Task5;
class Program
    {
    //Видалити каталог, створений у завд. 2.
    static void Main(string[] args)
        {
        string dirPath = "/Users/bugay/test/";
        DirectoryInfo dir = new DirectoryInfo(dirPath);
        if (dir.Exists)
            {
            dir.Delete(true);
            Console.WriteLine("Видалено");
            }
        else
            {
            Console.WriteLine("Каталог не знайдено");
            }
        }
    }

