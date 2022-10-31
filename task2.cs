int num = 11;
int sum = 0;
while (num >= 1)
{
   sum += num % 10;
   num = (num - num % 10) / 10;
}

Console.WriteLine(sum);