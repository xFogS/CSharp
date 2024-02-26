using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Menu;

//2-- // на мій погляд, мені пришлось би перероблювати всю структуру коду на статичний

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
        public List<CompanyEmployees>? CompanyEmployees { get; set; }
    }
    public class CompanyEmployees
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }
        public int Salary { get; set; }
    }
    public class Company
    {
        //Array/List - Your choice.
        List<CompanyInfo> cmp = new List<CompanyInfo>()
        {
            new CompanyInfo()
            {
                NameCompany = "Food",
                DateCreate = new DateTime(2010, 10, 07),
                Industry = "IT",
                Director = "GSA",
                CountEmployees = 114,
                Address = "Mykolaiv",
                CompanyEmployees = new List<CompanyEmployees>()
                {
                    new CompanyEmployees()
                    {
                        Name = "m",
                        Position = "m",
                        ContactPhone = "p",
                        Email = "",
                        Salary = 0,
                    },
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                },
            },
            new CompanyInfo()
            {
                NameCompany = "Always With You",
                DateCreate = new DateTime(2017, 6, 15),
                Industry = "Marketing",
                Director = "Fedorov PA",
                CountEmployees = 50,
                Address = "London",
                CompanyEmployees = new List < CompanyEmployees>()
                {
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                },
            },
            new CompanyInfo()
            {
                NameCompany = "White",
                DateCreate = new DateTime(2022, 1, 31),
                Industry = "IT",
                Director = "Black",
                CountEmployees = 140,
                Address = "Zhytomyr",
                CompanyEmployees = new List<CompanyEmployees>()
                {
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                    new CompanyEmployees()
                    {
                        Name = "",
                        Position = "",
                        ContactPhone = "",
                        Email = "",
                        Salary = 0,
                    },
                }
            },
        };
        private void PrintLinq(IEnumerable<CompanyInfo> info)
        {
            Console.Clear();
            foreach (CompanyInfo i in info)
            {
                Console.WriteLine($"Company - {i.NameCompany}\n" +
                    $"Create - {i.DateCreate.ToShortDateString()}\n" +
                    $"Industry - {i.Industry}\n" +
                    $"Director - {i.Director}\n" +
                    $"Empoloyees - {i.CountEmployees}\n" +
                    $"Adress - {i.Address}\n");
            }
            Thread.Sleep(5000);
        }
        private void PrintLinqEmployee(IEnumerable<CompanyInfo> info)
        {
            foreach (CompanyInfo j in info)
            {
                Console.WriteLine($"Company: {j.NameCompany}\n");
                foreach (CompanyEmployees i in j.CompanyEmployees)
                {
                    Console.WriteLine($"Name - {i.Name}\n" +
                        $"Position - {i.Position}\n" +
                        $"Phone - {i.ContactPhone}\n" +
                        $"Email - {i.Email}\n" +
                        $"Salary - {i.Salary}\n");
                }
                Thread.Sleep(7000);
            }
        }
        public void mainCompany()
        {
            Console.WriteLine("List Company");
            do
            {
                Console.Clear();
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Print | All Company", "Name", "Create", "Industry", "Director", "Count Employees", "Country/Address",
                    "Empoloyees", "Exit");
                switch (choice)
                {
                    case 0:
                        {
                            var print = from pr in cmp select pr;
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
                    case 4:
                        {
                            int crt = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "White", "Black and CMPN - White", "Return back");
                            switch (crt)
                            {
                                case 0:
                                    {
                                        var print = from i in cmp
                                                    where i.Director == "White"
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.Director == "Black" && i.NameCompany == "White"
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                                case 2: return;
                            }
                            break;
                        }
                    case 5:
                        {
                            int crt = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                ">100", "100 - 300", "Return back");
                            switch (crt)
                            {
                                case 0:
                                    {
                                        var print = from i in cmp
                                                    where i.CountEmployees > 100
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.CountEmployees >= 100 && i.CountEmployees <= 300
                                                    select i; PrintLinq(print); break;
                                    }
                                case 2: return;
                            }
                            break;
                        }
                    case 6:
                        {
                            int crt = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "London", "Return back");
                            switch (crt)
                            {
                                case 0:
                                    {
                                        var print = from i in cmp
                                                    where i.Address == "London"
                                                    select i;
                                        PrintLinq(print); break;
                                    }
                                case 1: return;
                            }
                            break;
                        }
                    case 7:
                        {
                            int empChoice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "All List", ">Samary", "Postion: Manager", "Phone: +23",
                                "Email: +di", "Name: Lionel", "Return back");
                            switch (empChoice)
                            {
                                //
                                case 0:
                                    {
                                        Console.Clear(); Console.Write("Enter the Industry : ");
                                        string? str = Console.ReadLine().ToUpper();
                                        if (str != null)
                                        {
                                            var emp = from i in cmp
                                                      where i.Industry == str
                                                      select i;
                                            PrintLinqEmployee(emp); break;
                                        }
                                        break;
                                    }
                                //all list
                                case 1: return; //samary
                                case 2: return; //manager
                                case 3: return; // phone
                                case 4: return; //email
                                case 5: return; // name
                                case 6: return; // return
                            }
                            break;
                        }
                    case 8: return;
                }
            } while (true);
        }
    }
}
