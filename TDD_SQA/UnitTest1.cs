namespace TDD_SQA
{
    public class Tests
    {
        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();             
        }

        [Test]
        public void OnePlusOneTwo()
        {
            Assert.AreEqual(2, cal.add(2, 1));
        }

        [Test]
        public void AddingBigInt()
        {
            Assert.AreEqual(double.MaxValue + 1, cal.add(int.MaxValue, 1));
        }

        [Test]
        public void Adding_Floats()
        {
            Assert.AreEqual(5.5, cal.add(2.3, 3.2));
        }

        [Test]
        public void Adding_Strings()
        {
            Assert.AreEqual("helloWorld", cal.add("hello", "World"));
        }

        [Test]
        public void AddingWrongString()
        {
            Assert.AreEqual("Hello", cal.add("Hell", "lo"));
        }

        [Test]
        public void MinusINt()
        {
            Assert.AreEqual(5, cal.substract(7, 2));
        }

        [Test]

        public void DivideAndConquer()
        {
            Assert.AreEqual(2.5, cal.divide(5, 2));
        }



    }
}