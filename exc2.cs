using System;
using Arsac;

public class Exercise2 {
    public static int Main() {
	const int seq_length = 5000;
	const int int_num = 50;
	
	double a, b;
	string input;
	
	Console.Write("Enter randomization parameter: ");
	input = Console.ReadLine();
	a = Double.Parse(input);
	Console.Write("Enter first number: ");
	input = Console.ReadLine();
	b = Double.Parse(input);
	if(b<0 || b>=1) {
	    Console.WriteLine("Bad input, exiting: {0}", b);
	    return 1;
	}

	int[] intervals = new int[int_num];
	for(int i=0; i<seq_length; i++) {
	    intervals[ (int) (b*int_num) ]++;
	    b = ArsacFunctions.random(b, a);
	}

	int max=intervals[0], min=intervals[0];
	for(int i=0; i<int_num; i++) {
	    Console.Write("{0} ", intervals[i]);
	    if(intervals[i]>max) max=intervals[i];
	    if(intervals[i]<min) min=intervals[i];
	}

        Console.WriteLine("");
        Console.WriteLine("Max = {0}, Min = {1}", max, min);
			
	return 0;
    }
}
