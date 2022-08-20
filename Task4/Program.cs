Console.WriteLine("Input first number");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Input third number");
int c=int.Parse(Console.ReadLine());
Console.WriteLine("Max number:");
if (a>b && a>c)
{
    Console.WriteLine(a);
} 
if (a<b && b>c)
{
    Console.WriteLine(b);
} 
else
{
    Console.WriteLine(c);
}

