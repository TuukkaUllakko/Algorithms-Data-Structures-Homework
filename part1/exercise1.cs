using System;
using System.Collections.Generic;
namespace part1
{
  public class Numbers
  {
    public int Sum(int x)
    {
      int sum = 0;
      for (int i = 0; i < GetIntArray(x).Length; i++)
      {
        sum = sum + GetIntArray(x)[i];
      }
      return sum;
    }
    int[] GetIntArray(int num)
{
    List<int> listOfInts = new List<int>();
    while(num > 0)
    {
        listOfInts.Add(num - (num / 10) * 10);
        num = num / 10;
    }
    return listOfInts.ToArray();
}
  }
}