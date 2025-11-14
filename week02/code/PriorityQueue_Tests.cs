using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: The original Dequeue loop stopped at _queue.Count - 1, so it never checked the last item in the queue for highest priority. Additionally, the original code did not remove the high-priority element after returning it, leaving the queue in an incorrect state.
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
    // Defect(s) Found: The priority comparison used '>=' which caused the most recently added item with the highest priority to be selected instead of the first one, breaking FIFO behavior for tied priorities.
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