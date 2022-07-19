using System;

namespace Composição.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }//Valor por hora
        public int Hours { get; set; }//Duração em horas desse contrato

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Método para cálcular o valor total do contrato
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
