namespace git_project;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return a / b;
    }
    
    public double Exponentiate(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    public double SquareRoot(double number)
    {
        if (number < 0)
            throw new ArgumentOutOfRangeException("Não é possível calcular a raiz quadrada de um número negativo.");
        return Math.Sqrt(number);
    }
}