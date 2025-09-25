namespace Evaluator.Core;

public class ExpressionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return Calulate(postfix);
    }

    private static List<string> InfixToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = new List<string>();
        int i = 0;
        while (i < infix.Length)
        {
            if (char.IsWhiteSpace(infix[i]))
            {
                i++;
                continue;
            }

            if (IsOperator(infix[i]))
            {
                if (infix[i] == ')')
                {
                    while (stack.Peek() != '(')
                        postfix.Add(stack.Pop().ToString());
                    stack.Pop(); // Remove '('
                }
                else
                {
                    while (stack.Count > 0 && PriorityInfix(infix[i]) <= PriorityStack(stack.Peek()))
                        postfix.Add(stack.Pop().ToString());
                    stack.Push(infix[i]);
                }
                i++;
            }
            else
            {
                // Parse multi-digit number (and decimals)
                int start = i;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                    i++;
                postfix.Add(infix.Substring(start, i - start));
            }
        }
        while (stack.Count > 0)
            postfix.Add(stack.Pop().ToString());
        return postfix;
    }

    private static bool IsOperator(char item) => item is '^' or '/' or '*' or '%' or '+' or '-' or '(' or ')';

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static double Calulate(List<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var token in postfix)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calulate(op1, token[0], op2));
            }
            else
            {
                stack.Push(Convert.ToDouble(token));
            }
        }
        return stack.Peek();
    }

    private static double Calulate(double op1, char item, double op2) => item switch
    {
        '*' => op1 * op2,
        '/' => op1 / op2,
        '^' => Math.Pow(op1, op2),
        '+' => op1 + op2,
        '-' => op1 - op2,
        _ => throw new Exception("Invalid expression."),
    };
}