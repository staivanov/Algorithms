namespace Graphs
{
    public class Program
    {
        public static void Main()
        {
            GraphsADT g = new(7);
            //Unweighted graph.
            g.InsertEdge(0, 1, 1);
            g.InsertEdge(0, 5, 1);
            g.InsertEdge(0, 6, 1);
            g.InsertEdge(1, 0, 1);
            g.InsertEdge(1, 2, 1);
            g.InsertEdge(1, 5, 1);
            g.InsertEdge(1, 6, 1);
            g.InsertEdge(2, 3, 1);
            g.InsertEdge(2, 4, 1);
            g.InsertEdge(2, 6, 1);
            g.InsertEdge(3, 4, 1);
            g.InsertEdge(4, 2, 1);
            g.InsertEdge(4, 5, 1);
            g.InsertEdge(5, 2, 1);
            g.InsertEdge(5, 3, 1);
            g.InsertEdge(6, 3, 1);

            g.DFS(0);
        }
    }
}
