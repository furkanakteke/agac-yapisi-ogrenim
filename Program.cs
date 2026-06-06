using System;

namespace AgacYapisiOgrenim
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            // DÜZELTME: insert metodundan dönen değeri mutlaka tree.root'a atamalıyız.
            tree.root = tree.insert(tree.root, 15);
            tree.root = tree.insert(tree.root, 10);
            tree.root = tree.insert(tree.root, 20);
            tree.root = tree.insert(tree.root, 5);
            tree.root = tree.insert(tree.root, 12);

            Console.WriteLine("--- Ağacın Küçükten Büyüğe Sıralı Hali (InOrder) ---");
            tree.inOrder(tree.root);

            Console.WriteLine("\nToplam Düğüm Sayısı: " + tree.countNodes(tree.root));
            Console.WriteLine("Ağacın Yüksekliği: " + tree.getHeight(tree.root));
            Console.WriteLine("Yaprak Sayısı: " + tree.yaprak(tree.root));

            Console.ReadLine(); // Ekranın hemen kapanmasını engeller
        }
    }

    public class Node
    {
        public int data;
        public Node right;
        public Node left;
        public Node(int data)
        {
            this.data = data;
            this.right = null;
            this.left = null;
        }
    }

    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }

        // DÜZELTME: Bu metot artık ana sınıfın 'root' değişkenini ezmeyecek, 
        // sadece yeni bir düğüm üretip geri döndürecek.
        public Node newNode(int data)
        {
            return new Node(data);
        }

        public Node insert(Node root, int data)
        {
            // DÜZELTME: Gereksiz yere döngü başında 'Node eleman = new Node(data);' 
            // oluşturup belleği yormuyoruz. Sadece ihtiyaç anında (null ise) oluşturuyoruz.

            if (root != null)
            {
                if (data < root.data)
                {
                    root.left = insert(root.left, data);
                }
                else
                {
                    root.right = insert(root.right, data);
                }
            }
            else
            {
                root = newNode(data);
                return root;
            }

            return root;
        }

        public int countNodes(Node root)
        {
            if (root == null) { return 0; }
            return 1 + countNodes(root.left) + countNodes(root.right);
        }

        public int getHeight(Node root)
        {
            if (root == null) { return 0; }

            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public void preOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                preOrder(root.left);
                preOrder(root.right);
            }
        }

        public void inOrder(Node root)
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.WriteLine(root.data);
                inOrder(root.right);
            }
        }

        public void postOrder(Node root)
        {
            if (root != null)
            {
                postOrder(root.left);
                postOrder(root.right);
                Console.WriteLine(root.data);
            }
        }

        public int yaprak(Node root)
        {
            if (root == null) { return 0; }

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            return yaprak(root.left) + yaprak(root.right);
        }

        public Node minValueNode(Node node)
        {
            Node current = node;
            while (current != null && current.left != null)
            {
                current = current.left;
            }
            return current;
        }

        public Node deleteNode(Node root, int key)
        {
            if (root == null) { return root; }

            if (key < root.data)
            {
                root.left = deleteNode(root.left, key);
            }
            else if (key > root.data)
            {
                root.right = deleteNode(root.right, key);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    return null;
                }
                else if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }
                else
                {
                    Node temp = minValueNode(root.right);
                    root.data = temp.data;
                    root.right = deleteNode(root.right, temp.data);
                }
            }
            return root;
        }
    }
}
