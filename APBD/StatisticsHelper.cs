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
}
