
namespace FourthApp
{
    internal class Program
    {
        static void Main()
        {
            Stack stack = new Stack("-2", "-1");
            Console.WriteLine($"Size = {stack.Size}, Top = {stack.Top}");
            stack.Add("0", "1", "2", "3");
            Console.WriteLine($"Size = {stack.Size}, Top = {stack.Top}");
            var del = stack.Pop();
            Console.WriteLine($"Извлек верхний элемент '{del}' Size = {stack.Size}");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            //Тут действие для демонстрации возврата null при попытке извлечения из пустого стэка
            //Console.WriteLine($"size = {stack.Size}, Top = {(stack.Top == null ? "null" : stack.Top)}");
            stack.Add("0", "1", "2", "3");
            Stack s1 = new Stack("1", "2", "3");
            Stack s2 = new Stack("a", "b", "c");
           var stackMerge = stack.Merge(s1, s2);
            Stack s3 = new Stack("a", "b", "c");
            Stack s4 = new Stack("1", "2", "3");
            Stack s5 = new Stack("А", "Б", "В");
            Console.WriteLine($"");
            var stacksConcat = Stack.Concat(s3 , s4 , s5 );

        }
    }
}