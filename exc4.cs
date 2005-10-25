using System;
using Arsac;

public class Exercise4 {
    public static int Main() {
	const int seq_length = 1000;
	
	int[] stats = new int[13];
	double rand=ArsacFunctions.random();
	
        for(int i=0; i<seq_length; i++) {
	    int gamble1=(int) ((rand=ArsacFunctions.random(rand))*6+1);
	    int gamble2=(int) ((rand=ArsacFunctions.random(rand))*6+1);
	    stats[gamble1+gamble2]++;
	}

        for(int i=2; i<13; i++)
    	    Console.Write("{0} was {1} times\t", i, stats[i]);
        Console.WriteLine();
			
	return 0;
    }
}
