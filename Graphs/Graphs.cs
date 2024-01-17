namespace Graphs
{
    public class Graphs
    {

        public int Vertices { get; set; }
        public int[,] adjMatrix { get; set; }


        public Graphs(int n)
        {
            Vertices = n;
            adjMatrix = new int[n,n];
        }


        public void InsertEdge(int u, int v, int x)
        {
            adjMatrix[u, v] = x;
        }


        public void RemoveEdge(int u,  int v)
        {
            adjMatrix[u, v] = 0;
        }


        public bool existEdge(int u, int v)
        {
            return adjMatrix[u, v] != 0;
        }


        public int VerticesCount()
        {
            return Vertices;
        }


      

    }
}
