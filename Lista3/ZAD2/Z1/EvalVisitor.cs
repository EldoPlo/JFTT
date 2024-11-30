using System;
using Z1;

public class EvalVisitor : Z1BaseVisitor<int>
{
    private const int BASE = 1234577;

    public override int VisitAdd(Z1Parser.AddContext context)
    {
        var left = Visit(context.expr(0));
        var right = Visit(context.expr(1));
        return Mod(left + right, BASE);
    }

    public override int VisitSubtract(Z1Parser.SubtractContext context)
    {
        var left = Visit(context.expr(0));
        var right = Visit(context.expr(1));
        return Mod(left - right, BASE);
    }

    public override int VisitMultiply(Z1Parser.MultiplyContext context)
    {
        var left = Visit(context.expr(0));
        var right = Visit(context.expr(1));
        return Mul(left, right, BASE);
    }

    public override int VisitDivide(Z1Parser.DivideContext context)
    {
        var left = Visit(context.expr(0));
        var right = Visit(context.expr(1));
        return ModDiv(left, right);
    }

    public override int VisitPower(Z1Parser.PowerContext context)
    {
        var baseValue = Visit(context.expr(0));
        var exp = Visit(context.powexpr());
        return ModPow(baseValue, exp);
    }

    public override int VisitNegate(Z1Parser.NegateContext context)
    {
        var value = Visit(context.expr());
        return Mod(-value, BASE);
    }

    public override int VisitNumber(Z1Parser.NumberContext context)
    {
        return Mod(int.Parse(context.NUM().GetText()), BASE);
    }

    private int Mul(int x, int y, int n)
    {
        int result = 0;
        for (int i = 0; i < x; i++)
        {
            result = (result + y % n) % n;
        }
        return result;
    }

    private int Mod(int x, int n)
    {
        while (x < 0)
        {
            x += n;
        }
        return x % n;
    }

    private int ModPow(int baseValue, int exp)
    {
        int result = 1;
        for (int i = 0; i < exp; i++)
        {
            result = (result * baseValue) % BASE;
        }
        return result;
    }

    private int GcdExtended(int a, int b, out int x, out int y)
    {
        if (a == 0)
        {
            x = 0;
            y = 1;
            return b;
        }

        int gcd = GcdExtended(b % a, a, out int x1, out int y1);
        x = y1 - (b / a) * x1;
        y = x1;
        return gcd;
    }

    private int ModInverse(int a)
    {
        int x, y;
        int gcd = GcdExtended(a, BASE, out x, out y);
        if (gcd != 1)
        {
            throw new Exception("Inverse does not exist");
        }
        return Mod(x, BASE);
    }

    private int ModDiv(int x, int y)
    {
        return Mul(x, ModInverse(y), BASE);
    }
}
