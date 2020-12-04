using System.Linq;
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string input = "";
        string x;
        while ((x = Console.ReadLine()) != "LASTLINE")
            input += x + "\n";


        Console.WriteLine(input.Split("\n\n").Select(entry => entry.Split(new[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)).Select(fieldValues=>fieldValues.Select(fieldValue => (fieldValue.Split(':')[0], fieldValue.Split(':')[1])).ToList()).ToList().Select(passport => passport.Count >= 7&&passport.Count <= 8&&passport.Any(tuple => tuple.Item1 == "byr" && int.Parse(tuple.Item2) >= 1920 && int.Parse(tuple.Item2) <= 2002)&&passport.Any(tuple => tuple.Item1 == "iyr" && int.Parse(tuple.Item2) >= 2010 && int.Parse(tuple.Item2) <= 2020)&&passport.Any(tuple => tuple.Item1 == "eyr" && int.Parse(tuple.Item2) >= 2020 && int.Parse(tuple.Item2) <= 2030)&&passport.Any(tuple => tuple.Item1 == "hgt"&&int.Parse(tuple.Item2.Substring(0, tuple.Item2.Length - 2)) >= (tuple.Item2.Substring(tuple.Item2.Length - 2) == "cm" ? 150 : 59)&&int.Parse(tuple.Item2.Substring(0, tuple.Item2.Length - 2)) <= (tuple.Item2.Substring(tuple.Item2.Length - 2) == "cm" ? 193 : 76))&&passport.Any(tuple => tuple.Item1 == "hcl" && tuple.Item2[0] == '#' && tuple.Item2.Substring(1).All(c => char.IsNumber(c) || (c >= 'a' && c <= 'f')))&&passport.Any(tuple => tuple.Item1 == "ecl" && new[] {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"}.Contains(tuple.Item2))&&passport.Any(tuple => tuple.Item1 == "pid" && tuple.Item2.Length == 9 && tuple.Item2.All(char.IsNumber))).Count(b => b));
    }
}