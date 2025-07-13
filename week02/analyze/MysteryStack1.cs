public static class MysteryStack1
{
    public static string Run(string text)
    {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}

//it pushes every character of the string text onto a stack
//the it pops characters one by one, adding them to result
//since stacks are LIFO (Last In, First Out), teh function reverses the string 
