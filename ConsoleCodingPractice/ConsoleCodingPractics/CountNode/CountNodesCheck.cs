using ConsoleCodingPractics.CountNode.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleCodingPractics.CountNode
{
    public class CountNodesCheck
    {
        public int CountNode()
        {
            string fileName = $"CountNode/Tree.json";
            string jsonString = File.ReadAllText(fileName);

            Node? node = JsonSerializer.Deserialize<Node>(jsonString);

            return CountNodeObject(node);
        }

        private int CountNodeObject(Node? node)
        {
            if (node == null) return 0;
            int count = 0;
            foreach (var child in node.Children)
            {
                count += CountNodeObject(child);
            }
            return count;
        }

        #region
        //  public int CountNode()
        //  {
        //      #region Dummy JSON Data
        //      string jsonString = @"
        //    {
        //    ""Id"": 1,
        //    ""Name"": ""Root"",
        //    ""Children"": [
        //        {
        //            ""Id"": 2,
        //            ""Name"": ""Child1"",
        //            ""Children"": [
        //                {
        //                    ""Id"": 4,
        //                    ""Name"": ""GrandChild1"",
        //                    ""Children"": []
        //                },
        //                {
        //                    ""Id"": 5,
        //                    ""Name"": ""GrandChild2"",
        //                    ""Children"": []
        //                }
        //            ]
        //        },
        //        {
        //            ""Id"": 3,
        //            ""Name"": ""Child2"",
        //            ""Children"": []
        //        }
        //    ]
        //}";
        //      #endregion
        //      string filePath = $"CountNode/Tree.json";
        //      string json = File.ReadAllText(filePath);

        //      Node? root = JsonSerializer.Deserialize<Node?>(json);

        //      return CountNodesInGenericTree(root);
        //  }

        //  public int CountNodesInGenericTree(Node root)
        //  {
        //      if (root == null) return 0;
        //      int count = 1; // Count the current node
        //      foreach (var child in root.Children)
        //      {
        //          count += CountNodesInGenericTree(child);
        //      }
        //      return count;
        //  }
        #endregion
    }
}
