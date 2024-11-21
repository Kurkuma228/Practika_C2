namespace HomeWork
{
    class File
    {
        public static int SumAndMulti(ref int multi, out double midarf, params int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            multi = 1;
            foreach (var item in array)
            {
                multi *= item;
            }
            midarf = array.Length > 0 ? sum / array.Length : 0;
            return sum;
        }
        public enum Level
        {
            low,
            medium,
            high
        }
        struct Ded
        {
            public string Name;
            public Level Grouch;
            public string[] Phrases;
            public int Bruises;
            public Ded(string name, Level grouch, string[] phrases)
            {
                Name = name;
                Grouch = grouch;
                Phrases = phrases;
                Bruises = 0;
            }
            public int CheckWords(params string[] badwords)
            {
                foreach (var badword in badwords)
                {
                    foreach(var phrase in Phrases)
                    {
                        if (phrase.Contains(badword))
                        {
                            Bruises++;
                        }
                    }
                }
                return Bruises;
            }
        }
        static void Digits(int num)
        {
            string[] pattern = new string[5];

            switch (num)
            {
                case 0:
                    pattern = new string[]
                    {
                    " ### ",
                    "#   #",
                    "#   #",
                    "#   #",
                    " ### "
                    };
                    break;
                case 1:
                    pattern = new string[]
                    {
                    "  #  ",
                    " ##  ",
                    "  #  ",
                    "  #  ",
                    "  #  "
                    };
                    break;
                case 2:
                    pattern = new string[]
                    {
                    "#### ",
                    "    #",
                    "  ## ",
                    " #   ",
                    " ####"
                    };
                    break;
                case 3:
                    pattern = new string[]
                    {
                    " ### ",
                    "    #",
                    "  ## ",
                    "    #",
                    " ### "
                    };
                    break;
                case 4:
                    pattern = new string[]
                    {
                    "#   #",
                    "#   #",
                    "#####",
                    "    #",
                    "    #"
                    };
                    break;
                case 5:
                    pattern = new string[]
                    {
                    "#####",
                    "#    ",
                    " ### ",
                    "    #",
                    " ### "
                    };
                    break;
                case 6:
                    pattern = new string[]
                    {
                    " ### ",
                    "#     ",
                    "####  ",
                    "#   # ",
                    " ### "
                    };
                    break;
                case 7:
                    pattern = new string[]
                    {
                    "#####",
                    "    #",
                    "   # ",
                    "  #  ",
                    "  #  "
                    };
                    break;
                case 8:
                    pattern = new string[]
                    {
                    " ### ",
                    "#   #",
                    " ### ",
                    "#   #",
                    " ### "
                    };
                    break;
                case 9:
                    pattern = new string[]
                    {
                    " ### ",
                    "#   #",
                    " #### ",
                    "    # ",
                    " ### "
                    };
                    break;
                default:
                    break;
            }
            foreach (var line in pattern)
            {
                Console.WriteLine(line);
            }
        }

        public static void Main(string[] args)
        {
            /*1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            которые нужно поменять местами. Вывести на экран получившийся массив.*/
            Console.WriteLine("1.Задание");
            byte[] bytes = new byte[20];
            Random rand = new Random();
            rand.NextBytes(bytes);
            foreach (byte b in bytes)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine("\nВведите два числа из вышеперечисленных");
            try
            {
                byte num1 = byte.Parse(Console.ReadLine());
                byte num2 = byte.Parse(Console.ReadLine());
                byte k = 0;

                int index1 = Array.IndexOf(bytes, num1);
                int index2 = Array.IndexOf(bytes, num2);

                if (index1 != -1 && index2 != -1)
                {
                    k = bytes[index1];
                    bytes[index1] = bytes[index2];
                    bytes[index2] = k;

                    foreach (byte b in bytes)
                    {
                        Console.Write(b + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Числа введены неверно");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Формат введен неверно");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число выходит за границы");
            }
            /*2. Написать метод, где в качества аргумента будет передан массив (ключевое слово
            params). Вывести сумму элементов массива(вернуть). Вывести(ref) произведение
            массива.Вывести(out) среднее арифметическое в массиве.*/
            Console.WriteLine("\n2.Задание");
            int[] massive = [1, 2, 3, 6, 2, 9, 50];
            int multi = 1;
            double midarf;
            Console.WriteLine($"Сумма = {SumAndMulti(ref multi, out midarf, massive)}");
            Console.WriteLine($"Умножение = {multi}\nСреднее арифметическое = {midarf}");

            /*3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать
            изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль
            должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если
            пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа
            завершает работу, если пользователь введёт слово: exit или закрыть (оба варианта
            должны сработать) - консоль закроется.*/
            Console.WriteLine("\n3.Задание");
            while (true)
            {
                try
                {
                    Console.Write("Введите цифру или exit для выхода: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
                    {
                        Console.WriteLine("Программа завершена");
                        break;
                    }

                    if (int.TryParse(input, out int num))
                    {
                        if (num >= 0 && num <= 9)
                        {
                            Digits(num);
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверно, число должно быть от 0 до 9");
                            Console.ResetColor();
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        throw new Exception("Введено не число");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    Thread.Sleep(3000);
                }
            }

            /*4. Создать структуру Дед. У деда есть имя, уровень ворчливости (перечисление), массив
            фраз для ворчания (прим.: “Проститутки!”, “Гады!”), количество синяков от ударов
            бабки = 0 по умолчанию. Создать 5 дедов. У каждого деда - разное количество фраз для
            ворчания. Напишите метод (внутри структуры), который на вход принимает деда,
            список матерных слов (params). Если дед содержит в своей лексике матерные слова из
            списка, то бабка ставит фингал за каждое слово. Вернуть количество фингалов.*/
            Console.WriteLine("\n4.Задание");
            Ded[] deds =
            [
                new Ded("Василий", Level.high, ["Черти!", "Вот молодеж!", "Идиоты!"]),
                new Ded("Алексей", Level.high, ["Проститутки!", "Балбесы!", "Дебилы!"]),
                new Ded("Александр", Level.medium, ["Как так можно!", "Дармоеды"]),
                new Ded("Сергей", Level.medium, ["Огузки!", "Вот новое поколение!"]),
                new Ded("Валера", Level.low, ["Молодцы", "Ужас"]),
            ];
            string[] badwords = ["Черти", "Идиоты", "Дебилы", "Проститутки", "Дармоеды", "Огузки"];
            foreach (Ded ded in deds)
            {
                int bruises = ded.CheckWords(badwords);
                Console.WriteLine($"{ded.Name} получил {bruises} фингалов(ла)");
            }

        }
    }
}