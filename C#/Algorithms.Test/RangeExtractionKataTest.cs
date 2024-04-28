namespace Algorithms.Test;

[TestClass]
public class RangeExtractionKataTest
{
    [TestMethod]
    public void SimpleTests()
    {
        Assert.AreEqual("1,2", RangeExtractionKata.Extract(new[] { 1, 2 }));
        Assert.AreEqual("1-3", RangeExtractionKata.Extract(new[] { 1, 2, 3 }));

        Assert.AreEqual(
            "-6,-3-1,3-5,7-11,14,15,17-20",
            RangeExtractionKata.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
        );

        Assert.AreEqual(
            "-3--1,2,10,15,16,18-20",
            RangeExtractionKata.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 })
        );
    }
}
