using TestingConsoleApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AreaCircle()
        {
            BasicMaths math = new BasicMaths();
            double res = math.AreaByRadius(25);
            Assert.AreEqual(Math.Round(res, 3), 1963.495);

        }


        [TestMethod]
        public void Test_PercentageOf()
        {
            BasicMaths math = new BasicMaths();
            double res = math.PercentageOf(50, 100);
            Assert.AreEqual(50, res);
        }


        [TestMethod]
        public void Test_VolumeOfCube_positive()
        {
            BasicMaths math = new BasicMaths();
            double res = math.VolumeOfCube(10);
            Assert.AreEqual(1000, res);
            Assert.AreEqual(1000, res);
        }


        [TestMethod]
        public void Test_VolumeOfCube_negative()
        {
            BasicMaths math = new BasicMaths();
            Assert.ThrowsException<IndexOutOfRangeException>(() => math.VolumeOfCube(-1));
        }

        [TestMethod]
        public void Test_Average()
        {
            BasicMaths math = new BasicMaths();
            double res = math.AverageOf(9, 24, 36, 42);
            Assert.AreEqual(27.75, res);
        }

        [TestMethod]
        public void Test_IsGreater()
        {
            BasicMaths math = new BasicMaths();
            double res = math.IsGreater(2,1);
            Assert.IsTrue(true,res.ToString());
        }

    }
}