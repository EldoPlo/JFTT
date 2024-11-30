using Antlr4.Runtime;
using System;
using Z1;

public class Program
{
    private const int BASE = 1234577;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;

            var inputStream = new AntlrInputStream(input);
            var lexer = new Z1Lexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new Z1Parser(tokenStream);

            var visitor = new EvalVisitor();
            try
            {
                var result = visitor.Visit(parser.line());
                Console.WriteLine($"= {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
