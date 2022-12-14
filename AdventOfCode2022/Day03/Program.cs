var lines = System.IO.File.ReadAllLines(@"/Users/t463971/code/advent_of_code/AdventOfCode2022/Day03/input.txt");

Console.WriteLine("########## Day 2 2022 ##########");
Console.WriteLine($"Part one solution: {SolvePartOne(lines)}");
Console.WriteLine($"Part two solution: {SolvePartTwo(lines)}");
Console.WriteLine("################################");


static int SolvePartOne(string[] rucksackContents)
{
    var sumOfIncorrectItems = 0;

    foreach (var pack in rucksackContents)
    {
        var PartOne = new Rucksack(pack);
        char letter = PartOne.incorrectlyPackedItem();
        sumOfIncorrectItems += itemPriority(letter);
    }

    return sumOfIncorrectItems;
}

static int SolvePartTwo(string[] rucksackContents)
{
    var sumOfBadges = 0;

    for (int i = 0; i < rucksackContents.Length; i += 3)
    {
        string[] group = new string[] {rucksackContents[i], rucksackContents[i+1], rucksackContents[i+2]};
        var Party = new RucksackGroups(group);
        var item = Party.findBadge();
        Array.ForEach(group, Console.WriteLine);
        System.Console.WriteLine(item);
        sumOfBadges += itemPriority(item);
    }
    return sumOfBadges;
}

static int itemPriority(char item)
{
    int priority = 0;
    if (Char.IsUpper(item))
    {
        priority = item - 38;
    }
    else
    {
        priority = item - 96;
    }
    return priority;
}

public class Rucksack
{
    public string Contents { get; set; }

    public Rucksack(string contents)
    {
        Contents = contents;
    }

    public char incorrectlyPackedItem()
    {
        var centerOfString = (int)(Contents.Length / 2);
        var firstCompartment = Contents.Substring(0, centerOfString);
        var secondCompartment = Contents.Substring(centerOfString);
        char repeat = ' ';

        foreach (var item in firstCompartment)
        {
            if (secondCompartment.Contains(item))
            {
                repeat = item;
                break;
            }
        }

        return repeat;
    }
}

public class RucksackGroups
{
    public string[] Group { get; set; }

    public RucksackGroups(string[] input)
    {
        Group = input;
    }

    public char findBadge()
    {
        char badge = ' ';

        foreach (var item in Group[0])
        {
            if (Group[1].Contains(item))
            {
                if (Group[2].Contains(item))
                {
                    badge = item;
                }
            }
        }
        return badge;
    }
}
