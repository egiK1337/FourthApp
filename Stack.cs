
namespace FourthApp
{
    public class Stack
    {
        public int Size { get; set; }
        public string? Top
        {
            get
            {
                if (_top != null)
                {
                    return _top.Value;
                }
                return null;
            }
            private set
            {
            }
        }
        private StackItem _top;

        public Stack(params string[] str)
        {
            foreach (string item in str)
            {
                var temp = _top;
                var newTop = new StackItem(item);
                newTop.Previous = temp;
                _top = newTop;
                Size++;
            }
            Top = _top.Value;
        }
        public Stack() 
        { 
        }
        public void Add(string value)
        {
            if (_top == null)
            {
                _top = new StackItem(value);
                Size++;
            }
            else
            {
                var temp = _top;
                var newTop = new StackItem(value);
                newTop.Previous = temp;
                _top = newTop;
                Size++;
            }
        }
        public string Pop()
        {
            Size--;
            if (Size == -1)
            {
                throw new Exception("Стек пустой");
            }
            var temp = _top.Value;
            _top = _top.Previous;
            return temp;
        }
        public static Stack Concat(params Stack[] stck)
        {
            var stk = new Stack();
            foreach (var item in stck)
            {
                var temp = item;
                var count = temp.Size;
                for (int i = 0; i < count; i++)
                {
                    stk.Add(temp.Pop());
                }
            }
            return stk;
        }
        private sealed class StackItem
        {
            public string Value { get; set; }
            public StackItem? Previous { get; set; }
            public StackItem(string value)
            {
                Value = value;
            }
        }
    }
}
