using System;
using System.Text;

namespace Chain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Настройка цепочки обязанности
            Approver vasya = new Director();
            Approver petya = new VicePresident();
            Approver ivan = new President();
            vasya.SetSuccessor(petya);
            petya.SetSuccessor(ivan);

            // Создание и обработка запросов на покупку
            var p = new Purchase(2034, 350.00, "Supplies");
            Console.WriteLine(vasya.ProcessRequest(p));
            p = new Purchase(2035, 32590.10, "Project X");
            Console.WriteLine(vasya.ProcessRequest(p));
            p = new Purchase(2036, 122100.00, "Project Y");
            Console.WriteLine(vasya.ProcessRequest(p));

            Console.ReadKey();
        }
    }
}