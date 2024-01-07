Random rand = new Random();
Console.InputEncoding = Console.InputEncoding;
Console.OutputEncoding = Console.OutputEncoding;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

//Оголосити одновимірний (5 елементів) масив з назвою 
//A i двовимірний масив (3 рядки, 4 стовпці) дробових чисел 
//з назвою B.
//Заповнити одновимірний масив А числами,
//введеними з клавіатури користувачем, а двовимірний 
//масив В — випадковими числами за допомогою циклів.
//Вивести на екран значення масивів: масиву А — в один 
//рядок, масиву В — у вигляді матриці.

//Знайти у даних масивах загальний максимальний елемент, мінімальний елемент
//загальну суму усіх елементів
//загальний добуток усіх елементів
//суму парних елементів масиву А
//суму непарних стовпців масиву В

//~~~A

int[] A = new int[5];

for (int i = 0; i < A.Length; i++)
{
    Console.Write($"index[{i}]: ");
    int input = Convert.ToInt32(Console.ReadLine());
    A[i] = input;
}

Console.Clear();
foreach (int i in A)
{
    Console.Write(i + " ");
}

Console.WriteLine();

int max = A[0], min = A[0];
int sum = 0, multiply = A[0], add = A[0];
for (int i = 0; i < A.Length; i++)
{
    if (A[i] > max) max = A[i];
    if (A[i] < min) min = A[i];
    sum += A[i]; multiply *= A[i];
    if (A[i] % 2 == 0) add += A[i];
}
Console.WriteLine($"Max: {max}\nMin: {min}\nSum: {sum}" +
    $"\nMultiply: {multiply}\nAdd: {add}\n");

////~~~B

double[,] B = new double[3, 4];

for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        B[i, j] = rand.Next(10);
    }
}

for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        Console.Write($"{B[i, j]} ");
    }
    Console.WriteLine();
}

double maxB = B[0, 0], minB = B[0, 0];
double sumB = 0, multiplyB = B[0, 0], odd = B[0, 0];
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        if (B[i, j] > maxB) maxB = B[i, j];
        if (B[i, j] < minB) minB = B[i, j];
        sumB += B[i, j]; multiplyB *= B[i, j]; //multiply - can have 0. If our range is long
        if (B[i, j] % 2 == 1) odd += B[i, j];
    }
}

Console.WriteLine($"Max: {maxB}\nMin: {minB}\nSum: {sumB}" +
    $"\nMultiply: {multiplyB}\nAdd: {odd}\n");

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

//Дано двовимірний масив розміром 5×5, заповнений випадковими числами з діапазону від –100 до 100. 
//Визначити суму елементів масиву, розташованих між 
//мінімальним і максимальним елементами

int[,] _arr = new int[5, 5];
int _max = _arr[0, 0], _min = _arr[0, 0], _sum = 0;
for (int i = 0; i < _arr.GetLength(0); i++)
{
    for (int j = 0; j < _arr.GetLength(1); j++)
    {
        _arr[i, j] = rand.Next(-100, 100);
    }
}

for (int i = 0; i < _arr.GetLength(0); i++)
{
    for (int j = 0; j < _arr.GetLength(1); j++)
    {
        Console.Write($"{_arr[i, j]} ");
        if (_arr[i, j] > _max) { _max = _arr[i, j]; }
        if (_arr[i, j] < _min) { _min = _arr[i, j]; }
    }
    Console.WriteLine();
}

for (int i = _min; i < _max; i++) _sum += i;
Console.WriteLine($"sum: {_sum}");

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Дізнаюсь на уроці~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

//Користувач вводить рядок із клавіатури. Необхідно 
//зашифрувати цей рядок, використовуючи шифр Цезаря. +++
//Окрім механізму шифрування, реалізуйте механізм 
//розшифрування. ---

int key;
string? encription;
char[] enAlphabet = ['a','b','c','d','e','f','g','h',
'i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'];//26

Console.Write("Text: "); encription = Console.ReadLine();
Console.Write("Key : "); key = Convert.ToInt32(Console.ReadLine());

string[] newEncription = new string[encription.Length]; //початк.спосіб

if (encription != null)
{
    for (int i = 0; i < encription.Length; i++)
        newEncription[i] = ((char)encription[i] + key).ToString();
    for (int i = 0; i < newEncription.Length; i++)
        Console.Write($"{newEncription[i]} ");
}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

//Створіть додаток, який здійснює операції над матрицями:
//■ Множення матриці на число;
//■ Додавання матриць;
//■ Добуток матриць.

int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = rand.Next(1, 10);
}

int[,] _matrixT = new int[4, 4];
for (int i = 0; i < _matrixT.GetLength(0); i++)
{
    for (int j = 0; j < _matrixT.GetLength(1); j++)
        _matrixT[i, j] = rand.Next(1, 10);
}

int value = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = matrix[i, j] * value;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = matrix[i, j] + _matrixT[i, j];
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = matrix[i, j] * _matrixT[i, j];
}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~НЕ ВИКОНАНО ПРАВИЛЬНО! СЧИТУЄ ASCII~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

//Користувач з клавіатури вводить до рядка арифметичний вираз. Додаток має підрахувати його результат. 
//Необхідно дотримуватися лише двох операцій: + і –.

string? lineMath = Convert.ToString(Console.ReadLine());
int result = 0;
for (int i = 0; i < lineMath.Length; i++)
{
    if (lineMath[i] != '+' && lineMath[i] != '-') { lineMath.Split(); }

    if (lineMath[i] == '+') { result += lineMath[i - 1] + lineMath[i + 1]; }
    if (lineMath[i] == '-') { result -= lineMath[i - 1] - lineMath[i + 1]; }
}

Console.WriteLine($"Result: {result}");

//~~~~~~~~~~~~~~~~~~Працює, окрім '.' в кінці речення(*умову по різному вже змінював)~~~~~~~~~~~~~~~~~~~~~~//

//Користувач з клавіатури вводить певний текст. Додаток 
//має змінювати регістр першої літери кожного речення на 
//літеру у верхньому регістрі.

string? text;
Console.Write("Text: "); text = Console.ReadLine();
string[] newTxt = new string[text.Length];
newTxt[0] = text[0].ToString().ToUpper();

for (int i = 1; i < text.Length; i++)
{
    newTxt[i] = text[i].ToString().ToLower();
    if (newTxt[i].Length != '.')
    {
        if (text[i] == '.' && text[++i] != ' ')
        { newTxt[i] = text[i].ToString().ToUpper(); }
        else if (text[i - 1] == '.' && text[i] == ' ')
        { i++; newTxt[i] = text[i].ToString().ToUpper(); }
    }
}

foreach (string str in newTxt) { Console.Write(str); }

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//