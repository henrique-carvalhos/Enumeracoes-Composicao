using Enumerções.Entities;
using Enumerções.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);

            //Conversão de valor Enum para String
            string txt = OrderStatus.PendingPayment.ToString();

            //Conversão de String para valor Enum
            OrderStatus os;
            Enum.TryParse("Delivered", out os);

            //Mostrando as variáveis
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
