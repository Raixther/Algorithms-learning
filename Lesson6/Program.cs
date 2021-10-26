using System;


namespace Lesson6
{
	class Program
	{
		static void Main(string[] args)
		{
			Graph G = new(7);

			G.AddEdge(0, 1);

			G.AddEdge(0, 2);

			G.AddEdge(3, 5);

			G.AddEdge(6, 2);

			G.AddEdge(1, 3);

			G.AddEdge(3, 2);

			G.AddEdge(4, 5);

			G.AddEdge(6, 4);

			G.DFS(0);

			Console.WriteLine();

			G.BFS(0);


			Console.ReadKey();
			
		}
	}
}