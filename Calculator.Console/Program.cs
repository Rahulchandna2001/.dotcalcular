using Calculator;

bool exit = false;

while (!exit)
{
    Prompts.PrintWelcomeMenu();
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();

    if (OptionChoice == "5")
    {
        exit = true;
        Console.WriteLine("Exiting the application...Thanks!");
        break;
    }

    Console.WriteLine("Enter number 1: ");
    string? Number1 = Console.ReadLine();
    Console.WriteLine("Enter number 2: ");
    string? Number2 = Console.ReadLine();

    if (!float.TryParse(Number1, out float Number1Converted) || !float.TryParse(Number2, out float Number2Converted))
    {
        Console.WriteLine("Invalid number format. Please enter valid numbers.");
        continue;
    }

    switch (OptionChoice)
    {
        case "1":
            float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
            break;
        case "2":
            float Subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} - {Number2Converted} = {Subtract}");
            break;
        case "3":
            float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
            Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
            break;
        case "4":
            if (Number2Converted != 0)
            {
                float Divide = Evaluator.Eval("/", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} / {Number2Converted} = {Divide}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero. Please enter a valid number for division.");
            }
            break;
        default:
            Console.WriteLine("Unimplemented option. Please enter a valid option.");
            break;
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine(); // Wait for user to press Enter before continuing
}
