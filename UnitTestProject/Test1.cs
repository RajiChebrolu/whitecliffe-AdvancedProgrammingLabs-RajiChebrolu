namespace UnitTestProject
{
    [TestClass]
    public class Test1
    {
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UnitTestingLab.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }

        }
        [TestMethod]
        public void AddTwoIntegers_ReturnSum()
        {
            var add = new UnitTestingLab.Program();
            int expected = 8;
            int result = add.Addition(5, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SubtractTwoIntegers_ReturnSub()
        {
            var sub = new UnitTestingLab.Program();
            int expected = 3;
            int result = sub.Subtraction(5, 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivideTwoIntegers_ReturnQuotient()
        {
            var div = new UnitTestingLab.Program();
            double expected = 2.5;
            double result = div.Division(5, 2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero_ThrowException()
        {
            var d = new UnitTestingLab.Program();
            d.Division(5, 0);
        }

        [TestMethod]
        public void Factorial_Zero_ReturnsOne()
        {
            var fac = new UnitTestingLab.Program();
            long result = fac.Factorial(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Factorial_PositiveNumber_ReturnsResult()
        {
            var fac = new UnitTestingLab.Program();
            long expected = 120;
            long result = fac.Factorial(5);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void Factorial_NegativeNUmber_ThrowsException()
        {
            var fac = new UnitTestingLab.Program();
            fac.Factorial(-1);
        }

    }
}
