var lines = System.IO.File.ReadAllLines(@"/Users/t463971/code/advent_of_code/AdventOfCode2022/Day04/input.txt");

Console.WriteLine("########## Day 4 2022 ##########");
Console.WriteLine($"Part one solution: {SolvePartOne(lines)}");
Console.WriteLine($"Part two solution: {SolvePartTwo(lines)}");
Console.WriteLine("################################");


static int SolvePartOne(string[] assignments)
{
    var sumofDuplicateAssignments = 0;
    var both = new IEnumerable<int>();//id1.Intersect(id2);
    var array = Enumerable.Range(0, 10).ToArray();

    //loop throw assignemtn making 2 arrays and see about intersection and see if that is one of the arrays

    return sumofDuplicateAssignments;
}

static int SolvePartTwo(string[] rucksackContents)
{
    var sumOfBadges = 0;

    return sumOfBadges;
}
