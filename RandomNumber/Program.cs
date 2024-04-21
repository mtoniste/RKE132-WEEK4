Random random = new Random();

int myRandomNum;
int randomSum = 0;

for(int i = 0; i < 5; i++)
{
    myRandomNum = random.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is {myRandomNum}");
}

Console.WriteLine($"Random sum total is {randomSum}");  