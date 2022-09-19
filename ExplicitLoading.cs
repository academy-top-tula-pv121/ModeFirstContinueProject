using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    static class ExplicitLoading
    {
        public static void Run()
        {
            using(OfficeContext officeContext = new OfficeContext())
            {
                //Company? company = officeContext.Companies.FirstOrDefault();
                //if(company != null)
                //{
                //    //officeContext.Users
                //    //             .Where(user => user.CompanyId == company.Id)
                //    //             .Load();

                //    //officeContext.Entry(company)
                //    //             .Collection(comp => comp.Users).Load();

                //    foreach (var u in company.Users)
                //        Console.WriteLine($"{u.Name}");
                //}

                User? user = officeContext.Users.ToList()[2];
                if(user != null)
                {
                    officeContext.Entry(user).Reference(u => u.Company).Load();
                    //officeContext.Users.Load();
                    Console.WriteLine($"{user.Name} - {user.Company?.Name}");
                }
            }
        }
    }
}
