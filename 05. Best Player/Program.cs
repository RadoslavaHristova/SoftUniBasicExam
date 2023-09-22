using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем вход
            /*•	Име на играч – string
              •	Брой вкарани голове  – int
*/
            string playerName=Console.ReadLine();
            

            //правим променлива в която ще пазим името на 
            //играча с най-много голове
            string newBest = "";
            int newBestPoints = 0;

            //правим while цикъл който ще се върти до команда "END" или
            
            while(playerName!="END")
            {
                int points = int.Parse(Console.ReadLine());
                //правим проверка дали играча е новия най-добър
                if (points>newBestPoints)
                {
                    newBestPoints = points;
                    newBest = playerName;
                }
                //при вкарани 10 или повече гола от футбоист СПРИ
                if (points >= 10) { break; }
                
                playerName = Console.ReadLine();
                
            }
            //когато цикъла приключи 
            //печатаме :
            //"{име на играч} is the best player!"
            Console.WriteLine($"{newBest} is the best player!");
            //проверяваме има ли повече от 3 гола 
            if (newBestPoints>=3)
            //ако има positive print
            //"He has scored {брой голове} goals and made a hat-trick !!!"
            { Console.WriteLine($"He has scored {newBestPoints} goals and made a hat-trick !!!"); }
            //ako nqma negative
            //"He has scored {брой голове} goals and made a hat-trick !!!"
            else { Console.WriteLine($"He has scored {newBestPoints} goals."); }

        }
    }
}
