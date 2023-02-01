namespace Task2;
class Program
    {

    /*Створити програмно каталог на диску. В ньому
    підкаталог. Помістити в підкаталог якийсь файл. Вивести на консоль всі
    каталоги і підкаталоги.*/
    static void Main(string[] args)
        {
        string path = "/Users/bugay/test"
        string subpath = "/testDir";
        string fileName = "/HelloWorld";
        if (!Directory.Exists(path))
            {
            Directory.CreateDirectory(path);
            }
        Directory.CreateDirectory(path + subpath);
        for (int i = 0; i < 10; i++)
            {
            File.Create(path + subpath + fileName+i+".txt");
            }
        Console.WriteLine("Каталоги\n" + path + "\nПідкаталог");
        string[] dirs = Directory.GetDirectories(path);
        foreach (string d in dirs)
            {
            Console.WriteLine(d);
            }
        
        }
    }

