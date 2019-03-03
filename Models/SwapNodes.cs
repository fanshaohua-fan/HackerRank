using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Node{
    public int data;
    public Node left;
    public Node right;

    public Node(int input){
        data = input;
    }
}

class SwapNodes {

    static void traversal(Node node, List<int> list)
    {
        if(node.left != null)
        {
            traversal(node.left, list);
        }

        list.Add(node.data);

        if(node.right != null)
        {
            traversal(node.right, list);
        }
    }

    /*
     * Complete the swapNodes function below.
     */
    static int[][] swapNodes(int[][] indexes, int[] queries) {
        /*
         * Write your code here.
         */
        var dict = new Dictionary<int, Node>();

        var root = new Node(1);
        dict.Add(1, root);

        var n = queries.Length;

        int[][] result = new int[n][];

        for(var i = 1; i <= indexes.Length; i++)
        {
            var v1 = indexes[i - 1][0];
            var v2 = indexes[i - 1][1];

            if(v1 != -1)
            {
                var left = new Node(v1);
                dict[i].left = left;

                dict.Add(v1, left);
            }

            if(v2 != -1)
            {
                var right = new Node(v2);
                dict[i].right = right;

                dict.Add(v2, right);
            }
        }

        for(var q = 0; q < n; q++)
        {
            var k = queries[q];
            var depth = 1;

            var cur_nodes = new List<Node>();
            cur_nodes.Add(root);
            var next_nodes = new List<Node>();

            while( cur_nodes.Count() != 0  || next_nodes.Count() != 0  )
            {
                var swap = false;
                if(depth % k == 0)
                {
                    swap = true;
                }
                
                foreach(var node in cur_nodes)
                {
                    if(swap){
                        var tmp = node.right;
                        node.right = node.left;
                        node.left = tmp;
                    }

                    if(node.left != null)
                    {
                        next_nodes.Add(node.left);
                    }

                    if(node.right != null)
                    {
                        next_nodes.Add(node.right);
                    }
                }

                cur_nodes = next_nodes.ToList();
                if(next_nodes.Count() != 0)
                    depth += 1;
                next_nodes.Clear();
            }


            var list = new List<int>();

            traversal(root, list);

            result[q] = list.ToArray();
        }
        

        return result;
    }

    // static void Main(string[] args) {
    //     int n = Convert.ToInt32(Console.ReadLine());

    //     int[][] indexes = new int[n][];

    //     for (int indexesRowItr = 0; indexesRowItr < n; indexesRowItr++) {
    //         indexes[indexesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), indexesTemp => Convert.ToInt32(indexesTemp));
    //     }

    //     int queriesCount = Convert.ToInt32(Console.ReadLine());

    //     int[] queries = new int [queriesCount];

    //     for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++) {
    //         int queriesItem = Convert.ToInt32(Console.ReadLine());
    //         queries[queriesItr] = queriesItem;
    //     }

    //     int[][] result = swapNodes(indexes, queries);

    //     Console.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

    // }
}
