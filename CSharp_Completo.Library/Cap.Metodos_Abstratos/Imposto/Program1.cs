using CSharp_Completo.Library.Cap.Metodos_Abstratos.Imposto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Metodos_Abstratos.Imposto
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int taxPayers = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();

            for (int taxPayer = 0; taxPayer < taxPayers; taxPayer++)
            {
                Console.WriteLine($"ENTER #{taxPayer} DATA:");
                Console.Write("Individual or company (c/i)?");
                char valida = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (valida == 'i')
                {
                    Console.Write("Healt expenditures:");
                    double healExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    /*construtor */
                    list.Add(new PessoaFisica(healExpenditures, name, anualIncome));
                }
                else if (valida == 'c')
                {
                    Console.Write("Number of Employees:");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    /*construtor */
                    list.Add(new PessoaJuridica(numberEmployees, name, anualIncome));
                }
                double totalTaxes = 0.0;
                Console.WriteLine("PRICE TAGS:");
                foreach (TaxPayer item in list)
                {
                    totalTaxes = item.Imposto();
                    totalTaxes += totalTaxes;
                    Console.WriteLine($"{item.Name}: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                Console.WriteLine();
                Console.WriteLine($"TOTAL TAXE: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}


