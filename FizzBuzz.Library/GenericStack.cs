using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class GenericStack<T>
    {
        private List<T> items = new List<T>();

        public GenericStack<T> Push(T item)
        {
            if(item == null)
            {
                throw new Exception();
            }
            items.Add(item);
            return this;
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                return default(T);
            }
            var item = items[items.Count -1];
            items.RemoveAt(items.Count -1);
            return item;
        }
    }
}