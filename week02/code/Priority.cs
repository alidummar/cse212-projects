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
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue

        // Test Cases

        // Test 1
        // Scenario: Queue with the following priority items: N (2), T (0), K (2), L (7)
        // Expected Result: L, N, K, T
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("N", 2);
        priorityQueue.Enqueue("T", 0);
        priorityQueue.Enqueue("K", 2);
        priorityQueue.Enqueue("L", 7);
        // Console.WriteLine(priorityQueue);
        while (priorityQueue.Length > 0)
        {
            string value = priorityQueue.Dequeue();
            Console.WriteLine(value);
        }
        // Defect(s) Found: 
        /*  1) Stop in FOR loop in PriorityQueue.Dequeue() should be at _queue.Count, not 
                _queue.Count - 1;
            2) The IF statement should check if the priority at the current index is greater than,
                not greater than or equal to.
            3) One the highest priority is found, that item should be removed from the queue.
         */

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Queue with the following priority items: null
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        // Defect(s) Found: 
        /* None.
         */

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}