using System.ComponentModel.Design;

Console.WriteLine("Please enter your first number");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter your second number");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the symbol for the math you wish to do");
char math = char.Parse(Console.ReadLine());

switch (math)
{
    case '+':
        Console.WriteLine($"{num1} + {num2} =  {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($" {num1} - {num2} = {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case '/':
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
}

Console.ReadLine();
