using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeFirstContinueProject
{
    internal static class OfficeDbInit
    {
        public static void Init()
        {
            using (OfficeContext officeDb = new OfficeContext())
            {
                officeDb.Database.EnsureDeleted();
                officeDb.Database.EnsureCreated();

                Position position1 = new Position() { Name = "Manager" };
                Position position2 = new Position() { Name = "Developer" };
                officeDb.Positions.AddRange(position1, position2);

                City city1 = new City() { Name = "Moscow" };
                City city2 = new City() { Name = "Washington" };
                officeDb.Cities.AddRange(city1, city2);

                Country country1 = new Country() { Name = "Russia", Capital = city1 };
                Country country2 = new Country() { Name = "Usa", Capital = city2 };
                officeDb.Countries.AddRange(country1, country2);

                Company company1 = new Company() { Name = "Yandex", Country = country1 };
                Company company2 = new Company() { Name = "Google", Country = country2 };
                Company company3 = new Company() { Name = "Mail Group", Country = country1 };
                Company company4 = new Company() { Name = "Amazone", Country = country2 };
                officeDb.Companies.AddRange(company1, company2, company3, company4);

                User user1 = new User() { Name = "Bob", Company = company1, Position = position1 };
                User user2 = new User() { Name = "Joe", Company = company2, Position = position1 };
                User user3 = new User() { Name = "Tim", Company = company1, Position = position2 };
                User user4 = new User() { Name = "Sam", Company = company2, Position = position2 };
                User user5 = new User() { Name = "Nick", Company = company3, Position = position1 };
                User user6 = new User() { Name = "Max", Company = company4, Position = position1 };
                User user7 = new User() { Name = "Anna", Company = company3, Position = position2 };
                User user8 = new User() { Name = "Jimmy", Company = company4, Position = position2 };
                officeDb.Users.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);

                officeDb.SaveChanges();
            }
        }
    }
}
