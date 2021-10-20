using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson6
{
    class Graph
    {
        private int vertices;

        private List<int>[] adj { get; set;}


		public Graph(int v)
		{
            vertices = v;
            adj = new List<int>[v];
			for (int i = 0; i < v; i++)
			{
                adj[i] = new List<int>();
			}
		}
        public void AddEdge(int a, int b)
		{
            adj[a].Add(b);
            adj[b].Add(a);
        }
     

       
        public void DFS(int a)
		{
            bool[] visited = new bool[vertices];

            Stack<int> S = new();

            visited[a] = true;

            S.Push(a);

           
            while (S.Count!=0)
			{
                a = S.Pop();
                Console.WriteLine(a);

                foreach (var item in adj[a])
				{
					if (!visited[item])
					{
                        visited[item] = true;
                        S.Push(item);
                        
					}
				}
			}

		}

        public void BFS(int a)
        {
            bool[] visited = new bool[vertices];

            Queue<int> Q = new();

            visited[a] = true;

            Q.Enqueue(a);


            while (Q.Count != 0)
            {
                a = Q.Dequeue();
                Console.WriteLine(a);

                foreach (var item in adj[a])
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        Q.Enqueue(item);
                    }
                }
            }

        }



    }
}
