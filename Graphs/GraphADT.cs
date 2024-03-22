namespace Graphs
{
    public class GraphsADT
    {
        public int Vertices { get; set; }
        public int[,] AdjMatrix { get; set; }
        public int[] Visited { get; set; }

        public GraphsADT(int n)
        {
            Vertices = n;
            AdjMatrix = new int[n, n];
            Visited = new int[Vertices];
        }

        public void InsertEdge(int u, int v, int x)
            => AdjMatrix[u, v] = x;

        public void RemoveEdge(int u, int v)
            => AdjMatrix[u, v] = 0;

        public bool IsEdgeExist(int u, int v)
            => AdjMatrix[u, v] != 0;

        public int GetVerticesCount()
            => Vertices;

        public int GetEdgeCount()
        {
            int count = 0,
                i,
                j;

            for (i = 0; i < Vertices; i++)
            {
                for (j = 0; j < Vertices; j++)
                {
                    if (AdjMatrix[i, j] != 0)
                        count++;
                }
            }

            return count;
        }


        public void GetEdges()
        {
            Console.WriteLine("Edges: ");
            int i,
                j,
                zeroEdge = 0;

            for (i = 0; i < Vertices; i++)
            {
                for (j = 0; j < Vertices; j++)
                {
                    if (AdjMatrix[i, j] != zeroEdge)
                        Console.WriteLine(i + "--" + j);
                }
            }
        }


        public int Outdegree(int v)
        {
            int count = 0,
                i,
                zeroEdge = 0;

            for (i = 0; i < Vertices; i++)
            {
                if (AdjMatrix[v, i] != zeroEdge)
                    count += 1;
            }

            return count;
        }


        public int Indegree(int v)
        {
            int count = 0,
                i,
                zeroEdge = 0;

            for (i = 0; i < Vertices; i++)
            {
                if (AdjMatrix[v, i] != zeroEdge)
                    count++;
            }

            return count;
        }

        //Parameter 's' is a start vertex.
        public void BFS(int s)
        {
            int i = s;
            Queue<int> q = new();
            int[] visited = new int[Vertices];
            Console.Write(i + " ");
            //Vertex 'i' is visited;
            visited[i] = 1;
            q.Enqueue(i);

            while (q.Count > 0)
            {
                i = q.Dequeue();

                for (int j = 0; j < Vertices; j++)
                {       //Check is there edge between 'i' and 'j'
                    bool isThereEdge = AdjMatrix[i, j] == 1,
                         isVertexNotVisited = visited[j] == 0;

                    if (isThereEdge && isVertexNotVisited)
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;
                        q.Enqueue(j);
                    }
                }
            }
        }


        public void DFS(int s)
        {
            bool isNotVisited = Visited[s] == 0;

            if (isNotVisited)
            {
                Console.Write(s + " ");
                Visited[s] = 1;

                for (int j = 0; j < Vertices; j++)
                {
                    bool isVortexExist = AdjMatrix[s, j] == 1;

                    if (isVortexExist && Visited[j] == 0)
                    {
                        DFS(j);
                    }
                }
            }
        }


        public void Display()
        {
            int i,
                j;

            for (i = 0; i < Vertices; i++)
            {
                for (j = 0; j < Vertices; j++)
                {
                    Console.Write(AdjMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
