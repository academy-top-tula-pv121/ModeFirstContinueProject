using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    internal static class LazyLoading
    {
        public static void Run()
        {
            using (OfficeContext officeContext = new OfficeContext())
            {
                foreach(var user in officeContext.Users.ToList())
                    Console.WriteLine($"{user.Name} - {user.Company?.Name}");

                Console.WriteLine("-------------------------------\n");

                foreach (var country in officeContext.Countries.ToList())
                {
                    Console.WriteLine($"Country: {country.Name} ({country.Capital?.Name})");
                    foreach (var company in country.Companies)
                    {
                        Console.WriteLine($"\tCompany: {company.Name}");
                        foreach (var user in company.Users)
                            Console.WriteLine($"\t\tEmploye: {user.Name} - {user.Position?.Name}");
                        Console.WriteLine("-------------------------------");
                    }
                    Console.WriteLine("-------------------------------\n");
                }
            }
        }
    }
}
