// See https://aka.ms/new-console-template for more information

Console.WriteLine("---- Even Odd Test ----\n");

Console.Write("> Enter Number to Test :- ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
    Console.WriteLine("\n>> {0} is Even Number",x);

else
    Console.WriteLine("\n>> {0} is Odd Number",x);
