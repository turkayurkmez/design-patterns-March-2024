namespace Strategy
{
    public class Product
    {
        public decimal Price { get; set; }
    }
    public interface ISortStrategy
    {
        Product Product { get; set; }
        void Sort();
    }

    public class BubbleSort : ISortStrategy
    {
        public Product Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Sort()
        {

            Console.WriteLine("Bubble");
        }
    }

    public class Quick3 : ISortStrategy
    {
        public Product Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Sort()
        {
            Console.WriteLine("Quick3");
        }
    }

    public class HeapSort : ISortStrategy
    {
        public Product Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Sort()
        {
            Console.WriteLine("Heap");
        }
    }

    public class ProductCollection
    {
        public void Sort(ISortStrategy sortStrategy)
        {
            /*Bubble sort.... */
            sortStrategy.Sort();
        }
    }
}
