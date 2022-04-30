// See https://aka.ms/new-console-template for more information
int loopCount = 1;
double numFlips = 50;
double result;
int heads = 0;
int tails = 0;
int heads_count=0;
int tails_count=0;  
while (loopCount <= numFlips)
{ Random obj = new Random();
    result = obj.NextDouble() * (1-0)+0;
    result = Math.Round(result, 1);
    if (result <= 0.5) 
    {
        
        Console.WriteLine("Coin flippped:- Head");
        heads++;
    }
    else 
    {
        
        Console.WriteLine("Coin flipped :- Tails");
     
        tails++;
    }
    loopCount++;
}

double percentHeads = (heads / numFlips) * 100;
percentHeads=Math.Round(percentHeads, 2);
double percentTails = (tails / numFlips) * 100;
percentTails=Math.Round(percentTails, 2);   
Console.WriteLine("\nCount :\n");
Console.WriteLine("Total Head count:- "+heads);
Console.WriteLine("Total Tails count:- "+tails);
Console.WriteLine("\nPercentages :\n");
Console.WriteLine("Percentage of Heads occured:- " + percentHeads + "%");
Console.WriteLine("Percentage of Tails occured:- " + percentTails + "%");

