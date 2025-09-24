using System.Linq.Expressions;
using System.Net;
using Pract;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Lab1 lb = new Lab1();

        //double x;
        //Console.Write("Введите дробное число: x = ");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine(lb.Fraction(x));

        //Console.Write("Введите число (имеет строковое представление): ");
        //char x = Convert.ToChar(Console.ReadKey().KeyChar);
        //Console.WriteLine();
        //Console.WriteLine("Целое число: " + lb.CharToNum(x));

        //int x;
        //Console.Write("Проверка на двузначность. Введите число: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //if (lb.IsDigits(x))
        //{
        //    Console.WriteLine("True");
        //}
        //else
        //{
        //    Console.WriteLine("False");
        //}

        //Console.WriteLine("Введите диапазон чисел: ");
        //int a, b;
        //a = Convert.ToInt32(Console.ReadLine());
        //b = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Введите искомое число: ");
        //int num;
        //num = Convert.ToInt32(Console.ReadLine());
        //if (lb.IsInRange(a, b, num))
        //{
        //    Console.WriteLine("True");
        //}
        //else
        //{
        //    Console.WriteLine("False");
        //}

        //int a, b, c;
        //Console.WriteLine("Введите 3 числа: ");
        //Console.Write("a = ");
        //a = Convert.ToInt32(Console.ReadLine());
        //Console.Write("b = ");
        //b = Convert.ToInt32(Console.ReadLine());
        //Console.Write("c = ");
        //c = Convert.ToInt32(Console.ReadLine());
        //if (lb.IsEqual(a, b, c))
        //{
        //    Console.WriteLine("Числа равны");
        //}
        //else
        //{
        //    Console.WriteLine("Числа не равны");
        //}

        //int t;
        //Console.WriteLine("Введите число: ");
        //t = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Модуль числа " + t + ": ");
        //Console.WriteLine(lb.Abs(t));

        //int a;
        //Console.WriteLine("Проверка числа: делится либо на 3, либо на 5, не должно делиться на 3 и 5 одновременно.");
        //Console.Write("Введите число: ");
        //a = Convert.ToInt32(Console.ReadLine());
        //if (lb.Is35(a))
        //{
        //    Console.WriteLine("True");
        //}
        //else
        //{
        //    Console.WriteLine("False");
        //}

        //int x, y, z;
        //Console.WriteLine("Поиск наибольшего числа из трёх");
        //Console.WriteLine("Введите числа: ");
        //Console.Write("x = ");
        //x = Convert.ToInt32(Console.ReadLine());
        //Console.Write("y = ");
        //y = Convert.ToInt32(Console.ReadLine());
        //Console.Write("z = ");
        //z = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Наибольшее число: " + lb.Max3(x, y, z));

        //int x, y;
        //Console.WriteLine("Введите числа: ");
        //Console.Write("x = ");
        //x = Convert.ToInt32(Console.ReadLine());
        //Console.Write("y = ");
        //y = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Сумма чисел: " + lb.Sum2(x, y));

        //int day;
        //Console.WriteLine("Введите номер недели: ");
        //day = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Неделя: " + lb.Day(day));

        //int x;
        //Console.WriteLine("Создаю строку от 0 до x: ");
        //Console.WriteLine("Введите x: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Результат: " + lb.ListNums(x));

        //int x;
        //Console.WriteLine("Создаю строку c чётными числами от 0 до x: ");
        //Console.WriteLine("Введите x: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Результат: " + lb.Chet(x));

        //int n;
        //Console.WriteLine("Введи число: ");
        //n = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Количество знаков в числе: " + lb.NumLen(n));

        //int n;
        //Console.WriteLine("Рисуем квадрат: ");
        //Console.WriteLine("Размер квадрата: ");
        //n = Convert.ToInt32(Console.ReadLine());
        //lb.Square(n);

        //int n;
        //Console.WriteLine("Рисуем треугольник: ");
        //Console.WriteLine("Размер треугольника: ");
        //n = Convert.ToInt32(Console.ReadLine());
        //lb.RightTriangle(n);

        //int index;
        //Console.Write("В массиве: ");
        //int[] arr = new int[] {1, 2, 3, 5, 6, 7, 1, 3 };
        //foreach (int i in arr) {
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.Write("Индекс первого вхождения числа ");
        //index = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Равно " + lb.FindFirst(arr, index));

        //int n;
        //Console.Write("Введите размер массива: ");
        //n = Convert.ToInt32(Console.ReadLine());
        //int[] arr = new int[n];
        //Console.WriteLine("Введите массив: ");
        //for (int i = 0; i < n; i++) {
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.Write("Максимальное по модулю число: " + lb.MaxAbs(arr));


        //int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //int[] ins = new int[] { 10, 12, 13, 14 };
        //int index;
        //Console.WriteLine("Даны массивы: ");

        //Console.Write("arr: ");
        //foreach (int num in arr)
        //{
        //    Console.Write(num + " ");
        //}

        //Console.Write("ins: ");
        //foreach (int num in ins)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        //Console.Write("Индекс, на место которого нужно добавить массив ins: ");
        //index = Convert.ToInt32(Console.ReadLine());

        //if (index >= arr.Length)
        //{
        //    Console.WriteLine("Ошибка ввода");
        //}

        //foreach (int num in lb.Add(arr, ins, index))
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        //int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //Console.Write("Дан массив: ");
        //foreach (int num in arr)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        //Console.WriteLine("Инвентированный массив: ");
        //foreach (int num in lb.ReverseBack(arr))
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        int num;
        int[] arr = new int[] { 1, 2, 3, 2, 3, 7, 2 };
        Console.Write("Дан массив: ");
        foreach (int n in arr)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        Console.Write("Введите число, индексы вхождений которого нужно определить: ");
        num = Convert.ToInt32(Console.ReadLine());
        foreach (int n in lb.FindAll(arr, num))
        {
            Console.Write(n + " ");
        }

    }
}