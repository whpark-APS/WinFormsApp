
using System;

namespace gtl.container
{
    class Stack<T>
    {
        Entry _top;

        public void Push(T data)
        {
            _top = new Entry(_top, data);
        }

        public T Pop()
        {
            if (_top == null)
                throw new InvalidOperationException("StackOverflowException");

            T data = _top._data;
            _top = _top._next;

            return data;
        }

        class Entry {
            public Entry _next;
            public T _data;

            public Entry(Entry next, T data) {
                _next = next;
                _data = data;
            }
        }
    }

    class Vector<T>
    {
        const int DEFAULT_CAPACITY = 16;

        T[] _items;
        int _count;

        public Vector(int capacity = DEFAULT_CAPACITY) {

        }
    }
}
