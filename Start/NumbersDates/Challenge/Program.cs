using System;
using System.Globalization;

    for (;;)
    {
        Console.Write("Enter a date and time (YYYY-MM-DD HH:MM) or type 'exit' to quit: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "exit")
        {
            break;
        }

        DateTime enteredDateTime;
        if (DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out enteredDateTime))
        {
            DateTime currentDateTime = DateTime.Now;
            TimeSpan difference = enteredDateTime - currentDateTime;

            if (difference.TotalSeconds > 0)
            {
                Console.WriteLine($"{difference.Days} days and {difference.Hours} hours remain until {enteredDateTime:yyyy-MM-dd HH:mm}");
            }
            else if (difference.TotalSeconds < 0)
            {
                difference = currentDateTime - enteredDateTime; 
                Console.WriteLine($"{difference.Days} days and {difference.Hours} hours have passed since {enteredDateTime:yyyy-MM-dd HH:mm}");
            }
            else
            {
                Console.WriteLine("The entered date and time is now.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date and time format. Please try again.");
        }
    }