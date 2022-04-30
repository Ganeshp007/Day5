// See https://aka.ms/new-console-template for more information

int year;
Console.WriteLine("Enter the year:-");
year = int.Parse(Console.ReadLine());
if(year%4==0 && year%400==0)
{
    Console.WriteLine(year + " is a Leap Year...");
}
else
{
    Console.WriteLine(year + " is Not Leap Year...");
}