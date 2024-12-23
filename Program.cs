static void Colors(){
    System.Console.WriteLine("Would you like to play");
    do
    {
        public class colors{
            Console.WriteLine("Choose the type of colours you want to display among these ones \n White, \n Green \n Blue ");
        string userColour = Console.ReadLine()!;
        if (userColour.ToUpper() == "WHITE")
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"You have chosen color {userColour}");
        Console.ResetColor();
        }
        else if(userColour.ToUpper() == "GREEN")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($" You have chosen color {userColour}");
            Console.ResetColor();   
        }
        else if(userColour.ToUpper == "BLUE"){
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You have chosen Color {userColour}");
            Console.ResetColor();
        }
        }
    } while (replay.ToUpper() == 'Y' );
}

Colors();