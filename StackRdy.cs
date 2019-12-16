using System;

public class StackRdy<T>
{
    private List<T> items = new List<T>();

    public int Count => items.Count;

    public void push(T item)
    {
        items.Add(item);
    }
    
    public T Pop()
    {
        if (Count > 0)
        {
            var item = items.LastOrDefault();
            items.Remove(item);
            return item;
        }
        else
            throw new NullReferenceException("Stack is empty :C");
    }   
    public T Peek()
    {
        if (Count > 0)
        {
            var item = items.LastOrDefault();
            items.Remove(item);
            return item;
        }
        else
            throw new NullReferenceException("Stack is empty :C");
    }
    public override string ToString()
    {
        return $"Stack with {Count} elements";
    }
}
