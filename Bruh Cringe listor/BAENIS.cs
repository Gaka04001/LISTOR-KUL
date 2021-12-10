using System;
using System.Collections.Generic;
using System.Linq;
class Demo {
   static void Main() {
      List<long> list = new List<long> { 11, 12, 6, 5, 3, 3,};
      foreach(long ele in list){
         Console.WriteLine(ele);
      }

      
      long största_num = list.AsQueryable().Max();

      
      long minsta_num = list.AsQueryable().Min();

      Console.WriteLine("Smallest number = {0}", minsta_num);
      Console.WriteLine("Largest number = {0}", största_num);
   }