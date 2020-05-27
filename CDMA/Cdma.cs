using System;
using System.Collections.Generic;
using System.Linq;

namespace CDMA
{
    public static class Cdma
    {
        public static int[] Decode(int[] code, int[] payload)
        {
            var decodedMessage = new List<int>();

            var allChunks = payload.ChunkBy(code.Length);
            foreach (var chunk in allChunks)
            {
                var scalar = chunk.Select((i, index) => i * code[index]).Sum() / code.Length;
                decodedMessage.Add(scalar);
            }

            return decodedMessage.ToArray();
        }

        public static int[] Encode(int[] code, int[] message)
        {
            var list = new List<int>();

            for (var i = 0; i < message.Length; i++)
            {
                var currentMessage = message[i];
                for (var j = 0; j < code.Length; j++)
                {
                    var currentCode = code[j];

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

            var newResult = new List<int>();
            for (var i = 0; i < inputA.Length; i++)
            {
                newResult.Add(inputA[i] + inputB[i]);
            }

            return newResult.ToArray();
        }

        public static IEnumerable<int> Normalize(int[] input) => input.Select(i => i < 0 ? 0 : 1);
    }
}