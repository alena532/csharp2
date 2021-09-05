using System;
namespace Lab1
{
    public class MyCustomCollection<T> : ICustomCollection<T>
        
    {
        public class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }
        Node<T> head;
        Node<T> kurs;
        int count;
        public MyCustomCollection(T data)
        {
            count = 0;
            Add(data);
        }
        public MyCustomCollection()
        {
            count = 0;
        }

        public T this[int index]
        {
            get
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
            set
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
        }


        public int Count => count;

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                ++count;
                return;
            }
            Node<T> temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
            ++count;
        }

        public T Current()
        {
            if (kurs != null)
                return kurs.Data;
            throw new Exception();
        }

        public void Next()
        {
            if (kurs != null && kurs.Next != null)
                kurs = kurs.Next;
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
                while (!temp.Data.Equals(item) || temp != null)
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
                    --count;
                }
            }
            throw new Exception();
        }

        public T RemoveCurrent()
        {
            Node<T> prev = null;
            Node<T> temp = head;
            if (kurs == null)
            {
                throw new Exception();
            }
            while (!temp.Data.Equals(kurs.Data))
            {
                prev = temp;
                temp = temp.Next;
            }
            Node<T> copy = temp;
            kurs = kurs.Next;
            if (prev == null)
                head = head.Next;
            else
            {
                prev.Next = temp.Next;
            }
            --count;
            return copy.Data;
        }

        public void Reset()
        {
            if (head != null)
            {
                kurs = head;
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
