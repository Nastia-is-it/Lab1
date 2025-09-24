using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Lab1
    {
        public double Fraction(double x) //Вернуть дробную часть числа х
        {
            x = x % 1;
            return x;
        }
        public int CharToNum(char x) //Метод, преобразующий символ в соответствующее число
        {
            int r;
            r = int.Parse(Convert.ToString(x));
            return r;
        }

        public bool IsDigits(int x) //Проверка числа на двузначность
        {
            string s;
            s = Convert.ToString(x);
            if (s.Length == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Проверка: num входит в диапазон(включая границы) от a до b
        public bool IsInRange(int a, int b, int num) 
        {
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i == num)
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool IsEqual(int a, int b, int c) //Проверка на равенство 3-ёх чисел
        {
            if (a == b && b == c && a == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Abs(int x)//Вернуть модуль числа
        {
            if (x < 0)
            {
                return x * (-1);
            }
            else
            {
                return x;
            }
        }

        //Вернуть true, если x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то
        //вернуть надо false. 
        public bool Is35(int x)
        {
            if ((x % 3 == 0 || x % 5 == 0) && (x % 15 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Max3(int x, int y, int z) //Вернуть максимальное число
        {
            int t = 0;
            if (x > y)
            {
                t = x;
            }
            else
            {
                t = y;
            }
            if (t > z)
            {
                return t;
            }
            else
            {
                return z;
            }
        }

        //Вернуть сумму чисел x и y. Если сумма попадает в диапазон от 10 до 19, то вернуть 20
        public int Sum2(int x, int y)
        {
            int c = x + y;
            if (c >= 10 && c <= 19)
            {
                return 20;
            }
            else
            {
                return c;
            }
        }

        public String Day(int x)//По номеру недели определяет его название
        {
            switch (x)
            {
                case 1:
                    return "Понедельник";
                    break;
                case 2:
                    return "Вторник";
                    break;
                case 3:
                    return "Среда";
                    break;
                case 4:
                    return "Четверг";
                    break;
                case 5:
                    return "Пятница";
                    break;
                case 6:
                    return "Суббота";
                    break;
                case 7:
                    return "Воскресенье";
                    break;
                default:
                    return "Это не день недели";
            }
        }

        public String ListNums(int x) //Вернуть строку с числами от 0 до x
        {
            List<int> pt = new List<int>();
            for (int i = 0; i <= x; i++)
            {
                pt.Add(i);
            }

            string t;
            string res = "";
            for (int i = 0; i <= x; i++)
            {
                t = Convert.ToString(pt[i]);
                res += t + " ";
            }
            return res;

        }

        public String Chet(int x) //Вернуть строку с чётными числами от 0 до x
        {
            string res = "";
            string t;
            for (int i = 0; i <= x; i+=2)
            {
                t = Convert.ToString(i);
                res += t + " ";
            }
            return res;
        }

        public int NumLen(long x) //Вернуть количество знаков в числе
        {
            int s = 0;
            while (x > 0)
            {
                x /= 10;
                s++;
            }
            return s;
        }

        public void Square(int x)
        {
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < x; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }   
        }

        public void RightTriangle(int x) //Правый треугольник
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                } 

                Console.WriteLine();
            }
        }

        public int FindFirst(int[] arr, int x) //Индекс первого вхождения числа x
        {
            for(int i = 0; i < arr.Length; i++) {
                if (arr[i] == x) return i;
                
            }
            return -1;
        }

        public int MaxAbs(int[] arr) //Наибольшее по модулю число
        {
            
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (Abs(arr[i]) > Abs(max))
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int[] Add(int[] arr, int[] ins, int pos) //Вернуть массив, содержащий arr и ins в позиции pos

        {
            int[] newMas = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
            {
                newMas[i] = arr[i];
            }

            for (int i = 0; i < ins.Length; i++)
            {
                newMas[pos + i] = ins[i];
            }

            for (int i = pos; i < arr.Length; i++)
            {
                newMas[ins.Length + i] = arr[i];
            }

            return newMas;

        }

        public int[] ReverseBack(int[] arr) //Инвертировать
        {
            int[] newArr = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[arr.Length - 1 - i];
            }
            return newArr;
        }

        public int[] FindAll(int[] arr, int x) //индексы вхождений
        {
            int countX = 0;
            int j = 0;
            foreach (int n in arr)
            {
                if (n == x)
                {
                    countX++;
                }
            }
            int[] newArr = new int[countX];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    newArr[j] = i;
                    j++;
                }
            }
            return newArr;
        }
    }
}

