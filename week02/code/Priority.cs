/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
 public class PriorityQueue<T>
{
    private readonly List<(T Data, int Priority)> _queue = new List<(T Data, int Priority)>();

    public void Enqueue(T data, int priority)
    {
        _queue.Add((data, priority));
    }

    public T Dequeue()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Error: Queue is empty.");
            return default(T);
        }

        var highestPriorityItems = _queue.Where(item => item.Priority == _queue.Max(x => x.Priority)).ToList();
        var itemToRemove = highestPriorityItems.First();
        _queue.Remove(itemToRemove);

        return itemToRemove.Data;
    }

    public void DisplayQueue()
    {
        foreach (var item in _queue)
        {
            Console.WriteLine($"Data: {item.Data}, Priority: {item.Priority}");
        }
    }
}

public static class Priority
{
    public static void Test()
    {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue<string>();
        priorityQueue.Enqueue("Item1", 3);
        priorityQueue.Enqueue("Item2", 1);
        priorityQueue.Enqueue("Item3", 2);
        priorityQueue.DisplayQueue();

        // Test Cases

        // Test 1
        Console.WriteLine("Test 1");
        var priorityQueue1 = new PriorityQueue<string>();
        priorityQueue1.Enqueue("Item1", 3);
        priorityQueue1.Enqueue("Item2", 1);
        priorityQueue1.Enqueue("Item3", 2);

        Console.WriteLine("Dequeuing items:");
        Console.WriteLine(priorityQueue1.Dequeue()); // Expected: Item1
        Console.WriteLine(priorityQueue1.Dequeue()); // Expected: Item3
        Console.WriteLine(priorityQueue1.Dequeue()); // Expected: Item2

        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue<int>();
        priorityQueue2.Dequeue(); // Expected: Error message

        Console.WriteLine("---------");

        // Test 3
        Console.WriteLine("Test 3");
        var priorityQueue3 = new PriorityQueue<string>();
        priorityQueue3.Enqueue("Item1", 3);
        priorityQueue3.Enqueue("Item2", 3);
        priorityQueue3.Enqueue("Item3", 2);
        priorityQueue3.Enqueue("Item4", 3);

        Console.WriteLine("Dequeuing items:");
        Console.WriteLine(priorityQueue3.Dequeue()); // Expected: Item1 (FIFO for same priority)
        Console.WriteLine(priorityQueue3.Dequeue()); // Expected: Item2
        Console.WriteLine(priorityQueue3.Dequeue()); // Expected: Item4 (FIFO for same priority)
        Console.WriteLine(priorityQueue3.Dequeue()); // Expected: Item3

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below...

        // Ensure to cover all requirements with your test cases.
    }
}
