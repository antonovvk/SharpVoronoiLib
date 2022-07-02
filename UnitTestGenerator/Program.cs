using System;

namespace UnitTestGenerator
{
    public static class Program
    {
        public static void Main()
        {
            TestGenerator testGenerator = new TestGenerator(
                0, 0, 300, 300, 
                30, 10
            );

            testGenerator.AddTest(@"
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
                ..............................
            ");

            Console.WriteLine(testGenerator.Output());
        }


        private class TestGenerator
        {
            private readonly double _minX;
            private readonly double _minY;
            private readonly double _maxX;
            private readonly double _maxY;
            private readonly int _horStep;
            private readonly int _verStep;


            public TestGenerator(double minX, double minY, double maxX, double maxY, int horStep, int verStep)
            {
                _minX = minX;
                _minY = minY;
                _maxX = maxX;
                _maxY = maxY;
                _horStep = horStep;
                _verStep = verStep;
            }

        
            public void AddTest(string layout)
            {
                // TODO:
            }

            public string Output()
            {
                // TODO:
                return "TODO";
            }
        }
    }
}