using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp;

public class CustomQueue<T>
{
    private List<T> Data { get; set; } = new();

    public void Push(T value)
    {
        Data.Add(value);
    }

    public T Pop()
    {
        if (Data.Count == 0)
            ThrowForEmptyQueue();

        var value = Data[0];
        Data.RemoveAt(0);
        return value;
    }

    public bool TryPop([MaybeNullWhen(false)] out T value)
    {
        if (Data.Count != 0)
        {
            value = Data[0];
            Data.RemoveAt(0);
            return true;
        }

        value = default;
        return false;
    }

    public T Peek()
    {
        if (Data.Count == 0)
            ThrowForEmptyQueue();

        return Data[0];
    }

    private static void ThrowForEmptyQueue()
        => throw new InvalidOperationException("Queue is empty");
}