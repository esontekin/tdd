using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace FizzBuzz.Library
{
    public class ImmutableStack<T>
    {
        private T item;
        private int count;
        private ImmutableStack<T> previousStack;

        public int Count()
        {
            return count;
        }

        public ImmutableStack()
        {
            previousStack = null;
            count = 0;
            item = default(T);
        }

        private ImmutableStack(ImmutableStack<T> previousStack, int count, T item)
        {
            this.previousStack = previousStack;
            this.count = count;
            this.item = item;
        }

        public T Peek()
        {
            return item;
        }

        public ImmutableStack<T> Pop()
        {
            return previousStack;
        }

        public ImmutableStack<T> Push(T item)
        {
            return new ImmutableStack<T>(this, count + 1, item);
        }
        
    }
}