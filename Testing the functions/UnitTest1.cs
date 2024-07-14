using Lab3_KiemThuNangCao;

namespace Testing_the_functions
{
    [TestFixture]
    public class Testing_Additions
    {
        [Test]
        public void Test1_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(1, 1);
            int expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test2_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(-1, 1);
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test3_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(1, -1);
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test4_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(-1, -1);
            int expected = -2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test5_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(10, 10);
            int expected = 20;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test6_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(100, 100);
            int expected = 200;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test7_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(11, 11);
            int expected = 22;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test8_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(111, 111);
            int expected = 222;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test9_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(1234, 4321);
            int expected = 5555;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test10_Additions()
        {
            var func = new Function_to_test();
            int result = func.Additions(0987, 7890);
            int expected = 8877;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    public class Testing_Division
    {
        [Test]
        public void Test1_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(1, 1);
            int expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test2_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(0, 1);
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test3_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(1, 0);
            int expected = 0;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test4_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(0, 0);
            int expected = -2;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test5_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(10, 10);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test6_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(100, 100);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test7_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(11, 11);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test8_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(111, 111);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test9_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(10, 3);
            int expected = 10 / 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test10_Divisions()
        {
            var func = new Function_to_test();
            int result = func.Divisions(10, 5);
            int expected = 2;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}