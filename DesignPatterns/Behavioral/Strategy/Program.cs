// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");
/*
 Problem:
   Bir nesnenin bir operasyonu, farklı bir algoritma ile tekrar geliştirilebilecekse; algoritmayı o operasyondan nasıl ayırırım? 
 */

ProductCollection productCollection = new ProductCollection();
productCollection.Sort(new BubbleSort());
productCollection.Sort(new HeapSort());
