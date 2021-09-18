using UnityEngine;

public static class BigNumberConverter 
{
    private static string[] _suffixes = {"", "K", "M", "B", "T"};

    public static string ConvertNumber(float number)
    {
        if (number == 0)
        {
            return "Score: $" + number;
        }

        number = Mathf.Round(number);

        int i = 0;
        while (i + 1 < _suffixes.Length && number >= 1000f)
        {
            number /= 1000f;
            i++;
        }

        return "Score: $" + number.ToString("#.##") + _suffixes[i];
    }
}