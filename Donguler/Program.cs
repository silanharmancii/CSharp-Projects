using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kursu";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java geliştirici kursu";

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kursu", "programlamaya başlangıç için temel kurs", "java geliştirici kursu" };

            for (int i = 0;  i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}
