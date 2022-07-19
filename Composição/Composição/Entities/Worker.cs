using Composição.Entities.Enums;
using System.Collections.Generic;

namespace Composição.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }//Composição de objetos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Gerando a lista de contratos do trabalhador

        //Construtor vázio
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Método para adicionar um contrato
        public void AddContract(HourContract contract)//HourContract contract como parametro de entrada
        {
            Contracts.Add(contract);//Adicionando o contract que chegou como parametro na lista "List<HourContract> Contracts"
        }

        //Método para remover um contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);//Removendo o contract que chegou como parametro na lista "List<HourContract> Contracts"
        }

        //Método para cálcular quanto o trabalhador ganhou em um determinado mês/ano.
        public double Income(int year, int month)
        {
            double sum = BaseSalary;//Trabalhador receberá o sálario de toda forma.
            foreach(HourContract contract in Contracts)//Percorrer a lista de contract
            {
                if(contract.Date.Year == year && contract.Date.Month == month)//Percorrendo a lista de "Contract" e verificando mês e ano e acrescentando na soma
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
