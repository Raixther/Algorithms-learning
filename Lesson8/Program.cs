using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson8
{
	class Program
	{
		static void Main(string[] args)
		{
			Random R = new();
	

	
			int[] E = new int[100] ;

			
			for (int i = 0; i < E.Length; i++)
			{
				E[i] = R.Next(100);
			}
		
			BucketSort(E);

			foreach (var item in E)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}


	static  public void BucketSort(int[] arr)
	{
			if (arr == null || arr.Length < 2) return ;

			int bucketsNum = arr.Length;

			List<int>[] buckets = new List<int>[bucketsNum];

			for (int i = 0; i < bucketsNum; i++)
			{
				buckets[i] = new List<int>();
			}

			for (int i = 0; i < arr.Length; i++)
			{
				int bucket = arr[i] / bucketsNum;
				if (bucket>bucketsNum-1)
				{
					bucket = bucketsNum-1;
				}
				buckets[bucket].Add(arr[i]);
			}
			for (int i = 0; i < buckets.Length; i++)
			{
				buckets[i].Sort();
			}
			int k = 0;
			for (int i = 0; i < buckets.Length; i++)
			{
				if (buckets[i].Count>0)
				{
					for (int j = 0; j < buckets[i].Count; j++)
					{
						arr[k] = buckets[i][j];
						k++;
					}
				}				
			}			
		}
	}
}
