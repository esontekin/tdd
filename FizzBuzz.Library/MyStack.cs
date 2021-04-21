using System;

namespace FizzBuzz.Library
{
    public class MyStack
    {
        private object[] items;
        private int currentIndex;
        public MyStack(int capacity)
        {
            items = new object[capacity];
            currentIndex = 0;
        }

        public void Push(object item)
        {
            if (item == null)
            {
                throw new Exception();
            }
            items[currentIndex] = item;
            currentIndex++;
        }

        public object Pop()
        {
            if (currentIndex == 0)
            {
                return null;
            }
            currentIndex--;
            var item = items[currentIndex];
            return item;
        }
    }
}