using static System.Console;
using System.IO;
using System.Drawing;

public class Program {
	public static void Main() {
        WriteLine(Image.FromStream(new MemoryStream(new byte[1024])));
	}
}

//https://pt.stackoverflow.com/q/392424/101
