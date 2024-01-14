using System.Collections;
using System.Text;
using mgz;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Magazine magazine = new Magazine();
Magazine magazine2 = new Magazine();
magazine.setEmployees();
magazine2.setEmployees();
magazine += 9;
if (magazine != magazine2)
{
    Console.WriteLine("true");
}
else { Console.WriteLine("false"); }
magazine.informationMagazie();


