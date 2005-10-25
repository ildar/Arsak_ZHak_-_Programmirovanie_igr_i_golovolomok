using System;

namespace Arsac {

public class ArsacFunctions {

    // стр. 11
    public static double random (double _x, double _a) {
	double b;
		
	b = Math.Pow (_x+_a, 8);
	return b - ((long) b);
    }
    public static double random (double _x) {
	return random(_x, Math.PI);
    }
    // My utility function
    //   It souldn't be used too often
    public static double random () {
	long t=DateTime.Now.Ticks;
	return random(t/10000.0-t/10000);
    }


} // class ArsacFunctions

public enum coin {
    reshka,
    orel
}

public class Coin {
    public static coin Parse(string s) {
	if(s.Equals("reshka")) return coin.reshka;
	if(s.Equals("orel")) return coin.orel;
	if(s.Equals("0")) return coin.reshka;
	if(s.Equals("1")) return coin.orel;
    // TODO: Should throw an exception if can't parse
	return coin.reshka;
    }
} // class Coin

public enum kost {
    one,
    two,
    orel
}

} // namespace Arsac
