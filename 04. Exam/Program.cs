using System;

namespace _04._Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем вход
            //броя на студентите явили се на изпит – int
            int studentsQty=int.Parse(Console.ReadLine());
            //правим променливи броячи за групите
            //с оценка между 2.00 и 2.99; между 3.00 и 3.99; между 4.00 и 4.99; 5.00 или повече
            int group1=0, group2=0, group3=0, group4=0;
            //правим променлива която ще съхранява оценките общо
            double average = 0;
            //Правим for-цикъл който ще върти докато получим оценка за
            //всеки един от студентите
            for(int i=1; i<=studentsQty; i++) 
            {//Четем : оценката от изпита за всеки –double
                double scorePerStudent=double.Parse(Console.ReadLine());
                //Правим проверка в коя група попада оценката и
                //увеливаваме брояча ++1 за съответната група;
                //прибавяме оценката към общия успех!
                if(scorePerStudent>=2.00&&scorePerStudent<=2.99)
                { group1++;average += scorePerStudent; }
                else if (scorePerStudent>=3.00&&scorePerStudent<=3.99)
                { group2++;average += scorePerStudent; }
                else if (scorePerStudent>=4.00&&scorePerStudent<=4.99)
                { group3++;average += scorePerStudent;}
                else 
                { group4++;average += scorePerStudent;}

                
            }
            //пресмятаме процента за всяка от групите
            //(Група 1 -> брой студенти: 3 => 3 / 10 * 100 = 30%)
            double pPerG1 = 1.0 * group1 / studentsQty * 100;
            double pPerG2 = 1.0 * group2 / studentsQty * 100;
            double pPerG3 = 1.0 * group3 / studentsQty * 100;
            double pPerG4 = 1.0 * group4 / studentsQty * 100;
            // смятаме средния успех(всичко оценки/броя студенти)
            double totalAverage=average/studentsQty;
            //печат:
            /*Ред 1 -	"Top students: {процент студенти с успех 5.00 или повече:F2}%"
              Ред 2 -	"Between 4.00 and 4.99: {между 4.00 и 4.99 включително:F2}%"
              Ред 3 -	"Between 3.00 and 3.99: {между 3.00 и 3.99 включително:F2}%"
              Ред 4 -	"Fail: {по-малко от 3.00:F2}%"
              Ред 5 -	"Average: {среден успех:F2}"
*/
            Console.WriteLine($"Top students: {pPerG4:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {pPerG3:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {pPerG2:F2}%");
            Console.WriteLine($"Fail: {pPerG1:F2}%");
            Console.WriteLine($"Average: {totalAverage:F2}");
        }
    }
}
