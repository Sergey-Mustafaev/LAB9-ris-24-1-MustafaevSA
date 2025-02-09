using Lab9;

namespace Lab9Tests;

[TestClass]
public class DialClockArrayTests
{
    [TestMethod]
    public void TestConstructorWithoutParamsForNull()
    {
        DialClockArray clockArray = new DialClockArray();
        Assert.IsNotNull(clockArray);
    }

    [TestMethod]
    public void TestConstructorWithoutParamsForLength()
    {
        DialClockArray arrayToPass = new DialClockArray();
        int expected = 1;
        int actual = arrayToPass.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamZeroLengthForNull()
    {
        DialClockArray clockArray = new DialClockArray(0);
        Assert.IsNotNull(clockArray);
    }

    [TestMethod]
    public void TestConstructorWithOneParamSingleLengthForNull()
    {
        DialClockArray clockArray = new DialClockArray(1);
        Assert.IsNotNull(clockArray);
    }

    [TestMethod]
    public void TestConstructorWithOneParamZeroLengthForLength()
    {
        DialClockArray arrayToPass = new DialClockArray(0);
        int expected = 0;
        int actual = arrayToPass.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamSingleLengthForLength()
    {
        DialClockArray arrayToPass = new DialClockArray(1);
        int expected = 1;
        int actual = arrayToPass.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamMultipleLengthForLength()
    {
        DialClockArray arrayToPass = new DialClockArray(10);
        int expected = 10;
        int actual = arrayToPass.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamMinusOneLengthForLength()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DialClockArray(-1));
    }

    [TestMethod]
    public void TestConstructorWithOneParamNegativeLengthForLength()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new DialClockArray(-10));
    }

    [TestMethod]
    public void TestArrayIndexingForNullAlpha()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock clock = clockArray[0];
        Assert.IsNotNull(clock);
    }

    [TestMethod]
    public void TestArrayIndexingForNullBeta()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock clock = clockArray[5];
        Assert.IsNotNull(clock);
    }

    [TestMethod]
    public void TestArrayIndexingForNullGamma()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock clock = clockArray[9];
        Assert.IsNotNull(clock);
    }

    [TestMethod]
    public void TestArrayIndexingForTypeAlpha()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Type expected = typeof(DialClock);
        Type actual = clockArray[0].GetType();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayIndexingForTypeBeta()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Type expected = typeof(DialClock);
        Type actual = clockArray[5].GetType();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayIndexingForTypeGamma()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Type expected = typeof(DialClock);
        Type actual = clockArray[9].GetType();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayIndexingOutOfRangeAlpha()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Assert.ThrowsException<IndexOutOfRangeException>(() => clockArray[-5]);
    }

    [TestMethod]
    public void TestArrayIndexingOutOfRangeBeta()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Assert.ThrowsException<IndexOutOfRangeException>(() => clockArray[-1]);
    }

    [TestMethod]
    public void TestArrayIndexingOutOfRangeGamma()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Assert.ThrowsException<IndexOutOfRangeException>(() => clockArray[10]);
    }

    [TestMethod]
    public void TestArrayIndexingOutOfRangeDelta()
    {
        DialClockArray clockArray = new DialClockArray(10);
        Assert.ThrowsException<IndexOutOfRangeException>(() => clockArray[15]);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingAlpha()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock expected = new DialClock(12, 34);
        clockArray[5] = new DialClock(12, 34);
        DialClock actual = clockArray[5];
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingBeta()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock expected = new DialClock(12, 34);
        DialClock originalClock = new DialClock(12, 34);
        clockArray[5] = originalClock;
        originalClock++;
        DialClock actual = clockArray[5];
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingGamma()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock expected = new DialClock(12, 34);
        clockArray[0] = new DialClock(12, 34);
        DialClock actual = clockArray[0];
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingEpsilon()
    {
        DialClockArray clockArray = new DialClockArray(10);
        DialClock expected = new DialClock(12, 34);
        clockArray[9] = new DialClock(12, 34);
        DialClock actual = clockArray[9];
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayForDeepCopyingAlpha()
    {
        DialClockArray original = new DialClockArray(0);
        DialClockArray copy = new DialClockArray(original);
        int expected = 0;
        int actual = copy.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayForDeepCopyingBeta()
    {
        DialClockArray original = new DialClockArray(1);
        DialClockArray copy = new DialClockArray(original);
        int expected = 1;
        int actual = copy.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayForDeepCopyingGamma()
    {
        DialClockArray original = new DialClockArray(10);
        DialClockArray copy = new DialClockArray(original);
        int expected = 10;
        int actual = copy.Length;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayForDeepCopyingDelta()
    { 
        DialClockArray original = new DialClockArray(1);
        DialClockArray copy = new DialClockArray(original);
        Assert.AreEqual(original[0], copy[0]);
    }

    [TestMethod]
    public void TestArrayForDeepCopyingEpsilon()
    {
        DialClockArray original = new DialClockArray(3);
        DialClockArray copy = new DialClockArray(original);
        Assert.AreEqual(original[0], copy[0]);
        Assert.AreEqual(original[1], copy[1]);
        Assert.AreEqual(original[2], copy[2]);
    }

    [TestMethod]
    public void TestArrayForDeepCopyingZeta()
    {
        DialClockArray original = new DialClockArray(10);
        DialClockArray copy = new DialClockArray(original);
        original[5] = copy[5] + 1;
        Assert.AreNotEqual(original[5], copy[5]);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingOutOfRangeAlpha()
    {
        DialClockArray original = new DialClockArray(3);
        DialClockArray copy = new DialClockArray(original);
        copy[-2] = new DialClock();
        Assert.AreEqual(original[0], copy[0]);
        Assert.AreEqual(original[1], copy[1]);
        Assert.AreEqual(original[2], copy[2]);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingOutOfRangeBeta()
    {
        DialClockArray original = new DialClockArray(3);
        DialClockArray copy = new DialClockArray(original);
        copy[-1] = new DialClock();
        Assert.AreEqual(original[0], copy[0]);
        Assert.AreEqual(original[1], copy[1]);
        Assert.AreEqual(original[2], copy[2]);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingOutOfRangeGamma()
    {
        DialClockArray original = new DialClockArray(3);
        DialClockArray copy = new DialClockArray(original);
        copy[3] = new DialClock();
        Assert.AreEqual(original[0], copy[0]);
        Assert.AreEqual(original[1], copy[1]);
        Assert.AreEqual(original[2], copy[2]);
    }

    [TestMethod]
    public void TestArrayIndexingForRewritingOutOfRangeDelta()
    {
        DialClockArray original = new DialClockArray(3);
        DialClockArray copy = new DialClockArray(original);
        copy[5] = new DialClock();
        Assert.AreEqual(original[0], copy[0]);
        Assert.AreEqual(original[1], copy[1]);
        Assert.AreEqual(original[2], copy[2]);
    }

    [TestMethod]
    public void TestArrayEqualsWithNull()
    {
        DialClockArray arrayToPass = new DialClockArray();
        bool expected = false;
        bool actual = arrayToPass.Equals(null);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithGarbage()
    {
        DialClockArray arrayToPass = new DialClockArray();
        int garbageToPass = 0;
        bool expected = false;
        bool actual = arrayToPass.Equals(garbageToPass);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithDifferentLengthsAlpha()
    {
        DialClockArray firstClockArray = new DialClockArray(5);
        DialClockArray secondClockArray = new DialClockArray(2);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithDifferentLengthsBeta()
    {
        DialClockArray firstClockArray = new DialClockArray(5);
        DialClockArray secondClockArray = new DialClockArray(4);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithDifferentLengthsGamma()
    {
        DialClockArray firstClockArray = new DialClockArray(5);
        DialClockArray secondClockArray = new DialClockArray(6);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithDifferentLengthsDelta()
    {
        DialClockArray firstClockArray = new DialClockArray(5);
        DialClockArray secondClockArray = new DialClockArray(8);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithZeroLengths()
    {
        DialClockArray firstClockArray = new DialClockArray(0);
        DialClockArray secondClockArray = new DialClockArray(0);
        bool expected = true;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithEqualLengthsAlpha()
    {
        DialClockArray firstClockArray = new DialClockArray(2);
        DialClockArray secondClockArray = new DialClockArray(2);
        firstClockArray[0] = new DialClock(1, 1); firstClockArray[1] = new DialClock(2, 2);
        secondClockArray[0] = new DialClock(3, 3); secondClockArray[1] = new DialClock(4, 4);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithEqualLengthsBeta()
    {
        DialClockArray firstClockArray = new DialClockArray(2);
        DialClockArray secondClockArray = new DialClockArray(2);
        firstClockArray[0] = new DialClock(1, 1); firstClockArray[1] = new DialClock(2, 2);
        secondClockArray[0] = new DialClock(1, 1); secondClockArray[1] = new DialClock(4, 4);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithEqualLengthsGamma()
    {
        DialClockArray firstClockArray = new DialClockArray(2);
        DialClockArray secondClockArray = new DialClockArray(2);
        firstClockArray[0] = new DialClock(1, 1); firstClockArray[1] = new DialClock(2, 2);
        secondClockArray[0] = new DialClock(3, 3); secondClockArray[1] = new DialClock(2, 2);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithEqualLengthsDelta()
    {
        DialClockArray firstClockArray = new DialClockArray(2);
        DialClockArray secondClockArray = new DialClockArray(2);
        firstClockArray[0] = new DialClock(1, 1); firstClockArray[1] = new DialClock(2, 2);
        secondClockArray[0] = new DialClock(2, 2); secondClockArray[1] = new DialClock(1, 1);
        bool expected = false;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithEqualLengthsEpsilon()
    {
        DialClockArray firstClockArray = new DialClockArray(2);
        DialClockArray secondClockArray = new DialClockArray(2);
        firstClockArray[0] = new DialClock(1, 1); firstClockArray[1] = new DialClock(2, 2);
        secondClockArray[0] = new DialClock(1, 1); secondClockArray[1] = new DialClock(2, 2);
        bool expected = true;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestArrayEqualsWithEqualLengthsZeta()
    {
        DialClockArray firstClockArray = new DialClockArray(2);
        DialClockArray secondClockArray = new DialClockArray(2);
        firstClockArray[0] = new DialClock(2, 2); firstClockArray[1] = new DialClock(1, 1);
        secondClockArray[0] = new DialClock(2, 2); secondClockArray[1] = new DialClock(1, 1);
        bool expected = true;
        bool actual = firstClockArray.Equals(secondClockArray);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertZeroLength()
    {
        DialClockArray clockArray = new DialClockArray(0);
        string expected = "";
        string actual = clockArray.ToString();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertSingleLength()
    {
        DialClockArray clockArray = new DialClockArray(1);
        clockArray[0] = new DialClock(12, 34);
        string expected = "12:34";
        string actual = clockArray.ToString();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertMultipleLength()
    {
        DialClockArray clockArray = new DialClockArray(3);
        clockArray[0] = new DialClock(1, 23);
        clockArray[1] = new DialClock(12, 34);
        clockArray[2] = new DialClock(23, 45);
        string expected = "01:23, 12:34, 23:45";
        string actual = clockArray.ToString();
        Assert.AreEqual(expected, actual);
    }
}
