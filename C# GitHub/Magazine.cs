using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgz
{
    public class Magazine
    {
        private string nameMagazine { get; set; } = "None";
        private int? yearOfFoundation { get; set; } = 0;
        private string descriptionMagazine { get; set; } = "None";
        private string contactPhone { get; set; } = "0021";
        private string email { get; set; } = "None@mail.com";
        private int? employee { get; set; } = 0;

        public void setNameMagazine()
        {
            Console.Write("name magazine: "); string? str = Console.ReadLine();
            if (str != null && str.Length < 30) { nameMagazine = str; }
        }
        public void setYearMagazine() 
        {  
            Console.Write("Year: "); int? input = Convert.ToInt32(Console.ReadLine()); 
            if (input != null && input >= 0) { yearOfFoundation = input; }
        } 
        public void setDescriptionMagazine() 
        {  
            Console.Write("Description: "); string? str = Console.ReadLine();
            if (str != null && str.Length <= 100) {  descriptionMagazine = str; }
        }
        public void setContactPhone()
        {
            Console.Write("Phone: "); string? str = Console.ReadLine();
            if (str != null && str.Length >= 0 && str.Length <= 15) { contactPhone = str; }
        }
        public void setEmailAdress()
        {
            Console.Write("Email: "); string? str = Console.ReadLine();
            if (str != null && str.Length <= 30) { email = str; }
        }
        public void setEmployees()
        {
            Console.Write("Empoyee(s): "); int? input = Convert.ToInt32(Console.ReadLine());
            if (input != null && input >= 0 && input <= int.MaxValue) { employee = input; }
        }

        public static Magazine operator+(Magazine m, int Employees)
        {
            m.employee += Employees;
            return m;
        }
        public static Magazine operator-(Magazine m, int Employees)
        {
            m.employee -= Employees;
            return  m;
        }
        public static bool operator ==(Magazine m1, Magazine m2)
        {
            return m1.employee == m2.employee? true : false;
        }
        public static bool operator !=(Magazine m1, Magazine m2)
        {
            return m1.employee != m2.employee ? true : false;
        }
        public static bool operator >(Magazine m1, Magazine m2)
        {
            return m1.employee > m2.employee ? true : false;
        }
        public static bool operator <(Magazine m1, Magazine m2)
        {
            return m1.employee < m2.employee ? true : false;
        }
        public void informationMagazie()
        {
            Console.WriteLine($"Name: {nameMagazine}\nYear: {yearOfFoundation}" +
                $"\nDescription: {descriptionMagazine}\nPhone: {contactPhone}" +
                $"\nEmail: {email}\nEmployee: {employee}");
        }

    }
}
