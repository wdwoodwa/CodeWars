using System;
using System.Linq;

public class DigPow {
	public static long digPow(int number, int power) {
		var runningTotal = 0.0;
		var digits = number.ToString().Select(c => Int32.Parse(c.ToString()));
		
		foreach (int digit in digits)
		{
			runningTotal += Math.Pow(digit, power);
			power++;
		}
		
		var divisor = (long) (runningTotal/number);	
		return divisor != 0 ? divisor : -1;
	}
}