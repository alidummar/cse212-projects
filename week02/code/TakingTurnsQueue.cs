/// <summary>
/// This queue is circular. When people are added via add_person, then they are added to the
/// back of the queue (per FIFO rules). When get_next_person is called, the next person
/// in the queue is displayed and then they are placed back into the back of the queue. Thus,
/// each person stays in the queue and is given turns. When a person is added to the queue,
/// a turns parameter is provided to identify how many turns they will be given. If the turns is 0 or
/// less than they will stay in the queue forever. If a person is out of turns then they will
/// not be added back into the queue.
/// </summary>
namespace TakingTurns
{
    public static class TakingTurns
    {
        public static void Test()
        {
            // Test Cases

            // Test 1
            // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
            //           run until the queue is empty
            // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
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
            // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
            //           After running 5 times, add George with 3 turns.  Run until the queue is empty.
            // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
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
            // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
            //           Run 10 times.
            // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
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
            // Scenario: Try to get the next person from an empty queue
            // Expected Result: Error message should be displayed
            Console.WriteLine("Test 4");
            var players4 = new TakingTurnsQueue();
            players4.GetNextPerson();
            // Defect(s) Found: None
        }
    }
}
