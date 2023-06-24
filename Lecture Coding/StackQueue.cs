namespace Lecture_Coding;

public class StackNode
{
    public int Key;
    public StackNode Prev;

    public StackNode(int key, StackNode prev)
    {
        Key = key;
        Prev = prev;
    }
}

public class Stack
{
    private StackNode top;

    public int Count;

    public Stack() => top = new StackNode(0, null);

    public Stack(StackNode top)
    {
        this.top = top;
        Count++;
    }

    public int Top() => top.Key;
    public bool IsEmpty() => top == null;

    public void Push(int x)
    {
        top = new StackNode(x, top);
        Count++;
    }
    public int Pop()
    {
        int t = top.Key;
        top = top.Prev;
        Count--;
        return t;
    }
}

public class QueueNode
{
    public int Key;
    public QueueNode Next;

    public QueueNode(int key, QueueNode next)
    {
        Key = key;
        Next = next;
    }
}

public class Queue
{
    private QueueNode head;
    private QueueNode tail;

    public int Count;

    public Queue()
    {
        head = new QueueNode(0, null);
        tail = new QueueNode(0, null);
    }
    public Queue(QueueNode head, QueueNode tail)
    {
        this.head = head;
        this.tail = tail;
    }

    public int Tail() => head.Key;
    public bool IsEmpty() => head == null;

    public void Enqueue(int x)
    {
        tail.Next = new QueueNode(x, tail);
        Count++;
    }

    public int Dequeue()
    {
        int t = head.Key;
        head = head.Next;
        Count--;
        return t;
    }
}
