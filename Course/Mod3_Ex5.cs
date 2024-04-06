class Course
{
    public static void mod3_ex5_1()
    {
        Console.WriteLine("Give number between 5 and 10: ");
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out var numericValue))
                Console.WriteLine("Sorry, you entered an invalid number, please try again: ");
            else if (numericValue < 5 || numericValue > 10)
                Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            else
            {
                Console.WriteLine($"Number ({numericValue}) got accepted :)");
                break;
            }
        }
    }

    public static void mod3_ex5_2()
    {
        // #2 while
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        string[] roleOptions = ["Administrator", "Manager", "User"];
        while (true)
        {
            var title = Console.ReadLine();
            if (title == null)
                continue;
            else if (roleOptions.Contains(title))
            {
                Console.WriteLine($"Your input value ({title}) has been accepted.");
                break;
            }
            else
                Console.WriteLine(
                    $"The role name that you entered, \"{title}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
    public static void mod3_ex5_3()
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        int periodLocation;
        foreach (string myString in myStrings)
        {
            var tmp = myString;
            while (tmp != "")
            {
                periodLocation = tmp.IndexOf('.');
                if (periodLocation == -1)
                {
                    Console.WriteLine(tmp.Trim());
                    break;
                }
                Console.WriteLine(tmp.Substring(0, periodLocation).Trim());
                tmp = tmp.Remove(0, periodLocation + 1);
                
            }
        }
    }
}
