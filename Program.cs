Console.WriteLine("Начало тестовой задачи");

string[] Arr;
Console.WriteLine("Введите массив трёх строк через пробел");
string val = Console.ReadLine();
Arr = val.Split(' ');
var result = new string[Arr.Length];
var realSize = 0;
foreach (var value in Arr )
    {
        if (value.Length <= 3)
        {
            result[realSize] = value;
            realSize++;
        }
    }
Console.WriteLine("Строки с символами равными или менее трёх: ");
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));