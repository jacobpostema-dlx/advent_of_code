var lines = System.IO.File.ReadAllLines(@"/Users/t463971/code/advent_of_code/AdventOfCode2022/Day02/input.txt");
List<string[]> input = new List<string[]>();

foreach (var line in lines)
{
    input.Add(line.Split(" "));
}

Console.WriteLine("########## Day 2 2022 ##########");
Console.WriteLine($"Part one solution: {SolvePartOne(input)}");
Console.WriteLine($"Part two solution: {SolvePartTwo(input)}");
Console.WriteLine("################################");


static int SolvePartOne(List<string[]> games)
{
    var scores = new List<int>();

    foreach (var round in games)
    {
        scores.Add(winOrLoss(round));
    }

    return scores.Sum();
}

static int SolvePartTwo(List<string[]> games)
{

     var scores = new List<int>();

    foreach (var round in games)
    {
        scores.Add(howItshouldEnd(round));
    }

    return scores.Sum();
}

static int winOrLoss(string[] round)
{
    int score;

    if (round[0].Equals("A"))
    {
        if (round[1].Equals("X"))
        {
            score = 1 + 3;
        }
        else if (round[1].Equals("Y"))
        {
            score = 2 + 6;
        }
        else
        {
            score = 3 + 0;
        }
    }
    else if (round[0].Equals("B"))
    {
        if (round[1].Equals("X"))
        {
            score = 1 + 0;
        }
        else if (round[1].Equals("Y"))
        {
            score = 2 + 3;
        }
        else
        {
            score = 3 + 6;
        }
    }
    else
    {
        if (round[1].Equals("X"))
        {
            score = 1 + 6;
        }
        else if (round[1].Equals("Y"))
        {
            score = 2 + 0;
        }
        else
        {
            score = 3 + 3;
        }
    }
    return score;
}

static int howItshouldEnd(string[] round)
{
    int score;

    if (round[0].Equals("A"))
    {
        if (round[1].Equals("X"))
        {
            score = 3 + 0;
        }
        else if (round[1].Equals("Y"))
        {
            score = 1 + 3;
        }
        else
        {
            score = 2 + 6;
        }
    }
    else if (round[0].Equals("B"))
    {
        if (round[1].Equals("X"))
        {
            score = 1 + 0;
        }
        else if (round[1].Equals("Y"))
        {
            score = 2 + 3;
        }
        else
        {
            score = 3 + 6;
        }
    }
    else
    {
        if (round[1].Equals("X"))
        {
            score = 2 + 0;
        }
        else if (round[1].Equals("Y"))
        {
            score = 3 + 3;
        }
        else
        {
            score = 1 + 6;
        }
    }
    return score;
}
