//***Користувач вводить з клавіатури число від 1 до 100. 
//Якщо число кратне 3 (ділиться на 3 без залишку), потрібно 
//вивести слово Fizz. Якщо число кратне 5, потрібно вивести 
//слово Buzz. Якщо число кратне 3 і 5, потрібно вивести Fizz
//Buzz. Якщо число не кратне ні 3, ані 5, потрібно вивести 
//тільки число.
//Якщо користувач ввів значення не в діапазоні від 1
//до 100, потрібно вивести повідомлення про помилку.

int inputUserNum = Convert.ToInt32(Console.ReadLine());
if (inputUserNum >= 1 && inputUserNum <= 100)
{
    if (inputUserNum % 3 == 0) Console.WriteLine("Fizz");
    else if (inputUserNum % 5 == 0) Console.WriteLine("Buzz");
    else if (inputUserNum % 3 == 0 && inputUserNum % 5 == 0) Console.WriteLine("Fizz Buzz");
    else Console.WriteLine(inputUserNum);
}
else Console.WriteLine("Range error!");

//***Користувач вводить з клавіатури два числа. Перше 
//число — це значення, друге число — відсоток, який необхідно підрахувати. Наприклад, ми ввели з клавіатури 
//90 і 10. Потрібно вивести на екран 10 відсотків від 90. 
//Результат: 9

Console.Write("Enter a numeric value: "); int value = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value in interest: "); int interest = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result: {value / interest}");

//***Користувач вводить з клавіатури чотири цифри. Необхідно створити число, яке містить ці цифри.
//Наприрклад, якщо з клавіатури введено 1, 5, 7, 8 тоді потрібно 
//сформувати число 1578

int fNum, sNum, tNum, foNum;
Console.Write("Enter the first value: "); fNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second value: "); sNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the three value: "); tNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the four value: "); foNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"Result: {fNum * 1000 + sNum * 100 + tNum * 10 + foNum}");

//***Користувач вводить шестизначне число. Потім, користувач вводить номери розрядів для заміни цифр. 
//Наприклад, якщо користувач ввів 1 і 6 — це означає, що 
//треба поміняти місцями першу та шосту цифри. 
//Число 723895 має перетворитися на 523897.
//Якщо користувач ввів не шестизначне число, потрібно 
//вивести повідомлення про помилку.

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

//***Користувач вводить з клавіатури дату. Додаток має 
//відобразити назву пори року і дня тижня. Наприклад,
//якщо введено 22.12.2021, додаток має відобразити Winter 
//Wednesday.


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

//Користувач вводить з клавіатури показання температури. Залежно від вибору користувача, додаток конвертує 
//температуру з Фаренгейта в Цельсій, або навпаки. 

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

//Користувач вводить з клавіатури два числа. Потрібно показати усі парні числа у вказаному діапазоні. Якщо 
//межі діапазону вказані неправильно, потрібно провести 
//нормалізацію кордонів. Наприклад, користувач ввів 20 і 
//11. Потрібна нормалізація, після якої початок діапазону 
//дорівнюватиме 11, а кінець дорівнюватиме 20.

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


