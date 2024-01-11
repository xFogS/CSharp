//1

int inputUserNum = Convert.ToInt32(Console.ReadLine());
if (inputUserNum >= 1 && inputUserNum <= 100)
{
    if (inputUserNum % 3 == 0) Console.WriteLine("Fizz");
    else if (inputUserNum % 5 == 0) Console.WriteLine("Buzz");
    else if (inputUserNum % 3 == 0 && inputUserNum % 5 == 0) Console.WriteLine("Fizz Buzz");
    else Console.WriteLine(inputUserNum);
}
else Console.WriteLine("Range error!");

//2

Console.Write("Enter a numeric value: "); int value = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value in interest: "); int interest = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result: {value / interest}");

//3

int fNum, sNum, tNum, foNum;
Console.Write("Enter the first value: "); fNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second value: "); sNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the three value: "); tNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the four value: "); foNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"Result: {fNum * 1000 + sNum * 100 + tNum * 10 + foNum}");

//4

Console.Write("Enter the value number: "); int sixValue = Convert.ToInt32(Console.ReadLine());
int m = 0;
if (sixValue >= 111111 && sixValue <= 999999)
{
    while (sixValue > 0)
    {
        int temp = sixValue % 10;
        m = m * 10 + temp;
        sixValue /= 10;
    }
    Console.WriteLine(m);
}
else
    Console.WriteLine("Input Error number");

//5


Console.Write("Date: "); DateTime date = Convert.ToDateTime(Console.ReadLine());

switch (date.Month)
{
    case 12: case 1: case 2: Console.WriteLine($"Winter {date.DayOfWeek}"); break;
    case 3: case 4: case 5: Console.WriteLine($"Spring {date.DayOfWeek}"); break;
    case 6: case 7: case 8: Console.WriteLine($"Summer {date.DayOfWeek}"); break;
    case 9: case 10: case 11: Console.WriteLine($"Autumn {date.DayOfWeek}"); break;
    default:
        Console.WriteLine("Month from 1 to 12"); break;
}

//6
Console.WriteLine("1. with Fahrenheit in Celsius\n2. with Celsius in Fahrenheit");
int _userInp = Convert.ToInt32(Console.ReadLine());

Console.Clear(); // clear our window. 

double fahrenheit = 0, celsius = 0;
switch (_userInp)
{
    case 1:
        {
            Console.Write("Enter the value in Fahrenheit: ");
            fahrenheit = Convert.ToSingle(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9; Console.WriteLine($"Result: {celsius}");
            break;
        }
    case 2:
        Console.Write("Enter the value in Celsius: ");
        celsius = Convert.ToSingle(Console.ReadLine());
        fahrenheit = celsius * 9 / 5 + 32; Console.WriteLine($"Result: {fahrenheit}");
        break;
    default:
        Console.WriteLine("Input error!"); break;
}

//7

int startRange, endRange;
Console.Write("Start pos: "); startRange = Convert.ToInt32(Console.ReadLine());
Console.Write("End pos: "); endRange = Convert.ToInt32(Console.ReadLine());

while (startRange != endRange)
{
    if (startRange > endRange)
    {
        Console.WriteLine("pos++");
        int temp = startRange; //save start position
        startRange = endRange; endRange = temp;
    }
    for (int i = startRange; i <= endRange; i++)
        Console.Write(i + " ");
    break;
}


