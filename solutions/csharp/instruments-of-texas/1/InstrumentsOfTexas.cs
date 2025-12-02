public class CalculationException : Exception
{
    public CalculationException(int operand1, int operand2, string message, Exception inner)
    // TODO: complete the definition of the constructor
    {
        this.Operand1 = operand1;
        this.Operand2 = operand2;
        this.Message = message;
        this.Inner = inner;
    }

    public int Operand1 { get; }
    public int Operand2 { get; }
    public string Message { get; }
    public Exception Inner { get; }
}

public class CalculatorTestHarness
{
    private Calculator calculator;

    public CalculatorTestHarness(Calculator calculator)
    {
        this.calculator = calculator;
    }

    public string TestMultiplication(int x, int y)
    {
        const string success = "Multiply succeeded";
        const string negativeFailure = "Multiply failed for negative operands. Arithmetic operation resulted in an overflow.";
        const string positiveFailure = "Multiply failed for mixed or positive operands. {0}";

        try
        {
            Multiply(x, y);
        }
        catch (CalculationException ex) when (ex.Message.Equals("Arithmetic operation resulted in an overflow.")
                                             && x < 0 && y < 0)
        {
            return negativeFailure;
        }
        catch (CalculationException ex) 
        {
            return String.Format(positiveFailure, ex.Message);
        }

        return success;
    }

    public void Multiply(int x, int y)
    {
        try
        {
            calculator.Multiply(x, y);
        }
        catch (Exception ex)
        {
            throw new CalculationException(x, y, ex.Message, ex);
        }
    }
}


// Please do not modify the code below.
// If there is an overflow in the multiplication operation
// then a System.OverflowException is thrown.
public class Calculator
{
    public int Multiply(int x, int y)
    {
        checked
        {
            return x * y;
        }
    }
}
