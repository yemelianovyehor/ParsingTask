namespace JuniorParsingTask.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        var tree = TreeService.Create();
    }

    [Test]
    public void Test1()
    {
        Node node;
        var result = tree.TryGetNode("lion", node);
        Assert.That(result, Is.EqualTo(true));
    }
}