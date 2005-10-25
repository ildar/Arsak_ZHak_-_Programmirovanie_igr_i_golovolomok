using System;
using Arsac;

public class Exercise3 {
    public static int Main() {
	coin a, b;
	string input;
	
	Console.Write("Enter your guess (reshka or orel): ");
	input = Console.ReadLine();
	a = Coin.Parse(input);

        b = ArsacFunctions.random()>=0.5?coin.reshka:coin.orel;
	if(a==b)
	    Console.WriteLine("You win");
	else Console.WriteLine("You lose");
			
	return 0;
    }
}
