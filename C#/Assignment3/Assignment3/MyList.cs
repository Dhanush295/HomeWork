using System;
namespace Assignment3
{
    public class MyList<T>
    {
        public List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        public void Add(T element)
        {
            _list.Add(element);
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            T item = _list[index];
            _list.RemoveAt(index);
            return item;
        }

        public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            _list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            _list.RemoveAt(index);
        }

        public T Find(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            return _list[index];
        }
    }
}

