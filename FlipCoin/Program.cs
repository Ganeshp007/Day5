// See https://aka.ms/new-console-template for more information

Console.WriteLine("---- Swapping of Numbers ----\n");


Console.WriteLine("---- Even Odd Test ----\n");

Console.Write("> Enter Number to check weather its Even OR Odd :- ");
int x = Convert.ToInt32(Console.ReadLine());

if(x%2 == 0)
{
    Console.WriteLine("\n>> {0} is Even Number",x);
}
else
{
    Console.WriteLine("\n>> {0} is Odd Number",x);
}


Console.WriteLine("\n---------------------------------------------\n");

Console.WriteLine(">> After Swapping :-  x={0}  ,  y={1}",x,y);

