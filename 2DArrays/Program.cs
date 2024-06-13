using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static int FindMaxSum(List<List<int>> arr)
    {
        int maxSum = -100;

        for (int i = 0; i < 4; i++)
        {
            int count = 0;

            for (int j = 0; j < 4; j++)
            {
                int sum = arr[i][j] + arr[i][j+1] +
                    arr[i][j+2] + arr[i + 1][j+1] + 
                    arr[i + 2][j] + arr[i + 2][j+1] + arr[i + 2][j+2];
                count++;
                
                if (sum > maxSum){
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int res = FindMaxSum(arr);

        Console.WriteLine(res);
    }
}
