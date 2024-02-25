using Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class CompanyInfo
    {
        public string? NameCompany { get; set; }
        public DateTime DateCreate { get; set; }
        public string? Industry { get; set; }
        public string? Director { get; set; }
        public int CountEmployees { get; set; }
        public string? Address { get; set; }
    }
    class Company : CompanyInfo
    {
        List<CompanyInfo> cmp = new List<CompanyInfo>()
        {
            new CompanyInfo()
            {
                NameCompany = "Food",
                DateCreate = new DateTime(2010, 10, 07),
                Industry = "IT",
                Director = "GSA",
                CountEmployees = 114,
                Address = "Mykolaiv - Ukraine"
            },
            new CompanyInfo()
            {
                NameCompany = "Always With You",
                DateCreate = new DateTime(2017, 6, 15),
                Industry = "Marketing",
                Director = "Fedorov PA",
                CountEmployees = 50,
                Address = "Lviv - Ukraine"
            },
            new CompanyInfo()
            {
                NameCompany = "White",
                DateCreate = new DateTime(2022, 1, 31),
                Industry = "IT",
                Director = "Black",
                CountEmployees = 140,
                Address = "Zhytomyr - Ukraine"
            },
        };
        private void PrintLinq(IEnumerable<CompanyInfo> info)
        {
            foreach (CompanyInfo i in info)
            {
                Console.WriteLine($"{i.NameCompany}\n" +
                    $"{i.DateCreate.ToShortDateString()}\n" +
                    $"{i.Industry}\n" +
                    $"{i.Director}\n" +
                    $"{i.CountEmployees}\n" +
                    $"{i.Address}\n");
            }
            Thread.Sleep(5000);
        }
        public void mainCompany()
        {
            Console.WriteLine("List Company");
            do
            {
                Console.Clear();
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Print | All Company", "Name", "Create", "Industry", "Director", "Count Employees", "Address", "Exit");
                switch (choice)
                {
                    case 0:
                        {
                            //var print = from pr in cmp
                            //            select pr;

                            PrintLinq(print); break;
                        }
                    case 1:
                        {
                            var print = from i in cmp
                                        where i.NameCompany == "Food"
                                        select i;
                            PrintLinq(print); break;
                        }
                    case 2:
                        {
                            int crt = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "Company +2 Years", "Company +123 Days", "Return back");
                            switch (crt)
                            {
                                case 0:
                                    {
                                        var print = from pr in cmp
                                                    where DateTime.Now.Year - 2 == pr.DateCreate.Year
                                                    select pr;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where (DateTime.Now - i.DateCreate).Days > 123
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                            }
                            break;
                        }
                    case 3: // тут я скоротив до 1 маркетинга, бо два раза доблювати в окремому меню маркетинг таке собі
                        {
                            Console.Clear();
                            int crt = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "Marketing", "IT", "Return back");
                            switch (crt)
                            {
                                case 0:
                                    {
                                        var print = from i in cmp
                                                    where i.Industry == "Marketing"
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.Industry == "IT"
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                                case 2: return;
                            }
                            break;
                        }
                    case 4://director
                        {
                            Console.Clear();
                            int crt = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "White", "Black and CMPN:White", "Return back");
                            switch (crt)
                            {
                                case 0:
                                    {
                                        var print = from i in cmp
                                                    where i.Director == "White"
                                                    select i;
                                        PrintLinq(print);
                                        break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.Director == "Black" && i.NameCompany == "White"
                                                    select i;
                                        PrintLinq(print);
                                        break;
                                    }
                                case 2: return;
                            }
                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                    case 6:
                        {

                            break;
                        }
                    case 7: return;
                }
            } while (true);
        }
    }
}
