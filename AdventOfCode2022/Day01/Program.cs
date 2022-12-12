var lines = System.IO.File.ReadAllLines(@"/Users/t463971/code/advent_of_code/AdventOfCode2022/Day01/input.txt");


Console.WriteLine("########## Day 1 2022 ##########");
Console.WriteLine($"Part one solution: {SolvePartOne(lines)}");
Console.WriteLine($"Part two solution: {SolvePartTwo(lines)}");
Console.WriteLine("################################");


static int SolvePartOne(string[] input)
{
    var caloriesPerElf = ElfsTotalCalories(input);

    return caloriesPerElf.Max();
}

static int SolvePartTwo(string[] input)
{
    var caloriesPerElf = ElfsTotalCalories(input);
    caloriesPerElf.Sort();
    caloriesPerElf.Reverse();
    int topThree = caloriesPerElf[0] + caloriesPerElf[1] + caloriesPerElf[2];

    return topThree;
}

static List<int> ElfsTotalCalories(string[] input)
{
    var caloriesPerElf = new List<int>();
    int currentCalories = 0;

    foreach (var line in input)
    {
        if (line.Trim().Length == 0)
        {
            // found blank line add total to caloriesPerElf
            // onlyif currentCalories is greater than zero
            if (currentCalories > 0)
            {
                caloriesPerElf.Add(currentCalories);
                currentCalories = 0;
            }
        }
        else
        {
            int number = int.Parse(line);
            currentCalories+= number;
        }
    }

    return caloriesPerElf;
}
