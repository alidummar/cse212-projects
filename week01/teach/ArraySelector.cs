using System;
using System.Collections.Generic;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> result = new List<int>();
        int index1 = 0;
        int index2 = 0;

        foreach (var selectorValue in select)
        {
            if (selectorValue == 1)
            {
                // If selector is 1, add the next element from list1 to the result
                result.Add(list1[index1]);
                index1++;
            }
            else if (selectorValue == 2)
            {
                // If selector is 2, add the next element from list2 to the result
                result.Add(list2[index2]);
                index2++;
            }
            // Handle any other selector values as needed
        }

        return result.ToArray();
    }
}
