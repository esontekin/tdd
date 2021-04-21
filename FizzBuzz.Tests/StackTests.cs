using System;
using FizzBuzz.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }
        
        [TestMethod]
        public void CanPopOffIMultipleItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            stack.Push("bar");
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }
        
        [TestMethod]
        public void CanPopFromEmptyStack()
        {
            var stack = new MyStack(100);
            Assert.AreEqual(null, stack.Pop());
        }

        [TestMethod]
        public void ShouldFailWhenPushingNull()
        {
            var stack = new MyStack(100);
            Assert.ThrowsException<Exception>(() =>
            {
                stack.Push(null);
            });
        }
    }
}