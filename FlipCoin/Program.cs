// See https://aka.ms/new-console-template for more information

Console.WriteLine("---- Welcome to Prime Factor Solution ----\n");
int N,i;

Console.Write("Enter the number to find Prime Factor:- ");

N = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= N; i++)
{
    if (N % i == 0)
    {

        Console.WriteLine("{0} is the prime factor of {1}", i, N); 
        //This is how we print result in respective manner using {} 
    }

}
Console.ReadLine();
