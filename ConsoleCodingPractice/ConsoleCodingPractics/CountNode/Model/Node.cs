using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCodingPractics.CountNode.Model
{
    public class Node
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Node> Children { get; set; } = new();
    }
}
