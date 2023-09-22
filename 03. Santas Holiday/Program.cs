using System;

namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем от конзолата:
            /*•	Първи ред – дни за престой – int
              •	Втори ред –  вид помещение –  "room for one person",  "apartment" или "president apartment"
              •	Трети ред –  оценка - "positive"  или "negative"*/
            int days=int.Parse(Console.ReadLine());
            string roomType=Console.ReadLine();
            string score=Console.ReadLine();

            //променлива за нощувките -пример: 11 дни = 10 нощувки
            //days-1
            int nights = days - 1;
            double price=0;
            //Пресмятаме цена за престоя:
            /* •	"room for one person" – 18.00 лв за нощувка
               •	"apartment" – 25.00 лв за нощувка
               •	"president apartment" – 35.00 лв за нощувка*/
            if (roomType== "room for one person") { price = nights * 18.00; }
            else if (roomType== "apartment") { price = nights * 25.00; }
            else if(roomType== "president apartment") { price = nights * 35.00; }
            //Проверяваме дали има отстъпка като
            /*вид помещение	    по-малко от 10 дни	   между 10 и 15 дни	   повече от 15 дни
        room for one person	    не ползва намаление	   не ползва намаление	   не ползва намаление
               apartment	    30% от крайната цена   35% от крайната цена	   50% от крайната цена
        president apartment	    10% от крайната цена   15% от крайната цена	   20% от крайната цена
*/
            double priceWithDiscount=price;
            if (nights < 10) 
            { if (roomType == "apartment") { priceWithDiscount = price - (price * 0.3); }
                else if (roomType == "president apartment") { priceWithDiscount = price - (price * 0.1); }
                else { priceWithDiscount = price; }
            }
            else if (nights>=10&&nights<=15)
            {
                if (roomType == "apartment") { priceWithDiscount = price - (price * 0.35); }
                else if (roomType == "president apartment") { priceWithDiscount = price - (price * 0.15); }
                else { priceWithDiscount = price; }
            }
            else if (nights>15)
            {
                if (roomType == "apartment") { priceWithDiscount = price - (price * 0.5); }
                else if (roomType == "president apartment") { priceWithDiscount = price - (price * 0.2); }
                else { priceWithDiscount = price; }
            }
            double totalPrice = priceWithDiscount;
            //Проверяваме оценка - "positive"(+25%)  или "negative"(-10%)от крайната цена
            if (score== "positive") { totalPrice = priceWithDiscount + (priceWithDiscount * 0.25); }
            else if (score == "negative") { totalPrice = priceWithDiscount - (priceWithDiscount * 0.1); }
            //Печатаме:
            //•	Цената за престоят му в хотела{:F2}
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
