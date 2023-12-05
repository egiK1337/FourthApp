using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthApp
{
    public class Stack
    {
        public string Str { get; private set; }
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
        public string Top
        {
            get
            {
                if (StrList.Count > 0)
                {
                    return StrList[StrList.Count];
                }
                return null;
            }
            private set
            {
            }
        }

        public Stack()
        {

        }
        public Stack(IEnumerable<string> strings)
        {
            foreach (var item in strings)
            {
                StrList.Add(item);
            }
        }
        public Stack(string str)
        {
            Str = str;
        }
        public Stack(string str, List<String> strList)
        {
            Str = str;
            StrList = strList;
        }

        public void Add(String str)
        {
            StrList.Add(str);
        }

        public string Pop()
        {
            var str = StrList[StrList.Count];
            if (StrList.Count > 0)
            {
                throw new Exception("Стек пустой");
            }
            StrList.RemoveAt(StrList.Count);
            return str;
        }
    }
}
