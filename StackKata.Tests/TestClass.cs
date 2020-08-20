using NUnit.Framework;
using System;

namespace StackKata.Tests
{
    [TestFixture]
    public class MyStackTests
    {
        [Test]
        public void New_created_stack_is_empty()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void New_created_stack_have_not_elements()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.AreEqual(0, stack.Count());
        }

        [Test]
        public void Pop_empty_stack_throw_exception()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.Catch<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Peak_empty_stack_throw_exception()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.Catch<InvalidOperationException>(() => stack.Peak());
        }
    }

    public class MyStack<T> : IMyStack<T>
    {
        public MyStack(){}
        public T Pop() { throw new InvalidOperationException(); }
        public void Push(T item) { throw new NotImplementedException(); }
        public T Peak() { throw new InvalidOperationException(); }
        public void Clear() { throw new NotImplementedException(); }
        public int Count() { return 0; }
        public bool IsEmpty() { return true; }
    }
}
