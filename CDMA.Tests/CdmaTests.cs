using System;
using Xunit;
using static CDMA.Cdma;

namespace CDMA.Tests
{
    public class CdmaTests
    {
        [Fact]
        public void Cdma_EncodeDecode_Correctly()
        {
            // Arrange
            var codeA = new[] { -1, -1, -1, +1, +1, -1, +1, +1 };
            var messageA = new[] { 1, 0, 0, 1, 0, 1, 1, 1 };

            var codeB = new[] { -1, -1, +1, -1, +1, +1, +1, -1 };
            var messageB = new[] { 1, 0, 1, 0, 0, 0, 1, 1 };

            // Act
            var resultA = Encode(codeA, messageA);
            var resultB = Encode(codeB, messageB);

            var mergedResult = Merge(resultA, resultB);

            var requestA = Decode(codeA, mergedResult);
            var requestB = Decode(codeB, mergedResult);

            // Assert
            Assert.Equal(messageA, Normalize(requestA));
            Assert.Equal(messageB, Normalize(requestB));
        }
    }
}
