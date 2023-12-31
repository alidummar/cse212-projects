﻿/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class TakingTurns {
    public static void Test() {
         // TODO Problem 1 - Execute test cases and align code with specified requirements
        // Test Cases:
         // Test 1
         // Description: Initialize a queue with individuals and assigned turns: Bob (2), Tim (5), Sue (3),
        //              and iterate until the queue is exhausted.
        // Expected Outcome: Sequence of individuals: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim

        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players); // Uncomment this line for debugging assistance

        while (players.Length > 0)
            players.GetNextPerson();
       // Defect(s) Found:
        /* 
         * PersonQueue.Enqueue() erroneously used the List.Insert() method to add a person to the 
        * front of the list. Debugged by replacing this with the List.Add() method.
        */


        Console.WriteLine("---------");
        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
     // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George        
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found: 
        /*  With the Enqueue() method debugged for Test 1, Test 2 runs without error.
         */

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        //           Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 
        /*  The logic in the TakingTurnsQueue.GetNextPerson() method provided consideration for the
         *  Forever condition. Debugged by adding an else-if statement for when Person.Turns < 1.
         */

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: An error message should be displayed

        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
       // Defect(s) Found:
        /*  
         * No defect found as the error message "No one in the queue" is displayed as expected.
        */

    }
}
