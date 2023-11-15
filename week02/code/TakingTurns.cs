/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public class TakingTurnsQueue
{
    private Queue<(string Name, int Turns)> queue = new Queue<(string Name, int Turns)>();

    public int Length => queue.Count;

    public void AddPerson(string name, int turns)
    {
        queue.Enqueue((name, turns));
    }

    public void GetNextPerson()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Error: Queue is empty.");
            return;
        }

        var person = queue.Dequeue();
        Console.WriteLine(person.Name);

        if (person.Turns > 0)
        {
            person.Turns--;
            queue.Enqueue(person);
        }
    }
}

public static class TakingTurns
{
    public static void Test()
    {
        // Test Cases

        // Test 1
        Console.WriteLine("Test 1");
        var players1 = new TakingTurnsQueue();
        players1.AddPerson("Bob", 2);
        players1.AddPerson("Tim", 5);
        players1.AddPerson("Sue", 3);
        while (players1.Length > 0)
            players1.GetNextPerson();
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        Console.WriteLine("Test 2");
        var players2 = new TakingTurnsQueue();
        players2.AddPerson("Bob", 2);
        players2.AddPerson("Tim", 5);
        players2.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++)
        {
            players2.GetNextPerson();
        }

        players2.AddPerson("George", 3);
        while (players2.Length > 0)
            players2.GetNextPerson();
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 3
        Console.WriteLine("Test 3");
        var players3 = new TakingTurnsQueue();
        players3.AddPerson("Bob", 2);
        players3.AddPerson("Tim", 0);
        players3.AddPerson("Sue", 3);
        for (int i = 0; i < 10; i++)
        {
            players3.GetNextPerson();
        }
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 4
        Console.WriteLine("Test 4");
        var players4 = new TakingTurnsQueue();
        players4.GetNextPerson();
        // Defect(s) Found: None
    }
}
