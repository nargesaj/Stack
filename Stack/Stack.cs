using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T>
    {
        private readonly IList<T> _stack;

        public Stack()
        {
            _stack = new List<T>();
        }

        public void Push(T obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot push a null object to the stack!");

            _stack.Add(obj);
        }

        public T Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack is empty. Cannot pop from an empty stack!");

            var index = _stack.Count - 1;

            var obj = _stack[index];

            _stack.RemoveAt(index);

            return obj;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
