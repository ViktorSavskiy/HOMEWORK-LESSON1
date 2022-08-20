Console.WriteLine("Введите положительное число");
int num=int.Parse(Console.ReadLine());
int a = 1;
    if (num<0)
    {
    Console.WriteLine("Число должно быть больше ноля");
}
 if (num==0)
    {
    Console.WriteLine("Больше ноля");
}
while (a<=num)
{
    if (a%2==0)
    {
    Console.WriteLine(a);
}
a = a + 1; 
}
