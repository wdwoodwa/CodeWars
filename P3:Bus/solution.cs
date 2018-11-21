
using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int runningTotal = 0;
        foreach (int[] arr in peopleListInOut)
        {
            runningTotal += (arr[0] - arr[1]);
        }
               
        return runningTotal;
    }
}