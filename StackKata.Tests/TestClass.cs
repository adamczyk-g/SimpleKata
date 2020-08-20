using NUnit.Framework;
using System;
using System.Collections.Generic;

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

        [Test]
        public void Empty_stack_after_push_one_element_is_stack_with_one_element()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(123);
            Assert.AreEqual(1, stack.Count());
        }
    }


    public class MyStack<T> : IMyStack<T>
    {
        private readonly List<T> innerList = new List<T>();
        public MyStack(){}
        public T Pop() { throw new InvalidOperationException(); }
        public void Push(T item) { innerList.Add(item); }
        public T Peak() { throw new InvalidOperationException(); }
        public void Clear() { throw new NotImplementedException(); }
        public int Count() { return innerList.Count; }
        public bool IsEmpty() { return true; }
    }
}
