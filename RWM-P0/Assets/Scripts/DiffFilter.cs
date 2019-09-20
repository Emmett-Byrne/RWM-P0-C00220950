using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffFilter : MonoBehaviour
{
    public static List<int> Diff(List<int> list)
    {
        int previous = 0;
        var output = new List<int>();

        foreach(var current in list)
        {
            var result = current - previous;
            if (result < 0)
            {
                result *= -1;
            }
            output.Add(result);
            previous = current;
        }

        return output;
    }
}
