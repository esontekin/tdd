
using FizzBuzz.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class ImmutableStackTests
    {
        [TestMethod]
        public void CanPushOffItem()
        {
            var stack = new ImmutableStack<string>();
            var fooStack = stack.Push("foo");
            Assert.AreEqual(0, stack.Count());
            Assert.AreEqual(1, fooStack.Count());
        }

        [TestMethod]
        public void CanPeekItem()
        {
            var stack = new ImmutableStack<string>();
            var fooStack = stack.Push("foo");
            Assert.AreEqual("foo", fooStack.Peek());
            Assert.AreEqual("foo", fooStack.Peek());
        }
        
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new ImmutableStack<string>();
            var barStack = stack.Push("foo").Push("bar");
            var fooStack = barStack.Pop();
            var emptyStack = fooStack.Pop();
            Assert.AreEqual(2, barStack.Count());
            Assert.AreEqual(1, fooStack.Count());
            Assert.AreEqual(0, emptyStack.Count());
        }
    }
}