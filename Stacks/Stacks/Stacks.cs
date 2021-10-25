using System;
using System.Collections.Generic;

namespace Stacks
{
    public class Stacks<T>
    {
        private readonly List<T> _list = new List<T>();

        public int Count => _list.Count;

        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            _list.Add(obj);
        }

    }
}
