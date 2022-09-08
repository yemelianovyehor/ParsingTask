namespace JuniorParsingTask;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestIsTrue1()
    {
        var tree = TreeService.Create();
        Node node;
        var result = tree.TryGetNode("lion", out node);
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TestIsTrue2()
    {
        var tree = TreeService.Create();
        Node node;
        var result = tree.TryGetNode("xyz", out node);
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TestIsFalse1()
    {
        var tree = TreeService.Create();
        Node node;
        var result = tree.TryGetNode("qqq", out node);
        Assert.That(result, Is.EqualTo(false));
    }
    [Test]
    public void TestIsfalse2()
    {
        var tree = TreeService.Create();
        Node node;
        var result = tree.TryGetNode("foobar", out node);
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void TestReturnsNode()
    {
        var tree = TreeService.Create();
        Node node;
        var result = tree.TryGetNode("one", out node);
        Assert.That(result, Is.EqualTo(true));
        Assert.That(node.Value, Is.EqualTo("one"));
    }
}