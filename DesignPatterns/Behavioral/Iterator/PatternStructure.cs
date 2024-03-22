using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class News
{
    public string Title { get; set; }
}

public class Iterator<T> : IEnumerable<T>
{

    int position = 0;
    public T Current { get; private set; }
    List<T> collection = new List<T>();
    public void Add(T item)
    {
        collection.Add(item);
        Current = collection.Last();
    }

    public T Next()
    {
        Current = collection[++position];
        return Current;

    }

    public T Prev()
    {
        Current = collection[--position];
        return Current;
    }

    public T First()
    {
        position = 0;
        Current = collection[position];
        return Current;
    }



    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in collection)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class IterateInDotnet : IEnumerator<int>
{
    public int Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
