// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
   public static void Main(string[] args)
   {
      float num = 6f;
      int quvvet = 0;


      while (num >= 2)
      {
         num /= 2;
         quvvet++;

      }
      if (num > 1.5)
      {
         Console.WriteLine(quvvet);
      }
      else if (num == 1.5)
      {
         Console.WriteLine("Her iki quvvete eyni uzaqlidadir ", quvvet, quvvet + 1);
      }
      else
      {
         Console.WriteLine(quvvet);
      }


   }
}