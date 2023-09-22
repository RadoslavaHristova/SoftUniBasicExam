using System;

namespace _06._Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем вход
            /*•	K(първа цифра от ПЪРВО число) – цяло число в интервала [0..8]
              •	L(втора цифра от ПЪРВО число) – цяло число в интервала [0..9]
              •	M(първа цифра от ВТОРО число) – цяло число в интервала [0..8]
              •	N(втора цифра от ВТОРО число) – цяло число в интервала [0..9]
*/

            //Брояч на съвпадения

            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            /*•	k11 :в интервала от цифрата K до 8, включително.
              •	l12 :в интервала от 9 до L, включително.
              •	m21 :в интервала от цифрата M до 8, включително.
              •	n22 :в интервала от 9 до N, включително.
*/

            /*!!!За да бъде възможна смяна, първата цифра на всеки от номерата ТРЯБВА ДА Е ЧЕТНА, а втората -  НЕЧЕТНА.
              !!!За да бъде валидна една смяна, то номерата НЕ трябва да съвпадат.
*/

            for (int k11 = k; k11 <= 8; k11++)
            {
                if (k11 % 2 == 1) { continue; }
                for (int l21 = 9; l21 >= l; l21--)
                {
                    if (l21 % 2 == 0) { continue; }
                    for (int m12 = m; m12 <= 8; m12++)
                    {
                        if (m12 % 2 == 1) { continue; }
                        for (int n22 = 9; n22 >= n; n22--)
                        {
                            if (n22 % 2 == 0)
                            {
                                continue;
                            }

                            if (k11 == m12 && l21 == n22)
                            {

                                Console.WriteLine("Cannot change the same player.");

                            }
                            else
                            {
                                counter++;
                                Console.WriteLine($"{k11}{l21} - {m12}{n22}");


                            }
                            if (counter == 6) { return; }
                        }
                    }
                }
            }
        }
    }
}
