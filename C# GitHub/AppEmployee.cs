using Menu;
using System.Collections;

namespace App
{
    class Employee
    {
        //Regex regex;
        public string? Name { get; set; } = "N:Note";
        public string? Position { get; set; } = "P:Note";
        public int? Salary { get; set; } = 0;
        public string? Email { get; set; } = "E:Note";

        protected void ClearComponentsEmpoyee()
        {
            Name = null; Position = null; Salary = null; Email = null;
        }
    }
    class AppEmployee : Employee, IEnumerable
    {
        List<Employee> app = new List<Employee>()
        {
            new Employee()
            {
                Name = "Gololobov Serhiy Anatoliyovych",
                Position = "Sheriff",
                Salary = 410000,
                Email = "GSSa02_1@mail.com"
            },
            new Employee()
            {
                Name = "Protsenko Roman Mykolayovych",
                Position = "Detective",
                Salary = 101302,
                Email = "PRM2311@mail.com"
            },
            new Employee()
            {
                Name = "Reznichenko Angelina Oleksandivna",
                Position = "Detective",
                Salary = 101302,
                Email = "gk043df@mail.com"
            },
            new Employee()
            {
                Name = "Vashchenko Vladislav Konstantinovych",
                Position = "Sergeant",
                Salary = 100899,
                Email = "002LSds_@mail.com"
            },
            new Employee()
            {
                Name = "Andrievsky Slava Pavlovich",
                Position = "Sergeant",
                Salary = 100899,
                Email = "95_34Gd2@mail.com"
            },
        };
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu ~\n~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                "Add Employee", "Delete Employee",
                "Change Info", "Find with Params",
                "Sort Employees", "Print Empoyees", "Exit the Program");
                switch (choice)
                {
                    case 0: AddEmployee(); break;
                    case 1: DeleteEmployee(); break;
                    case 2: ChangeInfoEmployee(); break;
                    case 3: FindEmployee(); break;
                    case 4: SortEmployees(); break;
                    case 5: PrintEmployee(); break;
                    case 6: return;
                }
            } while (true);
        }
        /*                                 ADD EMPOYEE                                 */
        void AddEmployee()
        {
            ClearComponentsEmpoyee(); // clear our list employee
            do
            {
                Console.Clear();
                Console.WriteLine("Add Employee ~\n~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Name", "Position", "Salary", "Email", "Exit");
                switch (choice)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.Write("Surname FirstName Patronymic: ");
                            Name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Add Position: ");
                            Position = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("Add Salary: ");
                            Salary = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Add Email: ");
                            Email = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            if (Name != null && Position != null && Email != null)
                            {
                                app.Add(new Employee
                                {
                                    Name = Name,
                                    Position = Position,
                                    Salary = Salary,
                                    Email = Email
                                });
                            }
                            else
                            {
                                Console.WriteLine("Your databases is not saved!");
                                ClearComponentsEmpoyee(); // clear our list employee
                                Console.ReadKey();
                            }
                            return;
                        }
                }
            } while (true);
        }
        /*                                 DELETE EMPLOYEE                                 */
        public void DeleteEmployee()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Delete Employee ~\n~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "IndexDel", "Return Back");
                switch (choice)
                {
                    case 0: IndexDel(); break;
                    case 1: return;
                }
            } while (true);
        }

        public void IndexDel()
        {
            do
            {
                Console.Clear();
                Console.Write("Index employee: ");
                int index = Convert.ToInt32(Console.ReadLine());
                app.Remove(app[index]);
                Console.WriteLine("Delete Employee+ ~\n~~~~~~~~~Exit :: Enter");
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
        /*                                 Charge Information                                 */
        public void ChangeInfoEmployee()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Change Information ~\n~~~~~~~~~~~~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Index Empoyee", "Exit");
                switch (choice)
                {
                    case 0:
                        {
                            Console.Write("Input index: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            if (index >= 0 && index < app.Count) ChargeEmployeeIndex(index);
                            break;
                        }
                    case 1: return;
                }
            } while (true);
        }
        /*                                 Print Change                                 */
        public void PrintChangeEmployee(int index)
        {
            do
            {
                Console.Clear();
                int temp = app[0].Name.Length;
                Console.WriteLine($"Index: {"".PadCenter(temp / 2 + 3) + index}");
                Console.WriteLine($"Name: {app[index].Name.PadCenter(temp + 5)}\nPosition: {app[index].Position.PadCenter(temp)}\n" +
                $"Salary:{"".PadCenter(temp / 2)}{app[index].Salary + "$"}\nEmail: {app[index].Email.PadCenter(temp + 5)}");
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
        public void ChargeEmployeeIndex(int index)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Change Information ~\n~~~~~~~~~~~~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Name", "Position", "Salary", "Email", "Print", "Return Back");
                switch (choice)
                {

                    case 0:
                        {
                            Console.Write("New Name: ");
                            string? str = Console.ReadLine();
                            if (str != null) 
                                app[index].Name = str;
                            break;
                        }
                    case 1:
                        {
                            Console.Write("New Position: ");
                            string? str = Console.ReadLine();
                            if (str != null) 
                                app[index].Position = str;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("New Salary: ");
                            int input; int.TryParse(Console.ReadLine(), out input);
                            if (input > 0 && input < int.MaxValue)
                            {
                                app[index].Salary = input;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("New Email: ");
                            string? str = Console.ReadLine();
                            if (str != null) 
                                app[index].Email = str;
                            break;
                        }
                    case 4:
                        {
                            PrintChangeEmployee(index);
                            Console.ReadLine();
                            break;
                        }
                    case 5: return;
                }
            } while (true);
        }
        /*                                 Find Employee                                 */
        public void FindEmployee()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Find Employee ~\n~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Name", "Position", "Salary", "Email", "Exit");
                switch (choice)
                {
                    case 0:
                        {
                            Console.Write("Find: ");
                            string str = Console.ReadLine();
                            var search = app.Where(x => x.Name == str).ToList();
                            search.ForEach(x => Console.WriteLine(x.Name));
                            Thread.Sleep(1000); break;
                        }
                    case 1:
                        {
                            Console.Write("Find: ");
                            string str = Console.ReadLine();
                            var search = app.Where(x => x.Position == str).ToList();
                            search.ForEach(x => Console.WriteLine(x.Position));
                            Thread.Sleep(1000); break;
                        }
                    case 2:
                        {
                            Console.Write("Find: ");
                            int input = Convert.ToInt32(Console.ReadLine());
                            var search = app.Where(x => x.Salary == input).ToList();
                            search.ForEach(x => Console.WriteLine(x.Salary));
                            Thread.Sleep(1000); break;
                        }
                    case 3:
                        {
                            Console.Write("Find: ");
                            string str = Console.ReadLine();
                            var search = app.Where(x => x.Email == str).ToList();
                            search.ForEach(x => Console.WriteLine(x.Email));
                            Thread.Sleep(1000); break;
                        }
                    case 4: return;
                }
            } while (true);
        }
        /*                                 Sort Employees                                */
        public void SortEmployees()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Sort Employee ~\n~~~~~~~~~");
                int choice = ConsoleMenu.SelectVertical(HPosition.Center, VPosition.Center, HorizontalAlignment.Center,
                    "Name", "Position", "Salary", "Email", "Exit");
                switch (choice)
                {
                    case 0: { 
                            app.Sort((s1, s2) => s1.Name.CompareTo(s2.Name)); break; 
                    }
                    case 1: { 
                            app.Sort((s1, s2) => s1.Position.CompareTo(s2.Position)); break; 
                    }
                    case 2: { 
                            app.Sort((s1, s2) => s2.Salary.ToString().CompareTo(s1.Salary)); break; 
                    }
                    case 3: { 
                            app.Sort((s1, s2) => s1.Email.CompareTo(s2.Email)); break;
                    }
                    case 4: return;
                }
            } while (true);
        }
        /*                                 Print Employees                                */
        public void PrintEmployee()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Print Employee ~\n~~~~~~~~~");
                int temp = app[0].Name.Length;
                int k = 0;
                while (k < app.Count)
                {
                    foreach (Employee i in app)
                    {
                        Console.WriteLine($"Index: {"".PadCenter(temp / 2 + 3) + k}");
                        Console.WriteLine($"Name: {i.Name.PadCenter(temp + 5)}\nPosition: {i.Position.PadCenter(temp)}\n" +
                            $"Salary:{"".PadCenter(temp / 2)}{i.Salary + "$"}\nEmail: {i.Email.PadCenter(temp + 5)}");
                        Console.WriteLine('\n' + $"{(char)176}".Mult(temp + 10));
                        ++k;
                    }
                    Console.WriteLine("\n~~~~~~~~~Exit :: Enter");
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter); //<--в інеті такий цікавий спосіб подивився, бо невідображало список
        }
        public AppEmployee this[int index]
        {
            get { return (AppEmployee)app[index]; }
            set { if (index >= 0 | index <= app.Count) app[index] = value; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            /*yield*/ return app.GetEnumerator();
        }
    }
}
