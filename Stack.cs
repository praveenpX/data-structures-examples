using System;

public class Program
{
	public static void Main()
	{
		PStack ps = new PStack();
		ps.Push(1);
		ps.Push(2);
		ps.Push(3);
		ps.PrintPStack();
	}
}

public class PStack
{
	private static readonly int MAX = 1000;
	private int top = -1;
	private int[] stack = new int[MAX];
	public PStack()
	{
		top = -1;
	}

	public bool IsEmpty()
	{
		return (top < 0);
	}

	public bool Push(int data)
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

	public int Pop()
	{
		if (top < 0)
		{
			//no items in stack
			return 0;
		}
		else
		{
			//lifo
			int data = stack[top--];
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
