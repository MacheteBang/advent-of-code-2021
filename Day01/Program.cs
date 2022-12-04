string[] lines = File.ReadAllLines("input.txt");
int[] depthMeasurements = lines.Select(l => int.Parse(l)).ToArray();

int increasedCount = 0;

for (int i = 1; i < depthMeasurements.Length; i++)
{
    if (depthMeasurements[i] > depthMeasurements[i - 1]) increasedCount++;
}

Console.WriteLine($"Times increased: {increasedCount}");

int increasedSlidingCount = 0;

for (int i = 1; i < depthMeasurements.Length - 2; i++)
{
    int currentSlidingMeasurement = depthMeasurements.Skip(i).Take(3).Sum();
    int previousSlidingMeasurement = depthMeasurements.Skip(i - 1).Take(3).Sum();

    if (currentSlidingMeasurement > previousSlidingMeasurement) increasedSlidingCount++;
}


Console.WriteLine($"Times slding window increased: {increasedSlidingCount}");