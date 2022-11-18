
void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"Введите товар который вы хотите купить");
    Console.WriteLine($"1) Телевизор");
    Console.WriteLine($"2) холодильник");
    Console.WriteLine($"3) микровалновка");
    Console.WriteLine($"4) кофеварка");
    Console.WriteLine();
}
void GetMenu()
{
    DateTime date = DateTime.Now;
    while (true)
    {
        Menu();
        string enter = Console.ReadLine();
        bool check = int.TryParse(enter, out int result);
        if (check == true)
        {
            if (result == 1)
            {
                Console.WriteLine($"Ваш товар будет доставлен через неделю");
                var newDate = date.AddDays(7);
                Console.WriteLine(newDate.ToShortDateString());
            }
            else if (result == 2)
            {
                Console.WriteLine($"Ваш товар будет доставлен через неделю");
                var newDate = date.AddDays(7);
                Console.WriteLine(newDate.ToShortDateString());
            }
            else if (result == 3)
            {
                Console.WriteLine($"Ваш товар будет доставлен через неделю");
                var newDate = date.AddDays(7);
                Console.WriteLine(newDate.ToShortDateString());
            }
            else if (result == 4)
            {
                Console.WriteLine($"Ваш товар будет доставлен через неделю");
                var newDate = date.AddDays(7);
                Console.WriteLine(newDate.ToShortDateString());
            }
            else { Console.WriteLine($"Введите пункт из меню"); }
        }
        else
        {
            Console.WriteLine($"Введите пункт из меню");
        }
    }
}
GetMenu();