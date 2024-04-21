Random random = new Random();
int cpuRandom;
bool loopActive = true;

while (loopActive)
{
    cpuRandom = random.Next(1, 6);
    Console.WriteLine("Guess the number! (Between 1-5):");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Correct, you win!");
        loopActive = false;  
        //break;
    }
    else
    {
        Console.WriteLine("BOO! Try again...");
    }
}

Console.WriteLine("Have great day!");