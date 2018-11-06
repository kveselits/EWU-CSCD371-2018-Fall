using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           NotNullable<string> notNull = new NotNullable<string>();
           Assert.IsNotNull(notNull.Value);
        }
    }

    public struct NotNullable<T>
    {
        public T Value { get; internal set; }
    }

    public class Factory<T> : IFactory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
    class StringFactory : IFactory<string>
    {
        public string Create()
        {
            string str = default;
            return str;
        }
    }

    public interface IFactory<T>
    {
        T Create();
    }
}
