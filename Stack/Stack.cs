using System;
using System.Collections;

namespace Stack
{
    public class Stack
    {
        private readonly ArrayList _stack;

        public Stack()
        {
            _stack = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot push a null object to the stack!");

            _stack.Add(obj);
        }

        public object Pop()
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
