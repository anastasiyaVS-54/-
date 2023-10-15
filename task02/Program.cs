//  Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

// System.Console.WriteLine("Введите число от 1 до 7: ");
// int daynumber = Convert.ToInt32(Console.ReadLine());

// string dayweek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// string numberd = { "1", "2", "3", "4", "5", "6", "7" };

// if (daynumber[] == dayweek[])
// {
//     System.Console.WriteLine("YES");
// }
// else
// {
//     System.Console.WriteLine("NO");
// }


 Console.Write("Введите номер дня недели (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            string dayName = daysOfWeek[dayNumber - 1];
            Console.WriteLine($"День недели под номером {dayNumber} - это {dayName}.");
        }
        else
        {
            Console.WriteLine("Некорректный номер дня недели. Введите число от 1 до 7.");
        }