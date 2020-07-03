using System;
using System.Collections.Generic;
using System.Linq;

namespace CDMA
{
    public static class Cdma
    {
        public static int[] Decode(int[] code, int[] payload)
        {
            var allChunks = payload.ChunkBy(code.Length);

            return allChunks
                .Select(chunk => 
                    chunk.Select((i, index) => i * code[index]).Sum() / code.Length)
                .ToArray();
        }

        public static int[] Encode(int[] code, int[] message)
        {
            var list = new List<int>();

            foreach (var currentMessage in message)
            {
                foreach (var currentCode in code)
                {
                    if (currentMessage == 0)
                        list.Add(-currentCode);
                    else
                        list.Add(currentCode);
                }
            }

            return list.ToArray();
        }

        public static int[] Merge(int[] inputA, int[] inputB)
        {
            if (inputA.Length != inputB.Length)
                throw new InvalidOperationException("Lists do not have the same size");

            return inputA.Select((t, index) => t + inputB[index]).ToArray();
        }

        public static IEnumerable<int> Normalize(int[] input) => input.Select(i => i < 0 ? 0 : 1);
    }
}