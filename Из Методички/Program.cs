using System;
using System.Collections.Generic;
using System.Linq;
using Из_Методички.classes;
using Из_Методички.interfaces;

namespace metodichka
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 10.1");
            Task1();

            Console.WriteLine("\nДомашнее задание 10.1");
            Task2();
        }
        static void Task1()
        {
            /*Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки
            шифрования строк. В интерфейсе объявляются два метода encode() и decode(), которые
            используются для шифрования и дешифрования строк, соответственно. Создать класс
            ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига
            каждого символа на одну «алфавитную» позицию выше. Например, в результате такого
            сдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс
            ICipher. Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й
            позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца
            алфавита. Например, буква В заменяется на букву Э. Написать программу,
            демонстрирующую функционирование классов.*/

            Console.WriteLine("\nПервый метод шифрования");
            ICipher aCipher = new ACipher();
            string text = "Программирование убивает";
            string encodedText = aCipher.Encode(text);
            string decodedText = aCipher.Decode(encodedText);

            Console.WriteLine($"Изначально: {text}");
            Console.WriteLine($"Закодировано: {encodedText}");
            Console.WriteLine($"Декодировано: {decodedText}");

            Console.WriteLine("\nВторой метод шифрования");
            ICipher bCipher = new BCipher();
            encodedText = bCipher.Encode(text);
            decodedText = bCipher.Decode(encodedText);

            Console.WriteLine($"Изначально: {text}");
            Console.WriteLine($"Закодировано: {encodedText}");
            Console.WriteLine($"Декодировано: {decodedText}");
        }
        static void Task2()
        {
            /*Домашнее задание 10.1. Создать класс Figure для работы с геометрическими фигурами. В
            качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать
            операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение
            цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить
            состояние всех полей объекта. Создать класс Point (точка) как потомок геометрической
            фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle добавить
            метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник)
            как потомок точки, реализовать метод вычисления площади прямоугольника. Точка,
            окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и
            вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно
            ли объявлять абстрактный класс, какие методы и поля будут в абстрактном классе, какие
            методы будут виртуальными, какие перегруженными.*/

            Console.WriteLine("\nТочка:");
            Point point = new Point(5, 10, "Красный", true);
            point.Display();
            point.MoveHorizontal(3);
            point.MoveVertical(-2);
            point.ChangeColor("Синий");
            point.SetVisibility(false);
            point.Display();

            Console.WriteLine("\nКруг:");
            Circle circle = new Circle(0, 0, 5, "Зеленый", true);
            circle.Display();
            circle.MoveHorizontal(10);
            circle.ChangeColor("Желтый");
            circle.Display();

            Console.WriteLine("\nПрямоугольник:");
            Rectangle rectangle = new Rectangle(2, 5, 4, 6, "Фиолетовый", true);
            rectangle.Display();
            rectangle.MoveVertical(5);
            rectangle.SetVisibility(false);
            rectangle.Display();
        }
    }
}