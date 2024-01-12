/*Створіть клас «Веб-сайт».*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web
{
    public class WebSite
    {

        private string nameSite = "IT UA";
        private string wayToSite = "https://it.com";
        private string siteDescription = "Just a Site";
        private string ipSite = "121.0.0.1";

        public WebSite() { }
        public WebSite(string nameSite, string wayToSite, string siteDescription, string ipSite)
        {
            this.nameSite = nameSite; this.wayToSite = wayToSite;
            this.siteDescription = siteDescription; this.ipSite = ipSite;
        }
        public string NameSite 
        {   
            get { return nameSite; }
            set
            {
                Console.Write("New Site: "); string? input = Console.ReadLine();
                if (input != null && input.Length < 30) nameSite = input;
                else nameSite = "None";
            }
        }
        public string WayToSite 
        { 
            get { return wayToSite; }
            set
            {
                Console.Write("Way to..: "); string? input = Console.ReadLine();
                if (input != null && input.Length < 100) wayToSite = input;
                else wayToSite = "None";
            }
        }
        public string SiteDescription 
        { 
            get { return siteDescription; }
            set
            {
                Console.Write("Description: "); string? input = Console.ReadLine();
                if (input != null && input.Length < 150) siteDescription = input;
                else siteDescription = "None";
            }
        }
        public string IPSite 
        { 
            get { return ipSite; }
            set
            {
                Console.Write("IP Adress: "); string? input = Console.ReadLine();
                if (input != null && input.Length < 150) ipSite = input;
                else ipSite = "121.0.0.1";
            }
        }
        public void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine($"Name: {nameSite}\nWay To Site: {wayToSite}\n" +
                $"Description: {siteDescription}\nIP: {ipSite}");
        }
    }
}
