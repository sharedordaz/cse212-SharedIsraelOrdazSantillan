public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);


        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        //
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Task A", 3);
        priorityQueue.Enqueue("Task B", 1);
        priorityQueue.Enqueue("Task C", 2);

        Console.WriteLine(priorityQueue);

        string result1 = priorityQueue.Dequeue();
        Console.WriteLine($"Dequeued: {result1}");

        Console.WriteLine(priorityQueue);
        // Expected Result after Dequeue: Task A (Priority: 3), Task C (Priority: 2)


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Empty Queue
        // Expected Result: Error
        Console.WriteLine("Test 2");
        
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
