using System;
namespace Lab1
{
    public class MyCustomCollection<T> : ICustomCollection<T>
        
    {
        private class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }
        Node<T> head;
        Node<T> current;
        public int Count { get; set; }
        public MyCustomCollection(T data)
        {
            Count = 0;
            Add(data);
        }
        public MyCustomCollection()
        {
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (Count >= index)
                {
                    int counting = 0;
                    Node<T> temp = head;
                    while (counting != index)
                    {
                        temp = temp.Next;
                        counting++;
                    }
                    return temp.Data;
                }
                else
                {
                    throw new Exception();
                }
            }
            set
            {
                if(Count >= index)
                {
                    int counting = 0;
                    Node<T> temp = head;
                    while (counting != index)
                    {
                        temp = temp.Next;
                        counting++;
                    }
                    temp.Data = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                ++Count;
                return;
            }
            Node<T> temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
            ++Count;
        }

        public T Current()
        {
            
                return current.Data;
            
        }

        public void Next()
        {
            if (current != null)
                current = current.Next;
            else
            {
                throw new Exception();
            }
        }

        public void Remove(T item)
        {
            if (head != null)
            {
                Node<T> temp = head;
                Node<T> prev = null;
                while (!temp.Data.Equals(item) && temp != null)
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (temp == null)
                {
                    throw new Exception();
                }
                else
                {
                    if (prev == null)
                        head = head.Next;
                    else
                    {   
                        prev.Next = temp.Next;
                    }
                    --Count;
                }
            }
            else
            {
                throw new Exception();
            }
        }

        public T RemoveCurrent()
        {
            Node<T> prev = null;
            Node<T> temp = head;
            if (current == null)
            {
                throw new Exception();
            }
            while (!temp.Data.Equals(current.Data))
            {
                prev = temp;
                temp = temp.Next;
            }
            Node<T> copy = temp;
            current = current.Next;
            if (prev == null)
                head = head.Next;
            else
            {
                prev.Next = temp.Next;
            }
            --Count;
            return copy.Data;
        }

        public void Reset()
        {
            if (head != null)
            {
                current = head;
            }
            else
            {
                throw new Exception();
            }
        }
        public void  Show()
        {
            Node<T> temp = head;
            while (temp!=null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

        }
    }
}
