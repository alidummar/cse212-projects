/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public class PriorityQueue {
    private List<PriorityItem> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Enqueues a new item with an associated priority. The item is consistently added to the rear of the queue, irrespective of its priority.
    /// </summary>
    /// <param name="value">The value of the item</param>
    /// <param name="priority">The priority associated with the item</param>

    public void Enqueue(string value, int priority) {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public String Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        // Determine the index of the item with the highest priority to be removed
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++) {
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Extract and return the item with the highest priority for removal
        var value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem {
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }

    public override string ToString() {
        return $"{Value} (Pri:{Priority})";
    }
}