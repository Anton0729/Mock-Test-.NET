/*
Write one program, that reads a series of integer numbers from the keyboard and performs the tasks de-
scribed below. Each number can be entered as a separate line of text (with the ENTER key pressed at the
end). The entering of numbers should be stopped when the user enters a non-number, e.g. an empty line
or a text like "stop".

After reading the numbers the program should display three lines of text containing information de-
scribed below. Each of the three points • should result in one line of text. Printing of the results must
occur after all the numbers have been read from the keyboard.

Note: You can use course materials and web search during the test, but do not use any code- gen-
erating tool (Copilot, ChatGPT, etc.). Using such tools results in getting 0 points from the test.

how many of the entered numbers are not divisible by 2 nor by 5?

how many of the entered numbers are larger than 15 and at the same time divisible
by 9?

calculate the average of the two values mentioned above.
*/
using System;

class Program {
    static void Main(string[] args){
        int totalCount = 0;
        int countTask1 = 0;
        int countTask2 = 0;
        int sum = 0;

        Console.WriteLine("Enter numbers or type non-number to stop");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                totalCount++;

                if (number % 2 != 0 && number % 5 != 0)
                {
                    countTask1++;
                }

                if (number > 15 && number % 9 == 0)
                {
                    countTask2++;
                    sum += number;
                }

            }
            else {
                break;
            }
        }

        double average = (double)(countTask1 + countTask2) / 2;

        Console.WriteLine($"Numbers not divisible by 2 or 5: {countTask1}");
        Console.WriteLine($"Numbers larger than 15 and divisible by 9: {countTask2}");

        Console.WriteLine($"Average: {average}");
    }
}
