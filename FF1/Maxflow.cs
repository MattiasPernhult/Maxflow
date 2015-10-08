using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1
{
    class Maxflow
    {
        private int[] path;
        private Queue<int> queue;
        private int numberOfNodes;
        private bool[] nodeVisited;
        public List<string> nodes = new List<string>();
        public Stack<int> stack = new Stack<int>();
        private List<int> rightNodes;

        public Maxflow(int number)
        {
            this.numberOfNodes = number;
            this.queue = new Queue<int>();
            path = new int[numberOfNodes];
            nodeVisited = new bool[numberOfNodes];
            rightNodes = new List<int>();
        }

        public bool bfs(int source, int sink, int[,] graph)
        {
            bool pathFound = false;
            int element;
            for (int nodes = 0; nodes < numberOfNodes; nodes++)
            {
                nodeVisited[nodes] = false;
            }

            queue.Enqueue(source);
            path[source] = -1;
            nodeVisited[source] = true;

            while (queue.Count != 0)
            {
                element = queue.Dequeue();

                for (int v = 0; v < numberOfNodes; v++)
                {
                    if (!nodeVisited[v] && graph[element, v] > 0)
                    {
                        queue.Enqueue(v);
                        path[v] = element;
                        nodeVisited[v] = true;
                    }
                }
            }
            if (nodeVisited[sink])
            {
                pathFound = true;
            }
            return pathFound;
        }

        public int FF(int[,] graph, int source, int sink)
        {
            int u, v;

            int[,] residualGraph = new int[numberOfNodes, numberOfNodes];

            for (u = 0; u < numberOfNodes; u++)
            {
                for (v = 0; v < numberOfNodes; v++)
                {
                    residualGraph[u, v] = graph[u, v];
                }
            }
            int maxFlow = 0;

            while (bfs(source, sink, residualGraph))
            {
                int flowCapacity = Int32.MaxValue;
                for (v = sink; v != source; v = path[v])
                {
                    u = path[v];
                    flowCapacity = Math.Min(flowCapacity, residualGraph[u, v]);
                }
                for (v = sink; v != source; v = path[v])
                {
                    u = path[v];
                    residualGraph[u, v] -= flowCapacity;
                    residualGraph[v, u] += flowCapacity;
                }
                maxFlow += flowCapacity;
            }
            AddMax(graph, residualGraph);
            return maxFlow;
        }

        private void AddMax(int[,] graph, int[,] rGraph)
        {
            for (int u = 0; u < numberOfNodes; u++)
            {
                for (int v = 0; v < numberOfNodes; v++)
                {
                    if (graph[u, v] == 1 && rGraph[v, u] == 1)
                    {
                        if (u != 0 && u != (numberOfNodes - 1) && v != (numberOfNodes -1) && v != 0)
                        {
                            stack.Push(v - 1);
                            stack.Push(u - 1);
                        }
                            
                    }
                }
            }
        }

        public bool bpm(bool[,] bpGraph, int u, bool[] seen, int[] matchR)
        {
            for (int v = 0; v < numberOfNodes; v++)
            {
                if (bpGraph[u, v] && !seen[v])
                {
                    seen[v] = true;
                    if (matchR[v] < 0 || bpm(bpGraph, matchR[v], seen, matchR))
                    {
                        matchR[v] = u;
                        return true;
                    }
                }
            }
            return false;
        }

        public int maxBPM(bool[,] bpGraph)
        {
            int[] matchR = new int[numberOfNodes];

            for (int n = 0; n < numberOfNodes; n++)
            {
                matchR[n] = -1;
            }

            bool[] seen = new bool[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
            {
                seen[i] = false;
            }

            int res = 0;
            for (int u = 0; u < numberOfNodes; u++)
            {
                if (bpm(bpGraph, u, seen, matchR))
                    res++;
            }
            for (int j = 0; j < numberOfNodes; j++)
            {
                if (matchR[j] != -1)
                {
                    
                }
            }
            return res;
        }
    }
}
