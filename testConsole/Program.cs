using System;

namespace tutorialVisual
{
    class Program
    {
        static void Main(string[] args)
        {

            iniciarTutorial();

            cuenta(10);
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
    }
}
