using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        string _GetFractionString = GetFractionString(_top, _bottom);
        Console.WriteLine(_GetFractionString);
        double _GetDecimal = GetDecimalValue(_top, _bottom);
        Console.WriteLine(_GetDecimal);
    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
        string _GetFractionString = GetFractionString(_top, _bottom);
        Console.WriteLine(_GetFractionString);
        double _GetDecimal = GetDecimalValue(_top, _bottom);
        Console.WriteLine(_GetDecimal);
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        string _GetFractionString = GetFractionString(_top, _bottom);
        Console.WriteLine(_GetFractionString);
        double _GetDecimal = GetDecimalValue(_top, _bottom);
        Console.WriteLine(_GetDecimal);
    }
    public string GetFractionString(int top, int bottom)
    {
        string _fraction = ($"{top} / {bottom}");
        return _fraction;
    }
    public double GetDecimalValue(int top, int bottom)
    {
        double x = top;
        double y = bottom;
        double _decimal = x/y;
        return _decimal;
    }
}