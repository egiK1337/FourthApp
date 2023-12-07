
namespace FourthApp
{
    public class Stack
    {
        public List<String> StrList { get; private set; } = new List<String>();
        public int? Size
        {
            get
            {
                return StrList.Count;
            }
            private set
            {
            }
        }
        public string? Top
        {
            get
            {
                if (StrList.Count > 0)
                {
                    return StrList[StrList.Count-1];
                }
                return null;
            }
            private set
            {
            }
        }
        public Stack(params string[] str)
        {
            foreach (string item in str)
            {
                StrList.Add(item);
            }
        }
        public void Add(params string[] str)
        {
            foreach (string item in str)
            {
                StrList.Add(item);
            }

        }
        public string Pop()
        {          
            if (StrList.Count <= 0)
            {
                throw new Exception("Стек пустой");
            }
            var str = StrList[StrList.Count - 1];
            StrList.RemoveAt(StrList.Count-1);
            return str;
        }
    }
}
