using System;

public class Program
{
	public static void Main()
	{
		PStack<string> ps = new PStack<string>();
		ps.Push("A");
		ps.Push("B");
		ps.Push("C");
		ps.PrintPStack();
	}
}

public class PStack<TItem>
{
	private static readonly int MAX = 1000;
	private int top = -1;
	private TItem[] stack = new TItem[MAX];
	public PStack()
	{
		top = -1;
	}

	public bool IsEmpty()
	{
		return (top < 0);
	}

	public bool Push(TItem data)
	{
		if (top >= MAX)
		{
			//overflow
			return false;
		}
		else
		{
			stack[++top] = data;
			return true;
		}
	}

	public TItem Pop()
	{
		if (top < 0)
		{
			//no items in stack
			return default(TItem);
		}
		else
		{
			//lifo
			TItem data = stack[top--];
			return data;
		}
	}

	public void Peek()
	{
		if (top < 0)
		{
			Console.WriteLine("no elements in stack");
			return;
		}
		else
		{
			Console.WriteLine("top most element in stack is " + stack[top]);
		}
	}

	public void PrintPStack()
	{
		if (top < 0)
		{
			Console.WriteLine("stack is empty");
			return;
		}

		for (int i = top; i >= 0; i--)
		{
			Console.WriteLine(stack[i]); //lifo
		}
	}
}
