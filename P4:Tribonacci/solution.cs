using System.Collections.Generic;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    List<double> tribonacci = new List<double>(signature);
    var count = tribonacci.Count;
    while (count < n)
    {
        var next = tribonacci[count - 1] +  tribonacci[count - 2] + tribonacci[count - 3];
        tribonacci.Add(next);
        count++;
    }
    
    return tribonacci.ToArray();
  }
}