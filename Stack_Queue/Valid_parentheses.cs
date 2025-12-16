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

    foreach (var c in s)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else
        {
            if (stack.Count == 0)
                return false;

            var top = stack.Pop();

            if ((c == ')' && top != '(') ||
                (c == '}' && top != '{') ||
                (c == ']' && top != '['))
            {
                return false;
            }
        }
    }

        return stack.Count == 0;
    }
