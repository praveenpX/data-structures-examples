using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		Set<int> items = new Set<int>(2);
		
		items.Add(1);
		items.Add(2);
		items.Add(3);
		
		Console.WriteLine(items.Size());
		Console.WriteLine(items._Capacity);
		Console.WriteLine(items.Contains(1));
		Console.WriteLine(items.Contains(2));
		Console.WriteLine(items.Contains(3));
	}
}


public class Set<TItem>
{
    private int _Size {get; set;}
    
    public int _Capacity {get; set;}
    
    private TItem[] _Items {get; set;}
    
    
    public Set(int capacity)
    {
        _Capacity = capacity;
        _Items = new TItem[_Capacity];
        _Size = 0;
    }
    
    public bool IsEmpty()
    {
        return _Size == 0;
    }
    
    public int Size()
    {
        return _Size;
    }
    
    public void Clear()
    {
        _Items = null;
        _Size = 0;
    }
    
    public bool Contains(TItem item)
    {
        for(int i =0; i < _Size; i++)
		{
			if(_Items[i].Equals(item))
            {
                return true;
            }
		}
		return false;
    }
    
    public void Add(TItem item)
    {
        
		if(Contains(item))
            return;
            
        if(_Size >= _Capacity)
        {
            _Capacity = _Capacity *2;
			
			TItem[] temp = _Items;
            
            Array.Resize<TItem>(ref temp, _Capacity);
			
			_Items = temp;
        }
        _Items[_Size] = item;
		_Size++;
    }
    
    public bool Remove(TItem item)
    {
        if(IsEmpty())
            return false;
        
        for(int i =0; i<_Capacity; i++)
        {
            if(_Items[i].Equals(item))
            {
                _Items[i] = _Items[_Size - 1];
                _Size--;
                return true;
            }
        }
        return false;
    }
}
