using Lab3_KiemThuNangCao;

namespace Testing_the_functions
{
    [TestFixture]
    public class Testing_Additions
    {
        [Test]
        public void Test1_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(1, -1));
        }
        [Test]
        public void Test2_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-1, 1));
        }
        [Test]
        public void Test3_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-1, -1));
        }
        [Test]
        public void Test4_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-10, 10));
        }
        [Test]
        public void Test5_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(10, -10));
        }
        [Test]
        public void Test6_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-10, -10));
        }
        [Test]
        public void Test7_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-100, 100));
        }
        [Test]
        public void Test8_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(100, -100));
        }
        [Test]
        public void Test9_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-100, -100));
        }
        [Test]
        public void Test10_Additions()
        {
            Assert.Throws<Exception>(() => Function_to_test.Additions(-1, -1));
        }
    }
    public class Testing_Divisions
    {
        [Test]
        public void Test1_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(1, 0));
        }
        [Test]
        public void Test2_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(0, 1));
        }
        [Test]
        public void Test3_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(0, 0));
        }
        [Test]
        public void Test4_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(10, 0));
        }
        [Test]
        public void Test5_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(0, 10));
        }
        [Test]
        public void Test6_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(-1, 0));
        }
        [Test]
        public void Test7_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(0, -1));
        }
        [Test]
        public void Test8_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(100, 0));
        }
        [Test]
        public void Test9_Divisions()
        {
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(0, 100));
        }
        [Test]
        public void Test10_Divisions()
        {
           Assert.Throws<DivideByZeroException>(() => Function_to_test.Divisions(0, 0));
        }
    }
    public class Testing_Average
    {
        [Test]
        public void Test1_Average()
        {
            int[] numbers = { };
            Assert.Throws<ArithmeticException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test2_Average()
        {
            int[] numbers = null;
            Assert.Throws<ArithmeticException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test3_Average()
        {
            int[] numbers = { 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test4_Average()
        {
            int[] numbers = { 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test5_Average()
        {
            int[] numbers = { 0, 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test6_Average()
        {
            int[] numbers = { 0, 0, 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test7_Average()
        {
            int[] numbers = { 0, 0, 0, 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test8_Average()
        {
            int[] numbers = { 0, 0, 0, 0, 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test9_Average()
        {
            int[] numbers = { 0, 0, 0, 0, 0, 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
        [Test]
        public void Test10_Average()
        {
            int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0 };
            Assert.Throws<DivideByZeroException>(() => Function_to_test.Average(numbers));
        }
    }
}