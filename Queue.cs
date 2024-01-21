namespace Unit4
{
    public class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;

        public Queue()
        {
            first = null;
            last = null;
        }

        public bool IsEmpty()
        {
            return last==null;
        }

        public void Insert(T x)
        {
            if (IsEmpty())
            {
                last = new Node<T>(x);
                first = last;
            }
            else
            {
                last.SetNext(new Node<T>(x));
                last = last.GetNext();
            }
            
        }

        public T Remove()
        {
            Node<T> temp = first;
            first = first.GetNext();
            return temp.GetValue();
        }

        public T Head()
        {
            return this.first.GetValue();
        }

        public override string ToString()
        {
            Node<T> iter = first;
            string text = "";
            while (iter != null)
            {
                text += iter.GetValue().ToString();
                iter = iter.GetNext();
            }
            return text;
        }
    }
}
