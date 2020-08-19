using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace StackKata.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {

        }
    }

    public interface IMyStack<T>
    {
        T Pop();
        void Push(T item);
        T Peak();
        void Clear();
        int Count();
        bool IsEmpty();
    }
}
