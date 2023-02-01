namespace Task1;
class Program
    {
    //Вивести на консоль імена та властивості всіх дисків на компʼютері.
    static void Main(string[] args)
        {
        DriveInfo[] drivers = DriveInfo.GetDrives();//Створюємо масив обʼєктів класу driveInfo
        foreach (DriveInfo drive in drivers)//Проходимо циклом по всім дискам
            {
            Console.WriteLine($"Назва: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
                {
                Console.WriteLine($"Обʼєм: {drive.TotalSize}");
                Console.WriteLine($"Вільне місце: {drive.TotalFreeSpace}");
                Console.WriteLine($"Мітка диску: {drive.VolumeLabel}");
                }
            Console.WriteLine("--------------------");
            }
        }
    }

