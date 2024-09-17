// mathimatical function attempt


public class Token
{
    public string Value { get; }
    public Token(string value)
    {
        Value = value;
    }
}

public class Math_Tokenizer
{
    private static readonly Regex tokenPattern = new Regex(@"\d+|true|false|\+|\-|\*|\/|\%|\(|\)|&&|\|\||!|<=|>=|<|>|==");

    public static List<Token> Tokenize(string expression)
    {
        var matches = tokenPattern.Matches(expression);
        var tokens = new List<Token>();

        foreach (Match match in matches)
        {
            tokens.Add(new Token(match.Value));
        }

        return tokens;
    }
}

public abstract class AstNode
{
    public abstract double Evaluate();
    public virtual bool EvaluateBoolean() => throw new Exception("Cannot evaluate as Boolean.");
}

public class NumberNode : AstNode
{
    public double Value { get; }

    public NumberNode(double value)
    {
        Value = value;
    }

    public override double Evaluate()
    {
        return Value;
    }
}

public class BooleanNode : AstNode
{
    public bool Value { get; }

    public BooleanNode(bool value)
    {
        Value = value;
    }

    public override bool EvaluateBoolean()
    {
        return Value;
    }

    public override double Evaluate()
    {
        return Value ? 1.0 : 0.0;
    }
}

public class BinaryOpNode : AstNode
{
    public AstNode Left { get; }
    public AstNode Right { get; }
    public string Operator { get; }

    public BinaryOpNode(AstNode left, AstNode right, string operatorSymbol)
    {
        Left = left;
        Right = right;
        Operator = operatorSymbol;
    }

    public override double Evaluate()
    {
        switch (Operator)
        {
            case "+": return Left.Evaluate() + Right.Evaluate();
            case "-": return Left.Evaluate() - Right.Evaluate();
            case "*": return Left.Evaluate() * Right.Evaluate();
            case "/": return Left.Evaluate() / Right.Evaluate();
            case "%": return Left.Evaluate() % Right.Evaluate();
            default: throw new Exception("Unknown operator");
        }
    }

    public override bool EvaluateBoolean()
    {
        switch (Operator)
        {
            case "&&": return Left.EvaluateBoolean() && Right.EvaluateBoolean();
            case "||": return Left.EvaluateBoolean() || Right.EvaluateBoolean();
            case "==": return Left.EvaluateBoolean() == Right.EvaluateBoolean();
            case "<": return Left.Evaluate() < Right.Evaluate();
            case ">": return Left.Evaluate() > Right.Evaluate();
            case "<=": return Left.Evaluate() <= Right.Evaluate();
            case ">=": return Left.Evaluate() >= Right.Evaluate();
            default: throw new Exception("Unknown boolean operator");
        }
    }
}

public class UnaryOpNode : AstNode
{
    public AstNode Operand { get; }
    public string Operator { get; }

    public UnaryOpNode(AstNode operand, string operatorSymbol)
    {
        Operand = operand;
        Operator = operatorSymbol;
    }

    public override double Evaluate()
    {
        throw new Exception("Unary operators are not supported in math expressions.");
    }

    public override bool EvaluateBoolean()
    {
        if (Operator == "!")
        {
            return !Operand.EvaluateBoolean();
        }

        throw new Exception("Unknown unary boolean operator");
    }
}

public class Parser
{
    private Queue<Token> tokens;
    private static readonly Dictionary<string, int> precedence = new Dictionary<string, int>()
    {
        { "||", 1 },
        { "&&", 2 },
        { "==", 3 }, { "<", 3 }, { ">", 3 }, { "<=", 3 }, { ">=", 3 },
        { "+", 4 }, { "-", 4 },
        { "*", 5 }, { "/", 5 }, { "%", 5 },
        { "!", 6 }
    };

    public Parser(List<Token> tokenList)
    {
        tokens = new Queue<Token>(tokenList);
    }

    public AstNode ParseMathExpression()
    {
        return ParseBinaryExpression(0, false);
    }

    public AstNode ParseBooleanExpression()
    {
        return ParseBinaryExpression(0, true);
    }

    private AstNode ParseBinaryExpression(int parentPrecedence, bool isBoolean)
    {
        var left = ParsePrimaryExpression(isBoolean);

        while (tokens.Count > 0 && precedence.ContainsKey(tokens.Peek().Value))
        {
            var op = tokens.Dequeue().Value;
            var currentPrecedence = precedence[op];

            if (currentPrecedence < parentPrecedence)
                break;

            var right = ParseBinaryExpression(currentPrecedence + 1, isBoolean);
            left = new BinaryOpNode(left, right, op);
        }

        return left;
    }

    private AstNode ParsePrimaryExpression(bool isBoolean)
    {
        var token = tokens.Dequeue();

        if (double.TryParse(token.Value, out double value))
        {
            return new NumberNode(value);
        }
        else if (token.Value == "true" || token.Value == "false")
        {
            return new BooleanNode(token.Value == "true");
        }
        else if (token.Value == "(")
        {
            var expression = ParseBinaryExpression(0, isBoolean);
            tokens.Dequeue();  // Discard closing ')'
            return expression;
        }
        else if (token.Value == "!" && isBoolean)
        {
            var operand = ParsePrimaryExpression(true);
            return new UnaryOpNode(operand, "!");
        }

        throw new Exception("Unexpected token");
    }
}


    // Math expression evaluator
    static double EvaluateMathExpression(string expression)
    {
        var tokens = Math_Tokenizer.Tokenize(expression);
        var parser = new Parser(tokens);
        AstNode ast = parser.ParseMathExpression();
        return ast.Evaluate();
    }

    // Boolean expression evaluator
    static bool EvaluateBooleanExpression(string expression)
    {
        var tokens = Math_Tokenizer.Tokenize(expression);
        var parser = new Parser(tokens);
        AstNode ast = parser.ParseBooleanExpression();
        return ast.EvaluateBoolean();
    }
	
	
public static double doMath(string[] equation, Data D, base_runner Base)
{
	string equationa = "";
	for (int i = 0; i < equation.Length; i++)
	{
		if (equation[i] == "+" || equation[i] == "-" || equation[i] == "/" || equation[i] == "*" || equation[i] == "sin" || equation[i] == "cos" || equation[i] == "tan" ||
							   equation[i] == "csc" || equation[i] == "sec" || equation[i] == "%" || equation[i] == "cot" || equation[i] == "root" || equation[i] == ")" || equation[i] == "(" || equation[i] == " ")
		{
			equationa += equation[i] + " ";
		}
		else if (D.isnumvar(equation[i].ToString()))
		{
			equationa += D.referenceVar(equation[i].ToString()) + " ";
		}
		else if (Mathss.ContainsKey(equation[i]))
		{
			string[] equationb = Mathss[equation[i]](equation, D, Base, i, 0);
			equationa += equationb[0] + " ";
			i += int.Parse(equationb[1]);
		}
		else if (double.TryParse(equation[i], out double k))
		{
			equationa += k + " ";
		}

	}
	return EvaluateMathExpression(equationa);
	
}

public static bool doMathbool(string[] equation, Data D, base_runner Base)
{
	string equationa = "";
	for (int i = 0; i < equation.Length; i++)
	{
		 if (equation[i] == "+" || equation[i] == "-" || equation[i] == "==" || equation[i] == "!=" || equation[i] == "<=" || equation[i] == ">=" || equation[i] == ">" || equation[i] == "<" || equation[i] == "/" || equation[i] == "*" || equation[i] == "sin" || equation[i] == "cos" || equation[i] == "tan" ||
								equation[i] == "csc" || equation[i] == "sec" || equation[i] == "%" || equation[i] == "cot" || equation[i] == "root" || equation[i] == ")" || equation[i] == "(" || equation[i] == " ")
		 {
			 equationa += equation[i] + " ";
		 }
		 else if (D.isnumvar(equation[i].ToString()))
		 {
			 equationa += D.referenceVar(equation[i].ToString()) + " ";
		 }
		 else if (D.
		 else if (Mathss.ContainsKey(equation[i]))
		 {
			 string[] equationb = Mathss[equation[i]](equation, D, Base, i, 0);
			 equationa += equationb[0] + " ";
			 i += int.Parse(equationb[1]);
		 }
		 else if (double.TryParse(equation[i], out double k))
		 {
			 equationa += equation[i] + " ";
		 }

	}
	return EvaluateBooleanExpression(equationa);
}

