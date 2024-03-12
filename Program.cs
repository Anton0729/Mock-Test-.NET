using System;
/*
// Task 3


class AddressProgram
{
    static void Main(string[] args)
    {
        char addresseeType = AskYesNoQuestion("Is the addressee a company? [y/n]");

        string salutation = "";
        string firstName = "";
        string lastName = "";
        string companyName = "";
        string streetName = "";
        string streetNumber = "";
        string contactInfo = "";

        if (addresseeType == 'y')
        {
            companyName = ReadField("Company name: ");
            streetName = ReadField("Street name: ");
            streetNumber = ReadField("Street number: ");
            contactInfo = ReadField("Contact info: ");
        }
        else
        {
            salutation = ReadField("Salutation: ");
            firstName = ReadField("First name: ");
            lastName = ReadField("Last name: ");
            streetName = ReadField("Street name: ");
            streetNumber = ReadField("Street number: ");
            contactInfo = ReadField("Contact info: ");
        }

        Console.WriteLine("\nAddress Information:");
        if (addresseeType == 'y')
        {
            DisplayField("Company name", companyName);
        }
        else
        {
            DisplayField("Salutation", salutation);
            DisplayField("First name", firstName);
            DisplayField("Last name", lastName);
        }
        DisplayField("Street", $"{streetName} {streetNumber}");
        DisplayField("Contact info", contactInfo);

        WaitForAnyKey();
    }

    static string ReadField(string fieldName)
    {
        Console.Write(fieldName);
        return Console.ReadLine();
    }

    static void DisplayField(string fieldName, string fieldValue)
    {
        Console.WriteLine($"{fieldName}: {fieldValue}");
    }

    static char AskYesNoQuestion(string question)
    {
        Console.Write(question);
        char response = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        return response;
    }

    static void WaitForAnyKey()
    {
        Console.WriteLine("\nPress any key to end the program...");
        Console.ReadKey();
    }
}
*/


/*
// Task 4

class Program
{
    static void Main(string[] args)
    {
        int minResult = Min(5, 10, 3);
        Console.WriteLine($"Minimum value is: {minResult}");

        int maxResult = Max(5, 10, 3);
        Console.WriteLine($"Maximum value is: {maxResult}");
    }

    static int Min(int n1, int n2, int n3)
    {
        return Math.Min(Math.Min(n1, n2), n3);
    }

    static int Max(int n1, int n2, int n3)
    {
        return Math.Max(Math.Max(n1, n2), n3);
    }
}
*/


/*
// Task 5

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Call the function to swap values
        SwapInts(ref a, ref b);

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }

    static void SwapInts(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
*/




/*
// Task 6


class Program
{
    static void Main(string[] args)
    {
        double number1 = 1.4;
        double number2 = 1.5;
        Console.WriteLine($"Numbers before function {number1} and {number2}");
        Console.WriteLine($"Numbers after function {RoundTowardsZero(number1)} and {RoundTowardsZero(number2)}"); 
    }

    static double RoundTowardsZero(double X)
    {
        double lastdigit = (X*10 % 10);
        if (lastdigit < 5)
        {
            return Math.Floor(X);
        }
        else
        {
            return Math.Ceiling(X);
        }
        
    }
}
*/

/*
// Task 7
class DecisionTreeProgramm
{
    static void Main(string[] args)
    {
        string acct_stat = EnterAttribute("acct_stat");

        switch (acct_stat)
        {
            case "low":
                double amount = int.Parse(EnterAttribute("amount"));
                if (amount > 5000)
                {
                    Console.WriteLine("Reject");
                } else
                {
                    Console.WriteLine("Grant");
                }
                break;

            case "debt":
                string working = EnterAttribute("working: 'yes', 'no'");
                if (working == "yes")
                {
                    Console.WriteLine("Grant");
                } else 
                {
                    string reason_not_working = EnterAttribute("reason not working: 'retired', 'lost job'");
                    if (reason_not_working == "lost job")
                    {
                        Console.WriteLine("Reject");
                    } else
                    {
                        Console.WriteLine("Grant");
                    }
                }
                break;

            case "high":
                Console.WriteLine("Grant");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static string EnterAttribute(string attribute_name)
    {
        Console.WriteLine($"Enter the value of {attribute_name}");
        string acct_stat = Console.ReadLine().ToLower();
        return acct_stat;
    }
} 
*/


/*
// Task 8

class Program
{
    static void Main()
    {
        double number1 = ReadNumber(1);
        char opeartion = ChooseOperation();
        double number2 = ReadNumber(2);

        double result = CalculateResult(number1, number2, opeartion);
        DisplayResult(number1, number2, opeartion, result);
    }

    static double ReadNumber(int Number)
    {
        Console.WriteLine($"Enter the argument number {Number}");
        double number = double.Parse(Console.ReadLine());
        return number;
    }

    static char ChooseOperation()
    {
        Console.WriteLine("Choose the operation: +, -, *, /, ^");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.WriteLine();
        return keyInfo.KeyChar;
    }

    static double CalculateResult(double number1, double number2, char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                if (number2 == 0)
                {
                    Console.WriteLine("Invalid division by 0!");
                    break;
                } else
                {
                    result = number1 / number2;
                    break;
                }
            case '^':
                result = Math.Pow(number1, number2);
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }
        return result;
    }

    static void DisplayResult(double number1, double number2, char operation, double result)
    {
        Console.WriteLine($"{number1} {operation} {number2} = {result}");
    }
}
*/
