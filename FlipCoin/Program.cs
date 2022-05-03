// See https://aka.ms/new-console-template for more information

Console.WriteLine("---- Findout Largest Number ----\n");

Console.Write("Enter value of 1st No :- ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value of 2nd No :- ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter value of 3rd No :- ");
int z = Convert.ToInt32(Console.ReadLine());

if ((x > y) && (x > z))
{
    Console.WriteLine("{0} is largest value", x);
}
else if ((y > x) && (y > z))
{
    Console.WriteLine("{0} is largest value", y);
}
else
{
    Console.WriteLine("{0} is largest value", z);

}