using System.Xml.Linq;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BST
{
    public TreeNode root;
    public BST()
    {
        root = null;
    }

    public void InsertNode(TreeNode temproot, int val)
    {
        TreeNode newTreeNode = new TreeNode(val, null, null);

        TreeNode temp = null;
        if (root != null)
        {
            while (temproot != null)
            {
                temp = temproot;
                if (temproot.val == val)
                    return;
                else if (val < temproot.val)
                    temproot = temproot.left;
                else if (val > temproot.val)
                    temproot = temproot.right;
            }

            if (val < temp.val)
                temp.left = newTreeNode;
            else if (val > temp.val)
                temp.right = newTreeNode;
        }
        else
        {
            root = newTreeNode;
        }
    }

    public TreeNode Search(int val)
    {
        return SearchTree(root, val);
    }

    private TreeNode SearchTree(TreeNode node, int val)
    {
        if (node == null)

            return null;


        if (node.val == val)

            return node;

        if (node.val > val)

            return SearchTree(node.left, val);

        return SearchTree(node.right, val);
    }

}
public class Program
{
    public static void Main()
    {
        BST bst = new BST();

        bst.InsertNode(bst.root, 1);
        bst.InsertNode(bst.root, 10);
        bst.InsertNode(bst.root, 20);
        bst.InsertNode(bst.root, 30);
        bst.InsertNode(bst.root, 5);
        bst.InsertNode(bst.root, 40);


        int valToFind = 10;
        TreeNode found = bst.Search(valToFind);

        if (found != null)
        {
            Console.WriteLine("Found node with value: " + found.val);
        }
        else
        {
            Console.WriteLine("Value not found in the BST.");
        }
    }
}


