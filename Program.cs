bool isRunningProgram = false;
while (!isRunningProgram)
{
    // make welcome text.
    System.Console.WriteLine($"Hello, Welcome!!!");

    // make user input.
    System.Console.Write($"Input the first number: ");
    string inputNumber1 = Console.ReadLine();
    int firstNumber = int.Parse(inputNumber1);

    System.Console.Write($"Input the second number: ");
    string inputNumber2 = Console.ReadLine();
    int secondNumber = int.Parse(inputNumber2);

    // create view user choice
    System.Console.WriteLine($"What do you want to do with those numbers?");
    System.Console.WriteLine($"[A]dd");
    System.Console.WriteLine($"[S]ubract");
    System.Console.WriteLine($"[M]ultiply");
    System.Console.WriteLine($"[D]ivide");
    System.Console.WriteLine($"[E]xit");
    string selectedOption = Console.ReadLine();

    // create logical selected option
    int result;
    if (selectedOption == "")
    {
        System.Console.WriteLine("Invalid input");
    }
    else if (selectedOption == "a" || selectedOption == "A")
    {
        result = AddEquation(firstNumber, secondNumber);
        PrintTextEquation(firstNumber, "+", secondNumber, result);
    }
    else if (selectedOption == "s" || selectedOption == "S")
    {
        result = SubtractEquation(firstNumber, secondNumber);
        PrintTextEquation(firstNumber, "-", secondNumber, result);
    }
    else if (selectedOption == "m" || selectedOption == "M")
    {
        result = MultiplyEquation(firstNumber, secondNumber);
        PrintTextEquation(firstNumber, "*", secondNumber, result);
    }
    else if (selectedOption == "d" || selectedOption == "D")
    {
        result = DivideEquation(firstNumber, secondNumber);
        PrintTextEquation(firstNumber, "/", secondNumber, result);
    }
    else if (selectedOption == "e" || selectedOption == "E")
    {
        System.Console.WriteLine($"Want to Exit? Good Bye :)");
        isRunningProgram = true;
    }
    else
    {
        System.Console.WriteLine("${Invalid Input.}");
    }
    System.Console.WriteLine("Press any key to continue previous action.");
    Console.ReadKey();
}

// create method equation
static int AddEquation(int number1, int number2) => number1 + number2;
static int SubtractEquation(int number1, int number2) => number1 - number2;
static int MultiplyEquation(int number1, int number2) => number1 * number2;
static int DivideEquation(int number1, int number2) => number1 / number2;

// create method print equation
void PrintTextEquation(int number1, string @operator, int number2, int result1)
{
    System.Console.WriteLine($"The result {number1} {@operator} {number2} = {result1}");
}