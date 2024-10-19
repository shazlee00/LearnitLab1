using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnitLab1
{
    public class Queue<T>
    {

        private T[] _items;
        private int _head;
        private int _tail;
        
        public Queue(int size)
        {
            _items = new T[size];
            _head = 0;
            _tail = 0;
        }
        public void Enqueue(T item)
        {
            if (_tail < _items.Length)
            {
                _items[_tail++] = item;
            }
            else
            {
throw new Exception("Queue is full");
            }

        }
        public T Dequeue()
        {
          if(_head > _tail)
            {
               return default(T);
            }

            return _items[_head++];

        }




    }
}
