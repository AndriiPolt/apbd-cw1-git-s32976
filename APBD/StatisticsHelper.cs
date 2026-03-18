namespace MyConsoleApp;

public class StatisticsHelper
{
    public int Sum(int[] values)
    {
        int sum = 0;
        foreach (var v in values)
        {
            sum += v;
        }
        return sum;
    }
    public double Average(int[] values)
    {
        if (values.Length == 0) return 0;
        return (double)Sum(values) / values.Length;
    }
    public int Max(int[] values)
    {
        if (values.Length == 0) return 0;
        int max = values[0];
        foreach (int v in values)
            if (v > max) max = v;
        return max;
    }
    public int Min(int[] values)
    {
        if (values.Length == 0) return 0;
        int min = values[0];
        foreach (int v in values)
            if (v < min) min = v;
        return min;
    }
    public int CountPositive(int[] values)
    {
        int count = 0;
        foreach (int v in values)
            if (v > 0) count++;
        return count;
    }
    public string CalculateMaxWithMessage(int[] values)
    {
        int max = Max(values);
        return $"The maximum value is: {max}";
    }
}
