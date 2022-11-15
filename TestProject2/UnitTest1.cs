using StudentServiceLib;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_ShouldReturn_A()
        {
            Student s = new Student();
            s.Score = 8;
            var letter = s.getLetterScore();    
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7_ShouldReturn_B()
        {
            Student s = new Student();
            s.Score = 7;
            var letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score5_ShouldReturn_C()
        {
            Student s = new Student();
            s.Score = 5;
            var letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score3andHalf_ShouldReturn_D()
        {
            Student s = new Student();
            s.Score = 3.5;
            var letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Score3_ShouldReturn_E()
        {
            Student s = new Student();
            s.Score = 3;
            var letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}