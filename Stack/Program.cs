using System;
using System.Diagnostics;
using System.Threading;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Created labs

            

            #region ListStack Lab1 test
            
            //Console.WriteLine("Алгортим");
            //var stackRdy = new Model.Stack<int>();           
            //stackRdy.Push(1);
            //stackRdy.Push(40);
            //stackRdy.Push(532);
            //stackRdy.Pop();
            //Console.WriteLine(stackRdy.Peek() + " " + stackRdy.Pop()+ " "+stackRdy.Peek());
            //123123
            #endregion
                       
            #region Types Of Sorting 

            Console.WriteLine("Generated array: ");
            int amountElems = 5;
            Random rnd = new Random();
            var array = new int[60];  
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(amountElems);
            }
            foreach (var arr in array)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine("\n");

            var dopArr = array;

            Stopwatch sw = new Stopwatch();
            var time=sw.Elapsed;
            sw.Reset();

            //Counting sort
            //sw.Start();
            //CountingSort.countingSort(dopArr, 0, amountElems-1);
            //sw.Stop();
            //time = sw.Elapsed;
            //Console.WriteLine("Time of Counting Sort: " + time);
            //Console.WriteLine("Array in Counting Sort: {0}", string.Join("/", CountingSort.countingSort(dopArr,0,amountElems-1)));
            //Console.WriteLine();
            //sw.Reset();
            
            //Insert sort
            dopArr = array;
            sw.Start();
            Console.WriteLine("Array in insert sort: {0}", string.Join(" / ", InsertSort.InsertionSort(array)));
            InsertSort.InsertionSort(dopArr);
            sw.Stop();
            time = sw.Elapsed;
            Console.WriteLine("Time of Insertion Sort" + time);
            sw.Reset();

            //Merge sort
            dopArr = array;
            sw.Start();
            MergeSort.MergeSorting(dopArr, 0, array.Length);

            sw.Stop();
            Console.WriteLine("Array in merge sort: {0}", string.Join(" / ", MergeSort.MergeSorting(dopArr, 0, dopArr.Length)));
            time = sw.Elapsed;
            Console.WriteLine("Time of Merge Sort: " + time);
            sw.Reset();

            //Bubble sort O(n^2)
            //dopArr = array;
            //sw.Start();
            //BubbleSort.bubbleSort(dopArr);
            //sw.Stop();
            //time = sw.Elapsed;
            //Console.WriteLine("Time of Bubble Sort: " + time);
            //Console.WriteLine("Array in Bubble sort: {0}", string.Join(" / ", BubbleSort.bubbleSort(dopArr)));
            //Console.WriteLine();
            //sw.Reset();

            //Shell sort w(k^n)
            //dopArr = array;
            //sw.Start();
            //ShellSort.shellSort(dopArr);
            //sw.Stop();
            //time = sw.Elapsed;
            //Console.WriteLine("Time of Shell Sort: " + time);
            //Console.WriteLine("Array in Shell sort: {0}", string.Join(" / ", ShellSort.shellSort(dopArr)));
            //Console.WriteLine();
            //sw.Reset();

            //Quick sort O(n×logn)
            // dopArr = array;
            // sw.Start();
            // // QuickSort.quickSort(dopArr);
            // sw.Stop();
            // time = sw.Elapsed;
            //// Console.WriteLine("Time of quick Sort: " + time);
            // sw.Reset();


            #endregion


            
            #region SelecProblem

            Console.Write("Selected activities:");
            //int[] f = { 1, 3, 0, 5, 8, 5 };
            //int[] l = { 2, 4, 6, 7, 9, 9 };
            int[] f = { 10, 12, 20, 21, 26 };
            int[] l = { 20, 25, 25, 40, 35 };
            int n = f.Length;
            ChangeEvent.choose(n, f, l);

            #endregion


            #region Dynamic

            Dynamic.check("abcdfd", "adasdacdfd");

            #endregion
            

            #region BinaryTree 3lab
            
            //var tree = new BinaryTree();
            //tree.Insert(55);
            //tree.Insert(100);
            //tree.Insert(77);
            //tree.Insert(66);
            //tree.Insert(34);
            //BinaryTreeOutput.Print(tree);
            //tree.Remove(66);
            //BinaryTreeOutput.Print(tree);
        
            #endregion
            #endregion


            #region Graph
            
            // var graph = new Graph();

            // var v1 = new Vertex(1);
            // var v2 = new Vertex(2);
            // var v3 = new Vertex(3);
            // var v4 = new Vertex(4);
            // var v5 = new Vertex(5);
            // var v6 = new Vertex(6);
            // var v7 = new Vertex(7);

            //graph.AddVertex(v1);
            //graph.AddVertex(v2);
            //graph.AddVertex(v3);
            //graph.AddVertex(v4);
            //graph.AddVertex(v5);
            //graph.AddVertex(v6);
            //graph.AddVertex(v7);

            //graph.AddEdge(v1, v2);
            //graph.AddEdge(v1, v3);
            //graph.AddEdge(v4, v5);
            //graph.AddEdge(v2, v5);
            //graph.AddEdge(v2, v6);
            //graph.AddEdge(v6, v5);

            /////
            ///// Adjacency graph
            /////
            //GetVertex(graph, v1);
            //GetVertex(graph, v2);
            //GetVertex(graph, v3);
            //GetVertex(graph, v4);
            //GetVertex(graph, v5);
            //GetVertex(graph, v6);
            //GetVertex(graph, v7);
            

            #endregion


            #region Dijkstra

            //int [,] graph_1 =  {
            //             { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
            //             { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
            //             { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
            //             { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
            //             { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            //             { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
            //             { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
            //             { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
            //             { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
            //                };
            //for (int i = 0; i < 9; i++)
            //{
            //    Console.Write(i + 1 + " ");
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.Write("[" + graph_1[i, j] + "]"+ "\t");
            //    }
            //    Console.WriteLine();
            //}            
            //DijkstraAlgo(graph_1,  3, 9);

            #endregion


            #region Hash 4lab

            //var Table = new HashTable();
            //Table.insert(19, "Book");
            //Table.insert(9, "Book2");
            //Table.insert(20, "Book3");
            //Table.insert(100, "Book4");
            //Table.insert(15, "Book5");

            //Table.print();

            #endregion


            #region SeparateHashing
            //var sh = new SeparateHashing();
            //sh.insert(10, "first");
            //sh.insert(10, "second");
            //sh.print();
            //Console.WriteLine(sh.retrieve(10));
            //sh.remove(10);
            //Console.WriteLine(sh.retrieve(10));
            #endregion
            //#endregion


            Console.ReadLine();
        }


        #region adds
        private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number + ": ");
            foreach (var v in graph.GetVertexLists(vertex))
            {
                Console.Write(v.Number + ", ");
            }
            Console.WriteLine();
        }

        public static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public static void Print(int[] distance, int verticesCount, int source)
        {
            Console.WriteLine("Vertex    Distance from source");

            for (int i = 0; i < verticesCount; ++i)
                Console.WriteLine("{0} => {1}\t {2}", source, i, distance[i]);
        }

        public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            Print(distance, verticesCount, source);
        }
        #endregion
    }
}
