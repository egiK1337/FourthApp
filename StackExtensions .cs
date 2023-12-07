
namespace FourthApp
{
    public static class StackExtensions
    {
        public static Stack Merge(this Stack stck, Stack s1, Stack s2)
        {
            var list = new List<string>();
            var t = s2.Size;
            for (int i = 0; i < t; i++)
            {
                list.Add(s2.Pop());
            }
            for (int i = 0; i < list.Count; i++)
            {
                s1.Add(list[i]);
            }
                return s1;
        }
    }
}
