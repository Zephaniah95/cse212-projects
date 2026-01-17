using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities
    // Expected Result: Item with the highest priority is dequeued first
    // Defect(s) Found:
    // - Dequeue did not always return the highest priority item.
    // - Highest priority at the last index was sometimes ignored.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority
    // Expected Result: Items with equal priority are dequeued using FIFO order
    // Defect(s) Found:
    // - FIFO order was not preserved for items with the same priority.
    // - Removed item was not deleted from the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 4);
        priorityQueue.Enqueue("B", 4);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found:
    // - Exception handling needed verification for empty queue condition.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
