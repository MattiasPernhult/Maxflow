using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF1
{
    class Graph
    {
        private int source;
        private int sink;
        private int totalNodes;
        private int leftNodes;
        private int rightNodes;
        private int[,] graph;

        public Graph(int leftNodes, int rightNodes)
        {
            this.leftNodes = leftNodes;
            this.rightNodes = rightNodes;
            this.totalNodes = this.leftNodes + this.rightNodes + 2;
            this.source = 0;
            this.sink = totalNodes - 1;
            this.graph = new int[totalNodes, totalNodes];
            AddSource();
            AddSink();
        }

        public void AddSource()
        {
            for (int i = 1; i <= leftNodes; i++)
            {
                graph[source, i] = 1;
            }
        }

        public void AddSink()
        {
            for (int i = leftNodes + 1; i < totalNodes; i++)
            {
                graph[i, sink] = 1;
            }
        }

        public bool AddEdge(int left, int right)
        {
            if (graph[left, right] == 0)
            {
                graph[left, right] = 1;
                return true;
            }
            return false;
        }

        public bool RemoveEdge(int left, int right)
        {
            if (graph[left, right] == 1)
            {
                graph[left, right] = 0;
                return true;
            }
            return false;
        }

        public int[,] TheGraph
        {
            get { return graph; }
        }

        public int TotalNodes
        {
            get { return totalNodes; }
        }

        public int Source
        {
            get { return source; }
        }

        public int Sink
        {
            get { return sink; }
        }
    }
}
