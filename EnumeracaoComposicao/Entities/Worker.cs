using System;
using EnumeracaoComposicao.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EnumeracaoComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Department Department  { get; set; }

        public Worker()
        {
        }
        public Worker(Department department, WorkerLevel level, string name, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int month, int year)
        {
            double incomeOfMonth = BaseSalary;
            foreach (HourContract contract in Contracts) {
                
                if(contract.Date.Month == month && contract.Date.Year == year)
                {
                    incomeOfMonth += contract.TotalValue();
                }
            }
            return incomeOfMonth;
        }
    }
}
