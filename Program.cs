// make welcome text.
System.Console.WriteLine($"Hello, Welcome!!!");

// make user input.
System.Console.WriteLine($"Input the first number: ");
string inputNumber1 = Console.ReadLine();
int firstNumber = int.Parse(inputNumber1);

System.Console.WriteLine($"Input the second number: ");
string inputNumber2 = Console.ReadLine();
int secondNumber = int.Parse(inputNumber2);

// create view user choice
System.Console.WriteLine($"What do you want to do with those numbers?");
System.Console.WriteLine($"[A]dd");
System.Console.WriteLine($"[S]ubract");
System.Console.WriteLine($"[M]ultiply");
System.Console.WriteLine($"[D]ivide");
string selectedOption = Console.ReadLine().ToLower();

// create logical selected option
int result;
if (selectedOption == "")
{
    System.Console.WriteLine("Invalid input");
}
else if (selectedOption == "a")
{
    result = firstNumber + secondNumber;
    System.Console.WriteLine(result);
}
else if (selectedOption == "s")
{
    result = firstNumber - secondNumber;
    System.Console.WriteLine(result);
}
else if (selectedOption == "m")
{
    result = firstNumber * secondNumber;
    System.Console.WriteLine(result);
}
else if (selectedOption == "d")
{
    result = firstNumber / secondNumber;
    System.Console.WriteLine(result);
}