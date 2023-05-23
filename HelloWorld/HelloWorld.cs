// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 10;
Console.WriteLine(i);

double x = 1.0;
Console.WriteLine(x);

var j = 10;
Console.WriteLine(j);

var y = 1.0;
Console.WriteLine(y);

Console.WriteLine(x + y);
Console.WriteLine(x - y);
Console.WriteLine(x * y);
Console.WriteLine(x / y);

string s = "サンプルテキスト";
Console.WriteLine(s + "追記。");
Console.WriteLine(
    string.Format("({0}, {1})", 10, 20)
);

int[] array = new[] { 1, 2, 3, 4, 5 };

i = 0;
while (i < 5)
{
    Console.WriteLine(array[i]);
    i++;
}

for (i = 0; i < 5; i++)
{
    Console.WriteLine(array[i]);
}

foreach (var k in array)
{
    if (k % 2 == 0)
        Console.WriteLine("偶数");
}