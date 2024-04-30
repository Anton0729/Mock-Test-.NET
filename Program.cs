using System.Collections;
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

/*
Console.WriteLine("Task 1");
foreach (string line in lines)
{
    string reversed_line = new string(line.Reverse().ToArray());

    if (line == reversed_line)
    {
        Console.WriteLine($"{line} is a palindrom");
    }
    else
    {
        Console.WriteLine($"{line} ot a palindrom");
    }
}




Console.WriteLine("Task 2");
/*
 Write each entered line in the order: second character, first character, third character, fourth
character, etc. For example, for a line that reads: “ABCDEFGH” you should
print: “BADCFEHG”. 
 

foreach (string line in lines)
{
    ArrayList strings = new ArrayList();
    for (int i = 0; i < line.Length - 1; i+=2)
    {
        strings.Add(line.Substring(i, 2));
    }

    // if the line is odd than Substring remain part (last letter)
    if (line.Length % 2 != 0)
    {
        strings.Add(line.Substring(line.Length - 1));
    }

    
    foreach (string str in strings)
    {
        string reversed_two_letters = new string(str.Reverse().ToArray());
        Console.Write(reversed_two_letters);
    }
}
*/




// Console.WriteLine("Task 3");
/*
 Add all digits that appear in each entered line. For example if the line is “A34B5C” the result
should be 12 (=3+4+5).
 

foreach (string line in lines)
{
    int sumDigits = 0;
    foreach (char i in line)
    {
        if (char.IsDigit(i))
        {
            sumDigits += int.Parse(i.ToString());
        }
    }
    Console.WriteLine(sumDigits);
}
*/


/*
Console.WriteLine("Task 4");
/*
 Check if there are more letters than digits (in each of the entered lines separately). 
 
foreach (string line in lines)
{
    int moreLetters = 0;
    int moreDigits = 0;
    foreach (char i in line)
    {
        if (char.IsDigit(i))
        {
            moreDigits++;
        }
        if (char.IsLetter(i)) 
        {
            moreLetters++;
        }
    }
    if (moreLetters > moreDigits)
    {
        Console.WriteLine("Letters more than digits");
    } else
    {
        Console.WriteLine("Digits more than letters");
    }
}
*/


// Console.WriteLine("Task 5");
/*
 Check if there are more upper case than lower case characters (in each of the entered lines
separately). 

 */

/*
foreach (string line in lines)
{
    int moreUpperCase = 0;
    int moreLowerCase = 0;
    foreach (char i in line)
    {
        if (char.IsUpper(i))
        {
            moreUpperCase++;
        }
        if (char.IsLower(i))
        {
            moreLowerCase++;
        }
    }
    if (moreUpperCase > moreLowerCase)
    {
        Console.WriteLine("Upper case more than lower");
    }
    else
    {
        Console.WriteLine("Lower case more than upper");
    }
}
*/

Console.WriteLine("Task 6");
/*
 That is, if a character is a digit
repeat the next character the corresponding number of times, otherwise just print the
character. For example, if the line is “A3B25XY” you should print “ABBB55XY”
 */


foreach (string line in lines)
{


    string new_str = "";
     //while (i < line.Length)
    for (int i = 0; i < line.Length; i++)
    {
        if (char.IsDigit(line[i]))
            {

            // Convert the digit character to an integer
            int repeatCount = int.Parse(line[i].ToString());

            // repeat next character several times 
            new_str += string.Concat(Enumerable.Repeat(line[i + 1].ToString(), repeatCount));

            // skip letter/digit that must repeats
            i++;

        }
        else
        {
            new_str += line[i];
        }
    }

    Console.WriteLine(new_str);
}
