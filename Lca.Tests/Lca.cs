using System.Collections.Generic;

namespace Lca.Tests
{
    public class Lca
    {
        public const int root = 1;

        public int Calculate(int n1, int n2)
        {
            if (n1 == root || n2 == root)
                return root;

            List<int> n1Tree = TreeChain(n1);
            List<int> n2Tree = TreeChain(n2);
            var result = n1Tree[0] < n2Tree[0] ? CalculateLca(n1Tree, n2Tree) : CalculateLca(n2Tree, n1Tree);
            if (result != default) return result;

            return default;
        }
        private int CalculateLca(List<int> n1, List<int> n2)
        {
            int result = default;
            foreach (var item in n1)
            {
                if (n2.Contains(item))
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        private List<int> TreeChain(int n)
        {
            bool isRoot = false;
            List<int> lst = new List<int> { n };

            while (!isRoot)
            {
                n = n / 2;
                lst.Add(n);

                if (n == root)
                    isRoot = true;
            }
            return lst;
        }
    }
}
