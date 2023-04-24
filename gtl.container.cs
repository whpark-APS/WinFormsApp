
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

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
        public class EventArgs : System.EventArgs
        {
            public string msg { get; }
            public EventArgs(string msg) => this.msg = msg;

            public override string ToString() => msg;
        }

        public event EventHandler Changed;

        const int DEFAULT_CAPACITY = 4;

        T[] _items;
        int _count;

        public int count { get => _count; }
        public int capacity {
            get => _items.Length;
            set
            {
                if (value <= _items.Length) return;
                var newItems = new T[value];
                Array.Copy(_items, newItems, _count);
                _items = newItems;
            }
        }

        public T this[int index]
        {
            get => _items[index];
            set
            {
                if (object.Equals(_items[index], value))
                    return;
                T old = _items[index];
                _items[index] = value;
                OnChanged($"Changed {old} => {value}");
            }
        }

        public Vector(int capacity = DEFAULT_CAPACITY)
        {
            if (capacity < DEFAULT_CAPACITY)
                capacity = DEFAULT_CAPACITY;
            _items = new T[capacity];
            _count = 0;
        }
        ~Vector()
        {
            Debug.WriteLine("Destructor...");
        }

        public void Push(T item)
        {
            if (_count == capacity)
                capacity *= 2;
            _items[_count++] = item;
            OnChanged("Push");
        }
        public T Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("StackOverflowException");
            T r = _items[--_count];
            OnChanged("Pop");
            return r;
        }

        public virtual void OnChanged(string msg = "") => Changed?.Invoke(this, new EventArgs(msg));

        static bool Equals(Vector<T> a, Vector<T> b)
        {
            int ca = object.ReferenceEquals(a, null) ? 0 : a._count;
            int cb = object.ReferenceEquals(b, null) ? 0 : b._count;
            if (ca != cb) return false;
            for (int i = 0; i < a._count; i++)
            {
                if (!a._items[i].Equals(b._items[i]))
                    return false;
            }
            return true;
        }
        public static bool operator ==(Vector<T> a, Vector<T> b) => Equals(a, b);
        public static bool operator != (Vector<T> a, Vector<T> b) => !Equals(a, b);

    }
}
