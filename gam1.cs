using System;
using Arsac;

public class Game1 {
    public static int Main() {
	const double trick_shift = 0.2;

	int seq_length;
	string input;

	Console.Write("Enter the number of gamlings: ");
	input = Console.ReadLine();
	seq_length = Int32.Parse(input);

	double rand=ArsacFunctions.random();
	int[] stats = new int[7];
	double[] leftside = new double[7];

        for(int i=1; i<7; i++)
	    leftside[i] = (i-1)/6.0;
for(int i=1; i<7; i++)
Console.Write("{0}\t",leftside[i]);Console.WriteLine();

	bool trick=false; int trick_gran=0;

	if( rand>=0.5 ) { // start tricking
	    trick=true;
	    trick_gran=(int) ((rand=ArsacFunctions.random(rand))*6+1);
    	    for(int i=2; i<7; i++)
		if(i<=trick_gran)
		    leftside[i] -= trick_shift/6;
		else
		    leftside[i] += trick_shift/6;
	}
for(int i=1; i<7; i++)
Console.Write("{0}\t",leftside[i]);Console.WriteLine();
	
        for(int i=0, gran; i<seq_length; i++) {
	    rand=ArsacFunctions.random(rand);
	    for(gran=6; gran>1; gran--)
		if(rand>leftside[gran]) break;
	    stats[gran]++;
	}

        for(int i=1; i<7; i++)
    	    Console.Write("{0} was {1} times\t", i, stats[i]);
        Console.WriteLine();
			
	Console.Write("Do you think the game was not fair? ");
	Console.Write("What gran was preferred? (0 if fair) ");
	input = Console.ReadLine();
	int guess = Int32.Parse(input);
	if(guess == trick_gran)
	    Console.Write("You win. ");
	else
	    Console.Write("You lose. ");

	Console.WriteLine("The trick gran was: {0}", trick_gran);

	return 0;
    }
}
