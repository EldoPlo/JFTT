using Antlr4.Runtime;
using System;


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

            var inputStream = new AntlrInputStream(input + Environment.NewLine);
            var lexer = new z1Lexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new z1Parser(tokenStream);
            Console.WriteLine($"Parse tree: {parser.line().ToStringTree(parser)}");    
            var visitor = new EvalVisitor();
            try
            {
                var result = visitor.Visit(parser.line());
                Console.WriteLine($"Returned result from Visit: {result}");
                Console.WriteLine($"= {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
