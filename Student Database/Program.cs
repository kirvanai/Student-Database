namespace Student_Database
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Alex", "Irving", "Kyle", "Michael" };
            string[] hometowns = { "Detroit", "Grand Rapids", "Ann Arbor", "Lansing" };
            string[] favoriteFoods = { "pizza", "curry", "tacos", "steak" };
            bool goOn = true;
            Console.WriteLine("Before we begin, would you like to see the list of available students? y/n");
            string studentList = Console.ReadLine().ToLower();
            while (studentList != "y" && studentList != "yes" && studentList != "n" && studentList != "no")
            {
                Console.WriteLine("Invalid entry. y/n?");
                studentList = Console.ReadLine().ToLower();
            }
            if (studentList == "y" || studentList == "yes")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }

            while (goOn == true)
            {
            Console.WriteLine($"Please enter student number. {names.Length} are available:");
            int inputIndex = ConvertInput(Console.ReadLine());
            while (inputIndex < 0 || inputIndex >= names.Length)
                {
                    Console.WriteLine($"Invalid student number. {names.Length} are available. Please Enter Student Number:");
                    inputIndex = ConvertInput(Console.ReadLine());
                }    

            Console.WriteLine($"Student: {names[inputIndex]}");
            Console.WriteLine($"Would you like to know {names[inputIndex]}'s hometown or favorite food?");
            string inputCategory = CorrectCategory(Console.ReadLine());
            if (inputCategory.ToLower() == "hometown" || inputCategory.ToLower() == "home")
            {
                Console.WriteLine($"Hometown: {hometowns[inputIndex]}");
            }
            else
            {
                Console.WriteLine($"Favorite Food: {favoriteFoods[inputIndex]}");
            }
                goOn = AskToContinue();
            }

        }

        public static int ConvertInput(string input)
        {
            int output = int.Parse(input) - 1;
            return output;
        }

        public static string CorrectCategory(string input)
        {
            input.ToLower();
            while (input.ToLower() != "hometown" && input.ToLower() != "favorite food" && input.ToLower() != "home" && input.ToLower() != "food" && input.ToLower() != "favorite")
            {
                Console.WriteLine("Incorrect category selection. Please enter hometown or favorite food.");
                input = Console.ReadLine().ToLower();
            }
            return input;
        }

        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to learn about another student? y/n");
            string input = Console.ReadLine().ToLower();

            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Hey I didn't understand your response");
                return AskToContinue();
            }
        }

    }
}