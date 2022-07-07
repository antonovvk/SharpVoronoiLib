using System.Collections.Generic;
using NUnit.Framework;

namespace SharpVoronoiLib.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ListUtilsTest
    {
        [TestCase(0)]
        [TestCase(+1)]
        [TestCase(-1)]
        public void TestShiftEmpty(int shiftBy)
        {
            // Arrange
            
            List<int> list = new List<int>();

            // Act
            
            list.ShiftBy(shiftBy);
            
            // Assert
            
            Assert.Pass();
        }
        
        [TestCase(0)]
        [TestCase(+1)]
        [TestCase(-1)]
        [TestCase(+5)]
        [TestCase(-5)]
        public void TestShiftSingle(int shiftBy)
        {
            // Arrange
            
            List<int> list = new List<int>() { 3 };

            // Act
            
            list.ShiftBy(shiftBy);
            
            // Assert
            
            CollectionAssert.AreEqual(new [] { 3 }, list);
        }
        
        [TestCase(+0, new[] { 10, 20, 30, 40, 50, 60, 70, 80 })]
        [TestCase(+1, new[] { 80, 10, 20, 30, 40, 50, 60, 70 })]
        [TestCase(-1, new[] { 20, 30, 40, 50, 60, 70, 80, 10 })]
        [TestCase(+2, new[] { 70, 80, 10, 20, 30, 40, 50, 60 })]
        [TestCase(-2, new[] { 30, 40, 50, 60, 70, 80, 10, 20 })]
        [TestCase(+3, new[] { 60, 70, 80, 10, 20, 30, 40, 50 })]
        [TestCase(-3, new[] { 40, 50, 60, 70, 80, 10, 20, 30 })]
        [TestCase(+7, new[] { 20, 30, 40, 50, 60, 70, 80, 10 })]
        [TestCase(-7, new[] { 80, 10, 20, 30, 40, 50, 60, 70 })]
        [TestCase(+8, new[] { 10, 20, 30, 40, 50, 60, 70, 80 })]
        [TestCase(+9, new[] { 80, 10, 20, 30, 40, 50, 60, 70 })]
        [TestCase(-9, new[] { 20, 30, 40, 50, 60, 70, 80, 10 })]
        [TestCase(+0, new[] { 10, 20, 30, 40, 50, 60, 70 })]
        [TestCase(+1, new[] { 70, 10, 20, 30, 40, 50, 60 })]
        [TestCase(-1, new[] { 20, 30, 40, 50, 60, 70, 10 })]
        [TestCase(+2, new[] { 60, 70, 10, 20, 30, 40, 50 })]
        [TestCase(-2, new[] { 30, 40, 50, 60, 70, 10, 20 })]
        [TestCase(+3, new[] { 50, 60, 70, 10, 20, 30, 40 })]
        [TestCase(-3, new[] { 40, 50, 60, 70, 10, 20, 30 })]
        [TestCase(+0, new[] { 10, 20, 30, 40, 50, 60 })]
        [TestCase(+1, new[] { 60, 10, 20, 30, 40, 50 })]
        [TestCase(-1, new[] { 20, 30, 40, 50, 60, 10 })]
        [TestCase(+2, new[] { 50, 60, 10, 20, 30, 40 })]
        [TestCase(-2, new[] { 30, 40, 50, 60, 10, 20 })]
        [TestCase(+3, new[] { 40, 50, 60, 10, 20, 30 })]
        [TestCase(-3, new[] { 40, 50, 60, 10, 20, 30 })]
        public void TestShift(int shiftBy, int[] expected)
        {
            // Arrange
            
            List<int> list = MakeAList(expected.Length);

            // Act
            
            list.ShiftBy(shiftBy);
            
            // Assert
            
            CollectionAssert.AreEqual(expected, list);
        }

        
        private static List<int> MakeAList(int count)
        {
            List<int> list = new List<int>();
            
            for (int i = 1; i <= count; i++)
                list.Add(i * 10);
            
            return list;
        }
    }
}