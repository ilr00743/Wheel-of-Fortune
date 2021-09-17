using UnityEngine;

public static class BigNumberConverter 
{
    private static string[] suffixes = new[]{"", "K", "M", "B", "T"};

    public static string ConvertNumber(float number)
    {
        if (number == 0)
        {
            return "Score: $" + number;
        }

        number = Mathf.Round(number);

        int i = 0;
        while (i + 1 < suffixes.Length && number >= 1000f)
        {
            number /= 1000f;
            i++;
        }

        return "Score: $" + number.ToString("#.##") + suffixes[i];
    }
}