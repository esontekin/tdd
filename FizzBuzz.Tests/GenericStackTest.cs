using System;
using FizzBuzz.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class GenericStackTest
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new GenericStack<string>();
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }
        
        public void CanPopOffIMultipleItem()
        {
            var stack = new GenericStack<string>();
            stack.Push("foo")
                .Push("bar");
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }
        
        [TestMethod]
        public void CanPopFromEmptyStack()
        {
            var stack = new GenericStack<string>();
            Assert.AreEqual(null, stack.Pop());
        }

        [TestMethod]
        public void ShouldFailWhenPushingNull()
        {
            var stack = new GenericStack<string>();
            Assert.ThrowsException<Exception>(() =>
            {
                stack.Push(null);
            });
        }
    }
}