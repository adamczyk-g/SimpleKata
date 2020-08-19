using NUnit.Framework;
using System;

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

    public class MyStack<T>
    {
        T Pop() { throw new NotImplementedException(); }
        void Push(T item) { throw new NotImplementedException(); }
        T Peak(){ throw new NotImplementedException(); }
        void Clear() { throw new NotImplementedException(); }
        int Count() { throw new NotImplementedException(); }
        bool IsEmpty() { throw new NotImplementedException(); }
    }
}
