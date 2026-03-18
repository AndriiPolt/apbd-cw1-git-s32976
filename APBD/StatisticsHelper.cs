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
}
