using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        struct NewStruct
        {
            private int num1;
            private NewStruct(int incNum)
            {
                num1 = incNum;
            }
        }
    }
}
