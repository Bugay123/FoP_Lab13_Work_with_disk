namespace Task6;
class Program
    {
    /*Створити програмно каталог на диску і перемістити його в новий
    каталог.*/
    static void Main(string[] args)
        {
        string oldPath = "/Users/bugay/test/";
        string newPath = "/Users/bugay/test/test3/";
        if (!Directory.Exists(oldPath) && !Directory.Exists(newPath))
            {
            Directory.CreateDirectory(oldPath);
            Directory.Move(oldPath, newPath);
            Console.WriteLine("переміщено");
            }
        else
            {
            Console.WriteLine("Каталог не знайдено");
            }
        }

    }


