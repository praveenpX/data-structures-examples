using System;
using System.Collections;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		HashMap<int, int> map = new HashMap<int, int>();
		
		map.Add(1,1);
		map.Add(2,2);
		map.Add(3,3);
		
		Console.WriteLine(map.Get(1));
		Console.WriteLine(map.Get(2));
		Console.WriteLine(map.Get(3));
		
		Console.WriteLine(map.IsEmpty());
		Console.WriteLine(map.Size());
		
		Console.WriteLine("Hello World");
	}
	
	public class HashNode<TKey, TValue>
	{
		public TKey Key {get; set;}
		
		public TValue Value {get; set;}
		
		public HashNode<TKey, TValue> Next {get; set;}
		
		public HashNode(TKey key, TValue value)
		{
			Key = key;
			Value = value;
			
			Next = null;
		}
	}
	
	public class HashMap<TKey, TValue>
	{
		private List<HashNode<TKey, TValue>> _Items = new List<HashNode<TKey, TValue>>();
		
		private int _NumberOfBuckets {get; set;}
		
		private int _Size {get; set;}
		
		public HashMap()
		{
			_Items = new List<HashNode<TKey, TValue>>();
			
			_NumberOfBuckets = 10; //seed it by multiple of 10
			
			_Size = 0;
			
			//initialize the buckets
			for(int i =0;i <_NumberOfBuckets; i++)
			{
				_Items.Add(null);
			}
		}
		
		public int Size()
		{
			return _Size;
		}
		
		public bool IsEmpty()
		{
			return Size() == 0;
		}
		
		private int GetBucketIndex(TKey Key)
		{
			int hashCode = Key.GetHashCode();
			
			int index = hashCode % _NumberOfBuckets;
			
			return index;
		}
		
		public TValue Get(TKey key)
		{
			int bucketIndex = GetBucketIndex(key);
			
			HashNode<TKey, TValue> head = _Items[bucketIndex];
			
			while(head != null)
			{
				if(head.Key.Equals(key))
				{
					return head.Value;
				}
				head = head.Next;
			}
			
			return default(TValue); //no key found
		}
		
		public void Add(TKey key, TValue value)
		{
			int bucketIndex = GetBucketIndex(key);
			
			HashNode<TKey, TValue> head = _Items[bucketIndex];
			
			while(head != null) //if key is already present
			{
				if(head.Key.Equals(key))
				{
					head.Value = value;
					return;
				}
				head = head.Next;
			}
				
				//if not present
				_Size++;
				
				head = _Items[bucketIndex];
				
				HashNode<TKey, TValue> newNode = new HashNode<TKey, TValue>(key, value);
				
				newNode.Next = head;
				_Items.Insert(bucketIndex, newNode);
			
			//check for load factor and increase the size
				double _loadfactor = ((1.0 * _Size) / _NumberOfBuckets);
				if(_loadfactor >= 0.7)
				{
					List<HashNode<TKey, TValue>> temp = new List<HashNode<TKey, TValue>>();
					
					temp.AddRange(_Items);
					
					_Items = new List<HashNode<TKey, TValue>>();
					
					_NumberOfBuckets = _NumberOfBuckets * 2;
					_Size = 0;
					
					for(int i =0; i <_NumberOfBuckets; i++)
					{
						_Items.Add(null);
					}
					
					for(int i =0; i< temp.Count; i++)
					{
						HashNode<TKey, TValue> itemNode = temp[i];
						while(itemNode != null)
						{
							Add(itemNode.Key, itemNode.Value);
							itemNode = itemNode.Next;
						}
					}
				}
		}
	}
}
