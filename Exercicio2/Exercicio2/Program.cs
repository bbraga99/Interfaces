using System;
using System.Globalization;
using Exercicio2.Entities;
using Exercicio2.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, contractValue);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalPayment());

            contractService.ProcessContract(contract, months);

            Console.WriteLine("installments:");

            foreach (Installment installment in contract.Installments)
            {
                {
                    Console.WriteLine(installment);
                }
            }
        }
    }
}
