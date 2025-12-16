static void Main()
{
    // Input theo yêu cầu
    string input = "( ) { } [ ]";

    // Loại bỏ khoảng trắng
    string normalizedInput = input.Replace(" ", "");

    bool result = IsValid(normalizedInput);

    Console.WriteLine($"Input : {input}");
    Console.WriteLine($"Output: {result}");
}

public static bool IsValid(string s)
{
    var stack = new Stack<char>();

    Console.WriteLine($"s : {s}");
    var count = 0;
    foreach (var c in s)
    {
        count += 1;
        Console.WriteLine($"c: {c}");
        if (c == '(' || c == '{' || c == '[')
        {
            Console.WriteLine("stack.Push");
            stack.Push(c);
        }
        else
        {
            if (stack.Count == 0)
                return false;

            var top = stack.Pop();
            Console.WriteLine($"top: {top}");
            Console.WriteLine($"c: {c}");
            if ((c == ')' && top != '(') ||
                (c == '}' && top != '{') ||
                (c == ']' && top != '['))
            {
                Console.WriteLine("return false");
                return false;
            }
        }
    }

        return stack.Count == 0;
    }
