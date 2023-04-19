using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalculator
{
    public class Branch
    {
        public List<Branch> branches = new List<Branch>();
    }

    public class Tree
    {
        public Branch Root;

        public int MaxDepth(Branch node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int maxDepth = 0;
                foreach (Branch child in node.branches)
                {
                    //Uses recursion to find the depth of the tree
                    int childDepth = MaxDepth(child);
                    if (childDepth > maxDepth)
                    {
                        maxDepth = childDepth;
                    }
                }
                return maxDepth + 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            //creates the root
            tree.Root = new Branch();
            //creates depth 1
            tree.Root.branches.Add(new Branch());
            tree.Root.branches.Add(new Branch());
            
            //creates depth 2
            tree.Root.branches[0].branches.Add(new Branch());
            //creates depth 3
            tree.Root.branches[1].branches.Add(new Branch());
            tree.Root.branches[1].branches.Add(new Branch());
            tree.Root.branches[1].branches.Add(new Branch());
            //created depth 4
            tree.Root.branches[1].branches[0].branches.Add(new Branch());
            tree.Root.branches[1].branches[1].branches.Add(new Branch());
            tree.Root.branches[1].branches[1].branches.Add(new Branch());
            //creates depth 5
            tree.Root.branches[1].branches[1].branches[0].branches.Add(new Branch());



            Console.WriteLine("Maximum depth of binary tree is: " + tree.MaxDepth(tree.Root));
            Console.ReadLine();
        }
    }
}
