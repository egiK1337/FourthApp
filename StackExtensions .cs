
namespace FourthApp
{
    public static class StackExtensions
    {
        public static Stack Merge(this Stack stck, Stack s1, Stack s2)
        {
            var count = s2.Size;
            for (int i = 0; i < count; i++)
            {
                s1.Add(s2.Pop());
            }
                return s1;
        }
    }
}
