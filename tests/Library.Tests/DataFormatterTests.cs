using NUnit.Framework;


namespace TestDateFormat.Test;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    

    [Test]
    public void TestValid()
    {
        string testDate1 = "10/11/1997";
        string result = DateFormatter.ChangeFormat(testDate1);

        Assert.AreEqual("1997-11-10", result);
        
    }
    [Test]
    public void TestInvalid()
    {
        string testDate2 = "2023-10-10";
        string result = DateFormatter.ChangeFormat(testDate2);

        Assert.AreEqual("", result);
    }
    [Test]
    public void TestInvalid2()
    {
        string testDate3 = "";
        string result = DateFormatter.ChangeFormat(testDate3);

        Assert.AreEqual("", result);
    }
}