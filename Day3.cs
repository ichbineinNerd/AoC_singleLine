using System.Linq;
using System;

class MainClass {
	public static void Main (string[] args) {
		string Input = "";
		string x;
		while ((x = Console.ReadLine()) != "")
			Input += x + "\n";
	
	
		Console.WriteLine(new [] {Input.Split("\n", StringSplitOptions.RemoveEmptyEntries).Select(line => line.Select(c => c == '#').ToArray()).ToArray().Aggregate(((0, 0), (0, 0), (0, 0), (0, 0), (0, 0, 0)), (info, line) => (((info.Item1.Item1 + 1) % line.Length, info.Item1.Item2 + (line[info.Item1.Item1] ? 1 : 0)), ((info.Item2.Item1 + 3) % line.Length, info.Item2.Item2 + (line[info.Item2.Item1] ? 1 : 0)), ((info.Item3.Item1 + 5) % line.Length, info.Item3.Item2 + (line[info.Item3.Item1] ? 1 : 0)), ((info.Item4.Item1 + 7) % line.Length, info.Item4.Item2 + (line[info.Item4.Item1] ? 1 : 0)), ((info.Item5.Item1 + (info.Item5.Item2 % 2 == 0 ? 1 : 0)) % line.Length, info.Item5.Item2 + 1,info.Item5.Item3+(info.Item5.Item2 % 2 == 1 ? 0 : (line[info.Item5.Item1] ? 1 : 0)))))}.Select(info => info.Item1.Item2 * info.Item2.Item2 * info.Item3.Item2 * info.Item4.Item2 * info.Item5.Item3).ToArray()[0]);
	}
}
