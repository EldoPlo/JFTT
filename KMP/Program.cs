using Lista_1.KMP;

if (args.Length != 2)
{
    Console.WriteLine("Invalid number of arguments! Usage: <pattern> <filename>");
    return;
}

var pattern = args[0];
var text = args[1];

var txt = File.ReadAllText(text);

var result = Kmp.KmpSearch(pattern, txt);

result.PrintResult();