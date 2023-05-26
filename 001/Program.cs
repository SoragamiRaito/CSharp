Console.Write("あなたの名前は？: ");
var name = Console.ReadLine();

Console.Write("あなたの年齢は？: ");
var age = int.Parse(Console.ReadLine());

Console.WriteLine("{0}({1}歳)さん、ようこそお越しくださいました。", name, age);