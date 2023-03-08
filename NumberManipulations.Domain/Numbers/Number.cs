using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumberManipulations.Domain.Numbers;

public class Number
{
    private int _value;

    public void SetValue(int newValue)
    {
        _value = newValue;
    }

    public double GetValue()
    {
        return _value;
    }

    public bool IsZero()
    {
        return _value == 0;
    }

    public bool IsPositive()
    {
        return _value > 0;
    }

    public bool IsNegative()
    {
        return _value < 0;
    }

    public bool IsOdd()
    {
        return _value % 2 != 0;
    }

    public bool IsEven()
    {
        return _value % 2 == 0;
    }

    public bool IsPrime()
    {
        switch (_value)
        {
            case 1:
                return false;
            case 2:
                return true;
        }

        var limit = Math.Ceiling(Math.Sqrt(_value));

        for (var i = 2; i <= limit; ++i)
        {
            if (_value % i == 0)
                return false;
        }
        return true;
    }

    public static int Power(int baseNumber, int exponent, bool recursive = false)
    {
        switch (recursive)
        {
            case false:

                var power = baseNumber; 

                for (var i = 1; i < exponent; i++)
                {
                    power *= baseNumber;
                }
                return power;
            case true:

                if (exponent == 0)
                {
                    return 1;
                }

                return baseNumber * Power(baseNumber, exponent - 1, true);
        }
    }

    public int GetCountOfDigits()
    {
        switch (_value)
        {
            case 0:
                return 1;
            case < 0:
                var tempValue = _value * -1;
                return (int)Math.Floor(Math.Log10(tempValue) + 1);
            default:
                return (int)Math.Floor(Math.Log10(_value) + 1);
        }
    }

    public int GetSumOfDigits()
    {
        var result = 0 ;

        var tempValue = _value;

        if (_value <= 0)
        {
            tempValue *= -1;
        }

        for (var n = tempValue; n > 0;)
        {
            result += n % 10;
            n /= 10;
        }

        return result;
    }

    public int GetReverse()
    {
        var result = 0;

        var tempValue = _value;

        if (_value < 0)
        {
            tempValue *= -1;
        }

        while (tempValue > 0)
        {
            result = result * 10 + tempValue % 10;
            tempValue /= 10;
        }
        return result;
    }

    public string ToWords()
    {
        var tempValue = _value;

        switch (_value)
        {
            case 0:
                return "Zero";
            case < 0:
                tempValue *= -1;
                break;
        }

        var result = new StringBuilder();
        var digits = new List<int>();

        while (tempValue != 0)
        {
            digits.Add(tempValue % 10);
            tempValue /= 10;
        }

        digits.Reverse();

        foreach (var digit in digits)
        {
            result.Append($"{DigitToWord(digit)} ");
        }

        string DigitToWord(int digit)
        {
            return digit switch
            {
                0 => "Zero",
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nite",
                _ => "Incorrect input"
            };
        }

        return result.ToString();
    }

    public bool IsArmstrong()
    {
        var sum = 0;
        var tempValue = _value;
        var value = _value;

        while (value > 0)
        {
            var remainder = value % 10;
            sum += (remainder * remainder * remainder);
            value /= 10;
        }

        return tempValue == sum;
    }

    public string GetFibonacci()
    {
        var result = new StringBuilder();

        var nextNumber = 0;
        var number = _value;
        var secondNumber = 1;

        switch (number)
        {
            case  0:
                return "0";
            case 1:
                return "0 1";
            case < 0:
                return "Number should be than 0.";
            
        }

        for (var i = 2; nextNumber <= number; i++)
        {
            result.Append($"{nextNumber} ");
            var firstNumber = secondNumber;
            secondNumber = nextNumber;
            nextNumber = firstNumber + secondNumber;
        }

        return result.ToString();
    }

    public bool IsPalindrome()
    {
        var sum = 0;
        var tempValue = _value;
        var value = _value;


        while (value > 0)
        {
            var remainder = value % 10;
            //multiply the sum with 10 and then add the remainder
            sum = (sum * 10) + remainder;
            //Get the quotient by dividing the number with 10 
            value /= 10;
        }

        return tempValue == sum;
    }
}