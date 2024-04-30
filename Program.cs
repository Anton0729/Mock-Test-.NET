/*
Console.WriteLine("Enter lines of text. Enter an empty line to stop.");
List<string> lines = new List<string>();

while (true)
{
    string inputString = Console.ReadLine();

    if (string.IsNullOrEmpty(inputString))
    {
        break;
    }

    lines.Add(inputString);
}

*/



/*
foreach (var line in lines)
{
*/
    /*
    Console.WriteLine("Task 1");
    string reversedString = new string(line.Reverse().ToArray());

    if (line == reversedString)
    {
        Console.WriteLine("Yes, it is a palindrome.");
    }
    else
    {
        Console.WriteLine("No, it is not a palindrome.");
    }
    */


    /*
    // NOT SHURE HOW IT WORKS
    Console.WriteLine("Task 2");
    // “ABCDEFGH” you should print: “BADCFEHG”
    string input = Console.ReadLine();
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length; i += 2)
    {
        char temp = chars[i];
        chars[i] = chars[i + 1];
        chars[i + 1] = temp;

    }
    Console.WriteLine(chars);
    */


    /*
    Console.WriteLine("Task 3");
    int sumOfDigits = 0;
    foreach (char i in line)
    {
        if (char.IsDigit(i))
        {
            sumOfDigits += int.Parse(i.ToString());
        }
    }
    Console.WriteLine($"Sum of digits: {sumOfDigits}");
    */


    /*
    Console.WriteLine("Task 4");
    string input = Console.ReadLine();

    int sumOfDigits = 0;
    int sumOfChars = 0;

    foreach (char i in input) {
        if (char.IsDigit(i)) {
            sumOfDigits++;
        }
        if (char.IsLetter(i)) {
            sumOfChars++;
        }
    } 

    if (sumOfChars > sumOfDigits)
    {
        Console.WriteLine("Letters more than digits");
    }
    else {
        Console.WriteLine("No, letters less than digits");
    }
    */

    /*
    Console.WriteLine("Task 5");
    string input = Console.ReadLine();

    int sumOfUpper = 0;
    int sumOfLower = 0;

    foreach (char i in input) {
        if (char.IsUpper(i)) {
            sumOfUpper++;
        }
        if (char.IsLower(i)) {
            sumOfLower++;
        }
    } 

    if (sumOfUpper > sumOfLower)
    {
        Console.WriteLine("Upper case more than lower case characters");
    }
    else {
        Console.WriteLine("No, upper case less than lower case characters");
    }
    */


    /*
    Console.WriteLine("Task 7");
    
    Print each line of text in the following way: if a character is a ‘-‘ (minus sign) skip the next
    character, if a character is a ‘+’ (plus sign) print the next character twice. Print all the other
    characters normally. For example, if the input is: “-A+BC-+DDD+-“ you should print:
    “BBCDDD--" (note that there are two minus signs at the end in the output). 
    

    string input = Console.ReadLine();
    string new_string = "";

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '-')
        {
            i++;
            continue;
        }
        else if (input[i] == '+')
        {;
            new_string += input[i + 1];
            new_string += input[i + 1];
            i++; 
        }
        else
        {
            new_string += input[i];
        }
    }

    Console.WriteLine($"Enterd string {input}. Result {new_string}");
    */


    Console.WriteLine("Task 8");



/*    
}
*/
