// Import the necessary library to work with random numbers and user input.
using System;

// Define the name of your program.
class GuessTheNumber
{
    // The entry point of your program.
    static void Main(string[] args)
    {
        // Create a random number generator.
        Random random = new Random();
        
        // Initialize variables to store game data.
        bool playAgain = true;  // Determines if the game should be played again.
        int min = 1;           // The minimum value for the random number.
        int max = 100;         // The maximum value for the random number.
        int guess;             // The player's current guess.
        int number;            // The randomly generated target number.
        int guesses;           // The number of guesses the player has made.
        string response;       // Player's response to play again.

        // Main game loop - allows the player to play multiple rounds.
        while (playAgain)
        {
            // Initialize variables for a new game round.
            guess = 0;       // Reset the player's guess.
            guesses = 0;     // Reset the guess count.
            response = "";   // Reset the play-again response.
            
            // Generate a random number for the player to guess.
            number = random.Next(min, max + 1);

            // Loop to handle the player's guesses.
            while (guess != number)
            {
                // Prompt the player for their guess.
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                // Provide feedback on the guess.
                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low");
                }

                // Increment the guess count.
                guesses++;
            }

            // Display the correct number, a win message, and the number of guesses.
            Console.WriteLine("Number: " + number);
            Console.WriteLine("You Win!");
            Console.WriteLine("Guesses: " + guesses);

            // Ask the player if they want to play again.
            Console.WriteLine("Would you like to play again? Y/N: ");
            response = Console.ReadLine();
            response = response.ToUpper(); // Convert the response to uppercase.

            // Check the player's response to continue or exit the game.
            if (response == "Y")
            {
                playAgain = true;  // Play another round.
            }
            else
            {
                playAgain = false; // Exit the game.
            }
        }

        // Thank the player for playing when they choose to exit.
        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
        Console.ReadKey();
    }
}
