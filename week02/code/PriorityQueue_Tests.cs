using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
         priorityQueue.Enqueue("A", 1);
         priorityQueue.Enqueue("B", 5);
         priorityQueue.Enqueue("C", 3);

         var result = priorityQueue.Dequeue();
         Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 10);
        priorityQueue.Enqueue("B", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.
}