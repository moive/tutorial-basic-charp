using System;
using System.Collections.Generic;

namespace tutorialVisual
{
    class Program
    {
        enum Mounths { January=1, February, March, April, May, June}
        static void Main(string[] args)
        {
            float julySale = 2000 * Taxes.tax;
            float augustSale = 2500 * Taxes.incomeTax;

            //Console.WriteLine((int)Mounths.January);

            //Console.WriteLine(julySale);

            //iniciarTutorial();

            //cuenta(10);

            listAndDictionary();
        }

        static void iniciarTutorial()
        {
            byte n1 = 255;
            sbyte n2 = -128;
            int n3 = -9845;
            uint n4 = 235;
            float n5 = 1.8f;
            double numeroGrande;
            decimal muchoMasGrande;

            DateTime fecha = DateTime.Today;

            fecha = DateTime.Parse("2021/12/31");

            Console.WriteLine(fecha.ToShortDateString());
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.AddDays(1));

            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("el número 2 no se pudo imprimir");
                    continue;
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i.ToString() + j.ToString());
                }
            }
        }

        static void cuenta(int number)
        {
            Console.WriteLine(number);

            if (number > 0)
            {
                cuenta(number - 1);
            }
        }

        static void listAndDictionary()
        {
            List<string> names = new List<string>();
            names.Add("Moises");
            names.Add("Samuel");
            names.Add("Pedro");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            Dictionary<string, int> items = new Dictionary<string, int>();

            items.Add("Daniela", 7);
            items.Add("Gabriela",4);

            //foreach (KeyValuePair<string,int> item in items)
            //{
            //    Console.WriteLine(item.Key);
            //}

            foreach (var item in items.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }

    static class Taxes
    {
        public const float tax = 0.18f;
        public const float incomeTax = 0.1f;
    }
}
