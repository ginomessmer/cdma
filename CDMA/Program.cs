using System;
using System.Reflection.Metadata;
using System.Text;

namespace CDMA
{
    /// <summary>
    /// References:
    /// - https://de.linkfang.org/wiki/Hadamard-Matrix
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //public static int[][] GrowHadamardMatrice(int n)
        //{
        //    // Width & height
        //    var dimension = Convert.ToInt32(Math.Pow(2, n));

        //    // Set up matrix
        //    var matrix = new int[dimension][];
        //    for (var i = 0; i < matrix.Length; i++)
        //    {
        //        matrix[i] = new int[dimension];
        //    }

        //    // I
        //    for (var i = 0; i < matrix.Length; i++)
        //    {
        //        // J
        //        for (var j = 0; j < matrix[i].Length; j++)
        //        {
        //            matrix[0][0]
        //        }
        //    }
        //}

        //public static int[][] DefaultHadamardMatrix => new[]
        //{
        //    new[] {1, 1},
        //    new[] {1, -1}
        //};
    }
}
