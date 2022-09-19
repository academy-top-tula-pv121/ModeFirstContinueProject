using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    static class EagerLoading
    {
        public static void Run()
        {
            using (OfficeContext officeDb = new OfficeContext())
            {
                //var users = officeDb.Users
                //                    .Include(u => u!.Company)
                //                        .ThenInclude(comp => comp!.Country)
                //                            .ThenInclude(cnt => cnt!.Capital)
                //                    .Include(u => u.Position)
                //                    .ToList();

                //foreach(var user in users)
                //{
                //    Console.WriteLine($"Employe: {user.Name} - {user.Position?.Name}");
                //    Console.WriteLine($"Company: {user.Company?.Name} - {user.Company?.Country?.Name} ({user.Company?.Country?.Capital?.Name})");
                //    Console.WriteLine("-------------------------------");
                //}

                //Console.WriteLine();

                //var companies = officeDb.Companies
                //                        .Include(comp => comp!.Country)
                //                            .ThenInclude(cnt => cnt!.Capital)
                //                        .Include(comp => comp!.Users)
                //                            .ThenInclude(u => u.Position)
                //                        .ToList();

                //foreach(var company in companies)
                //{
                //    Console.WriteLine($"Company: {company.Name} - {company.Country?.Name} ({company.Country?.Capital?.Name})");
                //    foreach(var user in company.Users)
                //        Console.WriteLine($"\tEmploye: {user.Name} - {user.Position?.Name}");
                //    Console.WriteLine("-------------------------------");
                //}


                var countries = officeDb.Countries
                                        .Include(country => country!.Capital)
                                        .Include(country => country!.Companies)
                                            .ThenInclude(company => company.Users)
                                                .ThenInclude(user => user.Position)
                                        .ToList();

                foreach (var country in countries)
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


                //var users = officeDb
                //                .Users
                //                .Include(u => u!.Company)
                //                    .ThenInclude(c => c!.Country)
                //                .ToList();


                //foreach (var user in users)
                //    Console.WriteLine($"Employe {user.Name} work in {user.Company?.Name} places in {user.Company?.Country?.Name}");

                //var companies = officeDb.Companies
                //                        .Include(c => c.Users)
                //                        .ToList();

                //foreach(Company company in companies)
                //{
                //    Console.WriteLine($"Company: {company.Name}");
                //    foreach (User user in company.Users)
                //        Console.WriteLine($"\tEmploye's name: {user.Name}");
                //    Console.WriteLine("-------------------");
                //}

                //Company companyDel = officeDb.Companies.FirstOrDefault();
                //officeDb.Companies.Remove(companyDel);
                //officeDb.SaveChanges();

                //Console.WriteLine();

                //foreach (var user in officeDb.Users.ToList())
                //    Console.WriteLine($"Employe {user.Name} work in {user.Company?.Name}");
            }
        }
    }
}
