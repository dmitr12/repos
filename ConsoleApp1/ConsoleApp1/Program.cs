using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.String;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Типы
            //a)
            sbyte sbValue = 10;
            short shValue = 20;
            int intValue = 140;
            long lValue = 7848679;
            byte bValue = 100;
            ushort ushValue = 3;
            uint uintValue = 390;
            ulong ulValue = 17000;
            char chValue = 'b';
            bool boolValue = false;
            float fValue = 0.7F;
            double dValue = 16.456;
            decimal decValue = 128;
            string strValue = "Hello";

            //b)
            //Явное

            shValue = (short)intValue;
            intValue = (int)lValue;
            fValue = (float)dValue;
            shValue = (short)chValue;
            intValue = (int)lValue;

            //Неявное
            dValue = fValue;
            lValue = intValue;
            intValue = shValue;
            ulValue = uintValue;
            lValue = sbValue;

            //c)
            int b = 15;
            object box = b;//boxing
            int tr = (int)box;//unboxing

            //d)
            var sum = dValue + intValue;
            WriteLine(sum + " " + sum.GetType());

            //e)
            int? nullable = null;
            int? pr = 24;
            WriteLine(nullable.HasValue);
            WriteLine(pr.HasValue);

            //2. Строки
            //a)
            string q = "hello";
            string str = "helo";
            if (q == str)
                WriteLine("Строки равны");
            else
                WriteLine("Строки не равны");

            //b)
            string name1 = "hello";
            string name2 = "world in the window";
            string name3 = "day";
            string conc = Concat(name1, name2, name3);
            WriteLine(conc);
            string copy = Copy(name2);
            WriteLine(copy);
            string subs = name1.Substring(2, 3);
            WriteLine(subs);
            string[] spl = name2.Split(' ');
            foreach (var t in spl)
                WriteLine(t);
            WriteLine("С какой позиции ввести подстроку?");
            WriteLine(name1.Insert(int.Parse(ReadLine()), "www"));
            WriteLine("С какой позиции хотите удалить подстроку?");
            WriteLine(conc.Remove(int.Parse(ReadLine()), 4));

            //c)
            string st = "";
            string nul = null;
            st = Copy(name1);
            WriteLine(st);
            try
            {
                nul.Equals(name1);
            }
            catch (Exception error)
            {
                WriteLine(error.Message);
            }

            //d)
            StringBuilder build = new StringBuilder("Today is Monday", 40);
            WriteLine("С какой позиции удалить подстроку?");
            WriteLine(build.Remove(int.Parse(ReadLine()), 3));
            WriteLine(build.Append("he//"));
            WriteLine(build.Insert(0, "tr"));

            //3)
            //a)
            WriteLine("Введите количество строк массива");
            int x = int.Parse(ReadLine());
            WriteLine("Введите количество элементов в строке");
            int y = int.Parse(ReadLine());
            int[,] v = new int[x, y];
            WriteLine("Введите элементы матрицы");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    v[i, j] = int.Parse(ReadLine());
                }
            }
            WriteLine("Полученная матрица:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Write("{0,2}", v[i, j]);
                }
                WriteLine();
            }

            //b)
            WriteLine("Количество элементов в строковом массиве:");
            int kol = int.Parse(ReadLine());
            string[] rt = new string[kol];
            WriteLine("Заполните массив");
            for (int i = 0; i < kol; i++)
                rt[i] = ReadLine();
            WriteLine("Массив:");
            for (int i = 0; i < kol; i++)
                Write(rt[i] + " ");
            WriteLine();
            WriteLine("Длина этого массива = " + rt.Length);
            WriteLine("Какой элемент хотите поменять?");
            int el = int.Parse(ReadLine());
            WriteLine("На какой элемент хотите поменять?");
            string change = ReadLine();
            rt[el - 1] = change;
            WriteLine("Полученный массив:");
            for (int i = 0; i < kol; i++)
                Write(rt[i] + " ");
            WriteLine();
            WriteLine("Длина этого массива = " + rt.Length);

            //c)
            WriteLine("Ступенчатый массив");
            float[][] d = new float[3][];
            for (int i=0;i<3;i++)
            {
                WriteLine("Сколько элементов в " + i + " ой строке");
                int e = int.Parse(ReadLine());
                d[i] = new float[e];
                WriteLine("Теперь введите их");
                for(int j=0;j<e;j++)
                {
                    d[i][j] = float.Parse(ReadLine());
                }
            }
            WriteLine("Полученный массив:");
            foreach(float[] xp in d)
            {
                foreach (float br in xp)
                    Write(" " + br);
                WriteLine();
            }

            //d)
            WriteLine("Массив var");
            var array = new[] { 1.12, 1.45, 5.78, 2.657 };
            foreach (var te in array)
                Write(" " + te);
            WriteLine();
            WriteLine("Его тип " + array.GetType());
            var varstr = "hello";
            WriteLine("Строка var: " + varstr);
            WriteLine("Его тип " + varstr.GetType());

            //4. Кортежи
            //a, b)
            WriteLine();
            WriteLine("Кортежи");
            var tuple = (number:10, word:"Place", letter:'p', word2:"long", lon:1778763876);

            //c)
            WriteLine("Весь кортеж: " + tuple);
            WriteLine("1, 3 и 4 элементы кортежа: " + tuple.Item1 + " " + tuple.Item3 + " " + tuple.Item4);

            //d)
            (int one, string two, char three, string four, long five) = tuple;

            //e)
            var tuple2 = (10, "Place", 'p', "short", 1778763876);
            WriteLine("Второй кортеж: " + tuple2);
            if (tuple.Equals(tuple2))
                WriteLine("Кортежи равны");
            else
                WriteLine("Кортежи не равны");

            //5. Локальная функция
            int[] ty = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Write("Максимальный и минимальный элементы массива:");
            foreach (int po in ty)
                Write(" " + po);
            Write(", а также их сумма и первая буква строки 'hello':");
            WriteLine();
            (int, int, int, string) ArrayAndStr(int[] mass, string strin)

            {
                int a = mass.Max();
                int qe = mass.Min();
                int summm = mass.Sum();
                string let = strin.Substring(0, 1);
                return (a, qe, summm, let);
            }
            WriteLine(ArrayAndStr(ty, name1));
        }
    }
}
