using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Category : IComparable<Category>
    {
        public int CompareTo(Category? other)
        {
            return other.Name == this.Name ? 1 : -1;
        }

        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public Category()
        {
            Name = GetType().Name;
        }
        public Category(string name)
        {
            Name = name;
        }
    }

    public class Composite<T> where T : IComparable<T>, new()
    {
        //Leaf: Altına başka eleman EKLENEMEYEN obje
        //Non-Leaf: Altına başka eleman EKLENEBİLEN obje

        public T Node { get; set; } = new T();
        public List<Composite<T>> Children { get; set; } = new List<Composite<T>>();

        public Composite<T> Add(T child)
        {
            Composite<T> newComposite = new Composite<T>() { Node = child };
            Children.Add(newComposite);
            return newComposite;
        }

        public static void Show(int level, Composite<T> composite, TreeView treeView)
        {
            TreeNode treeNode = new TreeNode(composite.Node.ToString());
            addIteemToNode(composite, treeNode);
            treeView.Nodes.Add(treeNode);
        }

        private static void addIteemToNode(Composite<T> composite, TreeNode treeNode)
        {
            TreeNode childNode = treeNode.Nodes.Add(composite.Node.ToString());
            foreach (var item in composite.Children)
            {
                addIteemToNode(item, childNode);
            }
        }
    }


}
