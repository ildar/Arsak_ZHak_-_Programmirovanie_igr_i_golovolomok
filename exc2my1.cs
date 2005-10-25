using System;
using Arsac;

public class Exercise2my1 {
    public static int Main() {
	const int seq_length = 5000;
	const int int_num = 50;
	
	double a, b, start_b;
	string input;
	
	Console.Write("Enter randomization parameter: ");
	input = Console.ReadLine();
	a = Double.Parse(input);

	int[] intervals = new int[int_num];
	int max=0, min=Int32.MaxValue;

	bool print_values = false;
	for(int j=0; j<20; j++) { // variing starting value	    
	    b=start_b=ArsacFunctions.random();
	    for(int i=0; i<int_num; i++)
		intervals[i]=0;
		
	    for(int i=0; i<seq_length; i++) {
		intervals[ (int) (b*int_num) ]++;
	        b = ArsacFunctions.random(b, a);
	    }

	    for(int i=0; i<int_num; i++) {
		//Console.Write("{0} ", intervals[i]);
		if(intervals[i]>max) { max=intervals[i]; print_values=true; }
		if(intervals[i]<min) { min=intervals[i]; print_values=true; }
	    }

	    if(print_values) {
		Console.Write("Max/Min changed at start_b = {0}, stats: ", start_b);
    		for(int i=0; i<int_num; i++)
		    Console.Write("{0} ", intervals[i]);
		print_values = false;
    		Console.WriteLine("");
	    }
	}

        Console.WriteLine("");
        Console.WriteLine("Max = {0}, Min = {1}", max, min);
			
	return 0;
    }
}
