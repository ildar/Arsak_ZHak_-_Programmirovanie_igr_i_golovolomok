using System;
using Arsac;

public class Exercise3a {
    public static int Main() {
	const int seq_length = 1000;
	
	int num_orel=0;
	double rand=ArsacFunctions.random();
	
        for(int i=0; i<seq_length; i++)
	    if( ((rand=ArsacFunctions.random(rand))>=0.5?coin.reshka:coin.orel) == coin.orel )
		num_orel++;

	Console.WriteLine("orel was {0} of {1} times", num_orel, seq_length);
			
	return 0;
    }
}
