using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_DifferentPriorities()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("A", 1);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 3);
        //var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        Assert.AreEqual("B", queue.Dequeue());
        Assert.AreEqual("C", queue.Dequeue());
        Assert.AreEqual("A", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_MixedPrioritiesWithTies()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("M", 3);
        queue.Enqueue("N", 5);
        queue.Enqueue("O", 5);
        queue.Enqueue("P", 1);
        //var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        Assert.AreEqual("N", queue.Dequeue());
        Assert.AreEqual("O", queue.Dequeue());
        Assert.AreEqual("M", queue.Dequeue());
        Assert.AreEqual("P", queue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Call Dequeue on an empty queue.
    // Expected Result: InvalidOperationException thrown with proper message.
    // Defect(s) Found: None if exception is correctly implemented.
    public void TestPriorityQueue_EmptyDequeue_Throws()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Expected exception not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    // Scenario: Enqueue a single item and dequeue it.
    // Expected Result: The single item is returned, and then queue is empty.
    // Defect(s) Found: None.
    public void TestPriorityQueue_SingleItem()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Solo", 10);
        Assert.AreEqual("Solo", queue.Dequeue());

        Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
    }
}


