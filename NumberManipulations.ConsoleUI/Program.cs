using NumberManipulations.Domain.Numbers;

var number = new Number();
 
number.SetValue(201);

Console.WriteLine("Value: " + number.GetValue());
Console.WriteLine("IsZero: " + number.IsZero());
Console.WriteLine("IsPositive: " + number.IsPositive());
Console.WriteLine("IsNegative: " + number.IsNegative());
Console.WriteLine("IsOdd: " + number.IsOdd());
Console.WriteLine("IsEven: " + number.IsEven());
Console.WriteLine("IsPrime: " + number.IsPrime());
Console.WriteLine($"Power without recursion: {Number.Power(2, 3)}");
Console.WriteLine($"Power with recursion: {Number.Power(2, 3, true)}");
Console.WriteLine("GetCountOfDigits: " + number.GetCountOfDigits());
Console.WriteLine("GetSumOfDigits: " + number.GetSumOfDigits());
Console.WriteLine("GetReverse: " + number.GetReverse());
Console.WriteLine("ToWords: " + number.ToWords());
Console.WriteLine("IsArmstrong: " + number.IsArmstrong());
Console.WriteLine("GetFibonacci: " + number.GetFibonacci());
Console.WriteLine("isPalindrome: " + number.IsPalindrome());