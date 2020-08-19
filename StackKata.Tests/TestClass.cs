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

        public interface IMyStack<T>
        {
            T Pop();
            void Push(T item);
            T Peak();
            void Clear();
            int Count();
            bool IsEmpty();
        }

        public class MyStack<T> : IMyStack<T>
        {
            public MyStack(){}
            public T Pop() { throw new NotImplementedException(); }
            public void Push(T item) { throw new NotImplementedException(); }
            public T Peak() { throw new NotImplementedException(); }
            public void Clear() { throw new NotImplementedException(); }
            public int Count() { throw new NotImplementedException(); }
            public bool IsEmpty() { throw new NotImplementedException(); }
        }
    }
}
