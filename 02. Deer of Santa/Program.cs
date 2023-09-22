using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем от конзолата:
            /*•	Първи ред – брой дни, в които Дядо Коледа отсъства – int
              •	Втори ред – оставена храна в !килограми! – int
              •	Трети ред – храна на ден за първия елен в килограми –double
              •	Четвърти ред – храна на ден за втория елен в килограми– double
              •	Пети ред – храна на ден за третия елен в килограми –double
*/
            int daysWithoutSanta=int.Parse(Console.ReadLine());
            int foodForDeers = int.Parse(Console.ReadLine());
            double foodPerDayFirstD=double.Parse(Console.ReadLine());
            double foodPerDaySecondD = double.Parse(Console.ReadLine());
            double foodPerDay3D = double.Parse(Console.ReadLine());

            //Пресмятаме колко е изял всеки от елените за дните които са без стареца
            double eatenFoodFirstD = daysWithoutSanta * foodPerDayFirstD;
            double eatenFood2D = daysWithoutSanta * foodPerDaySecondD;
            double eatenFood3D=daysWithoutSanta* foodPerDay3D;

            //Пресмятаме общо колко е изяденото
            double allEatenFood=eatenFoodFirstD+eatenFood2D+eatenFood3D;
            //Правим проверка :
            if (allEatenFood<=foodForDeers)
            { Console.WriteLine($"{Math.Floor(foodForDeers-allEatenFood)} kilos of food left."); }
            //ако общо изяденото е по- малко или равна от оставената храна
            //Positive print
            //	
            else if(allEatenFood>foodForDeers) {Console.WriteLine($"{Math.Ceiling(allEatenFood-foodForDeers)} more kilos of food are needed."); }
            //ако оставената храна е по- малко 
            //negative print
            //“”

        }
    }
}
