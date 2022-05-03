// See https://aka.ms/new-console-template for more information

Console.WriteLine("---- Findout Alphabate is Vowel OR Consonant ----\n");

Console.Write("Enter the Alphabate to check :- ");
char ch = Convert.ToChar(Console.ReadLine());

if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
{
    Console.WriteLine("\nResult :- {0} is Vowel", ch);
}
else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
{
    Console.WriteLine("\nResult :- {0} is Consonant", ch);
}