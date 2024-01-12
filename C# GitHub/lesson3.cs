using System.Collections;
using System.Text;
using web;
using matrix;
using static Passport;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

/*1*/

void symbolsSqrt(int line, char sym)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < line; j++) Console.Write(sym.ToString() + ' ');
        Console.WriteLine();
    }
}

symbolsSqrt(9, '*');

/*2*/

bool palindrone(int value)
{
    int size = value.ToString().Length;
    string val = value.ToString();
    for (int i = 0; i < size; i++)
    {
        if (val[i] != val[size - 1 - i])
            return false;
    }
    return true;
}

bool temp = palindrone(345543);
Console.WriteLine($"Palindrone: {temp}");


/*3 */

int[] filtArray(int[] originalArray, int[] filterArray)
{
    Array.Sort(originalArray); Array.Sort(filterArray);
    int[] newArray = new int[originalArray.Length];
    
    for (int i = 0; i < originalArray.Length; i++)
    {
        for (int j = 0; j < filterArray.Length; j++)
        {
        }
    }

    return newArray;
}

int[] orgArr = new int[] { 3, 5, 2, 3, 7, 1, 8, 1 };
int[] filArr = new int[] { 3, 5, 1 };
int[] newArray = filtArray(orgArr, filArr);
foreach (var item in newArray)
{
    Console.Write($"{item} ");
}

//4

WebSite site = new WebSite();
site.NameSite = new WebSite().NameSite;
site.WayToSite = new WebSite().WayToSite;
site.SiteDescription = new WebSite().SiteDescription;
site.IPSite = new WebSite().IPSite;
site.PrintInfo();