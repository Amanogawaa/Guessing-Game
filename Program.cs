class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secret = random.Next(1, 20);
        int guess = 0;
        int guessCount = 0;
        int guessLimit = 5;
        bool outofGuess = false;

        while (guess != secret && !outofGuess)
        {
            if (guessCount < guessLimit)
            {
                Console.WriteLine($"You only have {guessLimit - guessCount}");
                Console.Write("Enter you guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;
            }
            else
            {
                outofGuess = true;
            }
        }
        if (outofGuess)
        {
            Console.WriteLine("Bobo ka!");
        }
        else
        {
            Console.WriteLine("You've guessed it!");
        }
        //prints the secret number
        Console.Write($"Secret Number: {secret}");
    }
}