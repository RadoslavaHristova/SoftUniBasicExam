using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем вход от конзолата:
            /*1.	Броят на хората в групата – int
              2.	Броят на нощувките –int
              3.	Броят на картите за транспорт – int
              4.	Броят на билетите за музеи – int
 */
            int peopleQty=int.Parse(Console.ReadLine());

            int nightsQty = int.Parse(Console.ReadLine());
            int transportCardsQty = int.Parse(Console.ReadLine());
            int ticketsQty = int.Parse(Console.ReadLine());

            //Пресмятаме цената за 1 бройка-нощувка, карти  и билети за музей
            /*•	Нощувка - 20 лв.
              •	Карта за транспорт - 1.60 лв.
              •	Билет за музей - 6 лв.
*/
            double nightsPricePerson = nightsQty * 20;
            double transportPerPerson = transportCardsQty * 1.60;
            double ticketsPricePerPerson = ticketsQty * 6;
            
            //Изчисляваме общата сумата, която групата трябва да плати
            double totalPPP=nightsPricePerson+transportPerPerson+ticketsPricePerPerson;
            double totalPerGroup = totalPPP * peopleQty;
            //Към крайната сума се начислява допълнително 25% за непредвидени разходи. 
            double totalTotal = totalPerGroup + (totalPerGroup * 0.25);

            //Печатаме:
            //•	парите, които групата трябва да плати{:F2}
            Console.WriteLine($"{totalTotal:f2}");
        }
    }
}
