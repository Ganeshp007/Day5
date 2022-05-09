// See https://aka.ms/new-console-template for more information

Console.WriteLine("---- Swapping of Number ----\n");

Console.Write("> Enter value of X :- ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("> Enter value of Y :- ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n>> Before Swapping :-  x={0}  ,  y={1}", x, y);

//Swpping with third variable

int temp = x;
x = y;
y = temp ;

Console.WriteLine("\n---------------------------------------------\n");
Console.WriteLine(">> After Swapping :-  x={0}  ,  y={1}",x,y);