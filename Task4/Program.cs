namespace Task4;
class Program
    {
    //Вивести на консоль інформацію про вказаний каталог.

    static void Main(string[] args)
        {
        string dirPath = "/Users/bugay/test";
        DirectoryInfo dir = new DirectoryInfo(dirPath);
        if (dir.Exists)
            {
            Console.WriteLine($"Назва: {dir.Name}");
            Console.WriteLine($"Час створення: {dir.CreationTime}");
            Console.WriteLine($"Тип: {dir.Attributes}");
            Console.WriteLine($"Батьківський каталог: {dir.Root}");
            }
        else
            {
            Console.WriteLine("Каталог не знайдено");
            }
        }
    }

