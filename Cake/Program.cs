namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tort vibor = new tort();
            Console.WriteLine("Соберите торт на своё усмотрение");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            int position = 2;
            ConsoleKeyInfo clavisha = Console.ReadKey();
            Console.Clear();
            while (clavisha.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Соберите торт на своё усмотрение");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("  Форма");
                Console.WriteLine("  Размер");
                Console.WriteLine("  Вкус");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine("Ваш Заказ:");
                foreach(string i in vibor.zakaziks)
                {
                    Console.Write(i + ",");
                }
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
               

                if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите:");
                    Console.WriteLine("  Круг - 500");
                    Console.WriteLine("  Квадрат - 600");
                    Console.WriteLine("  Прямоугольник - 700");
                    Console.WriteLine("  Сердечко - 800");
                    position = 2;
                    clavisha = Console.ReadKey();
                    while (clavisha.Key != ConsoleKey.Escape)
                    {

                        
                        Console.Clear();
                        Console.WriteLine("Выберите:");
                        Console.WriteLine("  Круг - 500");
                        Console.WriteLine("  Квадрат - 600");
                        Console.WriteLine("  Прямоугольник - 700");
                        Console.WriteLine("  Сердечко - 800");



                        if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(1);
                        }
                        if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(6);

                        }
                        if (position == 4 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(10);
                        }
                        if (position == 5 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(13);
                            break;

                        }

                        if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                       

                    }
                }
                if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите");
                    Console.WriteLine("  Маленкий(8 порций) - 1000");
                    Console.WriteLine("  Средний(10 порций) - 1200");
                    Console.WriteLine("  Большой(12 порций) - 1500");
                    position = 2;
                    clavisha = Console.ReadKey();

                    while (clavisha.Key != ConsoleKey.Escape)

                    {
                        Console.Clear();
                        Console.WriteLine("Выберите");
                        Console.WriteLine("  Маленкий(8 порций) - 1000");
                        Console.WriteLine("  Средний(10 порций) - 1200");
                        Console.WriteLine("  Большой(12 порций) - 1500");
                        if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }
                        if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(14);
                        }
                        if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(17);
                        }
                        if (position == 4 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(18);

                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                        Console.Clear();
                    }
                }
                if (position == 4 && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите:");
                    Console.WriteLine("  Ваниль - 500");
                    Console.WriteLine("  Клубничный - 600");
                    Console.WriteLine("  Малина - 1000");
                    position = 2;
                    clavisha = Console.ReadKey();
                    while (clavisha.Key != ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите:");
                        Console.WriteLine("  Ваниль - 500");
                        Console.WriteLine("  Клубничный - 600");
                        Console.WriteLine("  Малина - 1000");
                        if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }

                        if (position == 1 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(2);
                        }
                        if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(7);
                        }
                        if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(15);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                        Console.Clear();
                    }
                }
                if (position == 5 && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите:");
                    Console.WriteLine("  1 корж - 500");
                    Console.WriteLine("  2 коржа - 600");
                    Console.WriteLine("  3 коржа- 700");
                    Console.WriteLine("  4 коржа и больше - 1500");
                    position = 2;
                    clavisha = Console.ReadKey();

                    while (clavisha.Key != ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите:");
                        Console.WriteLine("  1 корж - 500");
                        Console.WriteLine("  2 коржа - 600");
                        Console.WriteLine("  3 коржа- 700");
                        Console.WriteLine("  4 коржа и больше - 1500");
                        if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }


                        if (position == 1 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(3);
                        }
                        if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(8);
                        }
                        if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(11);
                        }
                        if (position == 4 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(19);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                    }
                    
                }
                if (position == 6 && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите:");
                    Console.WriteLine("  Без глазури - 0");
                    Console.WriteLine("  Белая - 500");
                    Console.WriteLine("  Розовая - 600");
                    position = 2;
                    clavisha = Console.ReadKey();

                    while (clavisha.Key != ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите:");
                        Console.WriteLine("  Без глазури - 0");
                        Console.WriteLine("  Белая - 500");
                        Console.WriteLine("  Розовая - 600");
                        if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }

                        if (position == 1 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(0);
                        }
                        if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(4);
                        }
                        if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(9);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                    }
                   
                }
                if (position == 7 && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите:");
                    Console.WriteLine("  Ваш декор(готовый проект) - 500");
                    Console.WriteLine("  Наш готовый декор - 700");
                    Console.WriteLine("  Совсместное составление декора - 1000");
                    position = 2;
                    clavisha = Console.ReadKey();

                    while (clavisha.Key != ConsoleKey.Escape)

                    {
                        Console.Clear();
                        Console.WriteLine("Выберите:");
                        Console.WriteLine("  Ваш декор(готовый проект) - 500");
                        Console.WriteLine("  Наш готовый декор - 700");
                        Console.WriteLine("  Совсместное составление декора - 1000");
                        if (clavisha.Key == ConsoleKey.DownArrow)
                        {
                            position++;
                        }
                        if (clavisha.Key == ConsoleKey.UpArrow)
                        {
                            position--;
                        }
                        if (position == 1 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(5);
                        }
                        if (position == 2 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(12);
                        }
                        if (position == 3 && clavisha.Key == ConsoleKey.Enter)
                        {
                            vibor.Zakaz(16);
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        clavisha = Console.ReadKey();
                    }
                   
                }
                if (position == 8 && clavisha.Key == ConsoleKey.Enter)
                {
                   vibor.Zakaz(20);
                   
                }

                Console.SetCursorPosition(0,position);
                Console.WriteLine("->");
                
                clavisha = Console.ReadKey();
                Console.Clear();
            }
        }
    }
}