using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Menu;

//2--

namespace LINQ
{

    public class CompanyInfo
    {
        public string? NameCompany { get; set; } = "None";
        public DateTime DateCreate { get; set; } = new DateTime(2024, 12, 12);
        public string? Industry { get; set; } = "None";
        public string? Director { get; set; } = "None";
        public int CountEmployees { get; set; } = 0;
        public string? Address { get; set; } = "None";
        public List<CompanyEmployees>? CompanyEmployees { get; set; }
    }
    public class CompanyEmployees
    {
        public string? Name { get; set; } = "None";
        public string? Position { get; set; } = "None";
        public string? ContactPhone { get; set; } = "None";
        public string? Email { get; set; } = "None";
        public int Salary { get; set; } = 0;
    }
    public class Company
    {
        public static int count = 0;
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
                        Name = "Fedor",
                        Position = "Middle",
                        ContactPhone = "2351234",
                        Email = "diap21@food.com",
                        Salary = 140000,
                    },
                    new CompanyEmployees()
                    {
                        Name = "Tom",
                        Position = "Manager",
                        ContactPhone = "0128422",
                        Email = "odslq@food.com",
                        Salary = 59000,
                    },
                    new CompanyEmployees()
                    {
                        Name = "John",
                        Position = "Senior",
                        ContactPhone = "2393812",
                        Email = "dioslqw@food.com",
                        Salary = 270000,
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
                        Name = "Lionel",
                        Position = "Manager",
                        ContactPhone = "6236124",
                        Email = "sdfhsdfh@gmail.com",
                        Salary = 88000,
                    },
                    new CompanyEmployees()
                    {
                        Name = "rtue",
                        Position = "erre",
                        ContactPhone = "4636212",
                        Email = "erher",
                        Salary = 234234,
                    },
                    new CompanyEmployees()
                    {
                        Name = "dfgjdfgj",
                        Position = "dsfgds",
                        ContactPhone = "2364236",
                        Email = "sdfhdss@gmail.com",
                        Salary = 64333,
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
                        Name = "dfs;lse",
                        Position = "asewq",
                        ContactPhone = "2364236",
                        Email = "sdfhdss@gmail.com",
                        Salary = 568423,
                    },
                    new CompanyEmployees()
                    {
                        Name = "qweqw",
                        Position = "4wuasd",
                        ContactPhone = "9964236",
                        Email = "sdfhdss@gmail.com",
                        Salary = 348534,
                    },
                    new CompanyEmployees()
                    {
                        Name = "assdga",
                        Position = "Manager",
                        ContactPhone = "8674543",
                        Email = "sdfhdss@gmail.com",
                        Salary = 190432,
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
        public void InfoEmployee(IEnumerable<CompanyEmployees> s)
        {
            foreach (CompanyEmployees i in s) Console.WriteLine($"Name - {i.Name}\n" +
                        $"Position - {i.Position}\n" +
                        $"Phone - {i.ContactPhone}\n" +
                        $"Email - {i.Email}\n" +
                        $"Salary - {i.Salary}\n");
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
                                        where i.NameCompany == "Food" select i;
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
                                                    where DateTime.Now.Year - 2 == pr.DateCreate.Year select pr;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where (DateTime.Now - i.DateCreate).Days > 123 select i;
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
                                                    where i.Industry == "Marketing" select i;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.Industry == "IT" select i;
                                        PrintLinq(print); break;
                                    }
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
                                                    where i.Director == "White" select i;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.Director == "Black" && i.NameCompany == "White" select i;
                                        PrintLinq(print); break;
                                    }
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
                                                    where i.CountEmployees > 100 select i;
                                        PrintLinq(print); break;
                                    }
                                case 1:
                                    {
                                        var print = from i in cmp
                                                    where i.CountEmployees >= 100 && i.CountEmployees <= 300
                                                    select i; PrintLinq(print); break;
                                    }
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
                                                    where i.Address == "London" select i;
                                        PrintLinq(print); break;
                                    }
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            int empChoice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                                "All List", ">Samary", "Postion: Manager", "Phone: +23",
                                "Email: +di", "Name: Lionel", "Return back");
                            switch (empChoice)
                            {
                                case 0://all list
                                    {
                                        Console.Write("Enter the Industry : ");
                                        string? str = Console.ReadLine().ToLower();
                                        if (str != null)
                                        {
                                            var emp = from i in cmp
                                                      where i.Industry.ToLower() == str select i;

                                            Console.Clear();
                                            foreach (CompanyInfo j in emp)
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
                                            }
                                            Thread.Sleep(7000);
                                        }
                                        break;
                                    }
                                case 1://samary
                                    {
                                        Console.Write("Enter the Industry : ");
                                        string? str = Console.ReadLine().ToLower();
                                        var emp = (from i in cmp
                                                   where i.Industry.ToLower() == str select i).ToList();
                                        foreach (CompanyInfo item in emp)
                                        {
                                            var k = from i in item.CompanyEmployees
                                                    where i.Salary > 100000 select i;
                                            InfoEmployee(k);
                                        }
                                        Thread.Sleep(30000); break;
                                    }
                                case 2://manager
                                    {
                                        foreach (CompanyInfo item in cmp)
                                        {
                                            var k = from j in item.CompanyEmployees
                                                    where j.Position == "Manager" select j;
                                            InfoEmployee(k);
                                        }
                                        Thread.Sleep(3000); break;
                                    }
                                case 3:// phone
                                    {
                                        foreach (CompanyInfo fh in cmp)
                                        {
                                            var k = from i in fh.CompanyEmployees
                                                  where i.ContactPhone[0] == '2' && i.ContactPhone[1] == '3' select i;
                                            InfoEmployee(k);
                                        }
                                        Thread.Sleep(3000); break;
                                    }
                                case 4: //email
                                    {
                                        foreach (CompanyInfo fh in cmp)
                                        {
                                            var k = from i in fh.CompanyEmployees
                                                      where i.Email[0] == 'd' && i.Email[1] == 'i'
                                                      select i;
                                            InfoEmployee(k);
                                        }
                                        Thread.Sleep(3000); break;
                                    }
                                case 5:// name
                                    {
                                        foreach (CompanyInfo fh in cmp)
                                        {
                                            var k = from i in fh.CompanyEmployees
                                                      where i.Name == "Lionel"
                                                      select i;
                                            InfoEmployee(k);
                                        }
                                        Thread.Sleep(3000); break;
                                    }
                            }
                            break; //return
                        }
                    case 8: return;
                }
            } while (true);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.mainCompany();
        }
    }
}
