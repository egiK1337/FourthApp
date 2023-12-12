
namespace FourthApp
{
    internal class Program
    {       
        static void Main()
        {
            Stack s = new Stack("-2", "-1");
            Console.WriteLine($"Size = {s.Size}, Top = {s.Top}");
            s.Add("0");
            s.Add("1");
            s.Add("2");
            s.Add("3");
            Console.WriteLine($"Size = {s.Size}, Top = {s.Top}");
            var del = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{del}' Size = {s.Size}");
            s.Pop();
            s.Pop();
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            //s.Pop();
            s.Add("0");
            s.Add("1");
            s.Add("2");
            s.Add("3");
            Stack s1 = new Stack("1", "2", "3");
            Stack s2 = new Stack("a", "b", "c");
            var stackMerge = s.Merge(s1, s2);
            Stack s3 = new Stack("a", "b", "c");
            Stack s4 = new Stack("1", "2", "3");
            Stack s5 = new Stack("А", "Б", "В");
            Console.WriteLine($"");
            var stacksConcat = Stack.Concat(s3, s4, s5);
        }
    }
}