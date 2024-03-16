namespace Graphs
{
    public class GraphsADT
    {
        public int Vertices { get; set; }
        public int[,] AdjMatrix { get; set; }

        public GraphsADT(int n)
        {
            Vertices = n;
            AdjMatrix = new int[n, n];
        }

        public void InsertEdge(int u, int v, int x)
            => AdjMatrix[u, v] = x;

        public void RemoveEdge(int u, int v)
            => AdjMatrix[u, v] = 0;

        public bool ExistEdge(int u, int v)
            => AdjMatrix[u, v] != 0;

        public int VerticesCount()
            => Vertices;

        public int EdgeCount()
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

        public void Edges()
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

        public void Display()
        {
            int i,
                j;

            for(i = 0; i < Vertices; i++)
            {
                for(j = 0; j < Vertices; j++)
                {
                    Console.Write(AdjMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
