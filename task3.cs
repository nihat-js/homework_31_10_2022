int num = 101;
int start = 2;
String output = "Sade ededdir";


if (num != 1)
{
   while (start < num)
   {
      if (num % start == 0)
      {
         output = "Murekkeb ededdir";
         break;
      }
      start++;
   }

}
else
{
   output = "Ne murekkeb ne sade ededdir";
}

System.Console.WriteLine(output);
Console.ReadKey();