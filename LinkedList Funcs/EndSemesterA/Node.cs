using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndSemesterA
{
    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node(T value)
        {
            this.value = value;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }


        public T GetValue()
        {
            return value;
        }

        public bool HasNext()
        {
            return this.next != null;
        }

        public int NumberOfNodes()
        {
            Node<T> current = this;
            int counter = 0;
            while (current != null)
            {
                counter++;
                current = current.next;
            }
            return counter;
        }
        public override string ToString()
        {
            string str = "";
            Node<T> current = this;

            while (current != null)
            {
                str += $"{current.value} ";
                current = current.next;
            }
            return str;
        }
    }
}
