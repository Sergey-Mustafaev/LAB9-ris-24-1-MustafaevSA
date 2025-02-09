using Lab9;

namespace Lab9Tests;

[TestClass]
public class DialClockTests
{
    private const double delta = 0.0001;

    [TestMethod]
    public void TestConstructorWithoutParams()
    {
        DialClock expected = new DialClock(0);
        DialClock actual = new DialClock();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParams()
    {
        DialClock expected = new DialClock(0);
        DialClock actual = new DialClock(0, 0);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamAlpha()
    {
        DialClock expected = new DialClock(0, 40);
        DialClock actual = new DialClock(40);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamBeta()
    {
        DialClock expected  = new DialClock(1, 0);
        DialClock actual= new DialClock(60);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamGamma()
    {
        DialClock expected = new DialClock(1, 40);
        DialClock actual = new DialClock(100);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamDelta()
    {
        DialClock expected = new DialClock(12, 0);
        DialClock actual = new DialClock(720);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamEpsilon()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(1440);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamZeta()
    {
        DialClock expected = new DialClock(23, 20);
        DialClock actual = new DialClock(-40);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamEta()
    {
        DialClock expected = new DialClock(23, 0);
        DialClock actual = new DialClock(-60);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamTheta()
    {
        DialClock expected = new DialClock(22, 40);
        DialClock actual = new DialClock(-80);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamLota()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(-1440);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamKappa()
    {
        DialClock expected = new DialClock(0, 10);
        DialClock actual = new DialClock(1450);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithOneParamLambda()
    {
        DialClock expected = new DialClock(0, -10);
        DialClock actual = new DialClock(-1450);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsAlpha()
    {
        DialClock expected = new DialClock(1, 0);
        DialClock actual = new DialClock(0, 60);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsBeta()
    {
        DialClock expected = new DialClock(1, 20);
        DialClock actual = new DialClock(0, 80);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsGamma()
    {
        DialClock expected = new DialClock(12, 0);
        DialClock actual = new DialClock(0, 720);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsDelta()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(0, 1440);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsEpsilon()
    {
        DialClock expected = new DialClock(0, 10);
        DialClock actual = new DialClock(0, 1450);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsZeta()
    {
        DialClock expected = new DialClock(23, 50);
        DialClock actual = new DialClock(0, -10);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsEta()
    {
        DialClock expected = new DialClock(23, 0);
        DialClock actual = new DialClock(0, -60);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsTheta()
    {
        DialClock expected = new DialClock(22, 20);
        DialClock actual = new DialClock(0, -100);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsLota()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(0, -1440);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsKappa()
    {
        DialClock expected = new DialClock(23, 50);
        DialClock actual = new DialClock(0, -1450);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsLambda()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(23, 60);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsMu()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(-22, -120);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsNu()
    {
        DialClock expected = new DialClock(0, 20);
        DialClock actual = new DialClock(24, 20);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsXi()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(48, 0);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsOmicron()
    {
        DialClock expected = new DialClock(23, 40);
        DialClock actual = new DialClock(-24, -20);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestConstructorWithTwoParamsPi()
    {
        DialClock expected = new DialClock(0, 0);
        DialClock actual = new DialClock(-48, 0);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestObjectCounterZero()
    {
        int expected = 0;
        int record = DialClock.ObjectCount;
        int actual = DialClock.ObjectCount - record;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestObjectCounterOne()
    {
        int expected = 1;
        int record = DialClock.ObjectCount;
        DialClock tempClock = new DialClock();
        int actual = DialClock.ObjectCount - record;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestObjectCounterTwo()
    {
        int expected = 2;
        int record = DialClock.ObjectCount;
        DialClock tempClock1 = new DialClock();
        DialClock tempClock2 = new DialClock();
        int actual = DialClock.ObjectCount - record;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestObjectCounterOneParamConstructor()
    {
        int expected = 1;
        int record = DialClock.ObjectCount;
        DialClock tempClock = new DialClock(10);
        int actual = DialClock.ObjectCount - record;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestObjectCounterTwoParamConstructor()
    {
        int expected = 1;
        int record = DialClock.ObjectCount;
        DialClock tempClock = new DialClock(10, 10);
        int actual = DialClock.ObjectCount - record;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntAlpha()
    {
        DialClock clockToPass = new DialClock(0, 0);
        int expected = 0;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntBeta()
    {
        DialClock clockToPass = new DialClock(0, 20);
        int expected = 20;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntGamma()
    {
        DialClock clockToPass = new DialClock(1, 0);
        int expected = 60;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntDelta()
    {
        DialClock clockToPass = new DialClock(1, 40);
        int expected = 100;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntEpsilon()
    {
        DialClock clockToPass = new DialClock(12, 0);
        int expected = 0;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntZeta()
    {
        DialClock clockToPass = new DialClock(12, 10);
        int expected = 10;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntEta()
    {
        DialClock clockToPass = new DialClock(13, 0);
        int expected = 60;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToIntTheta()
    {
        DialClock clockToPass = new DialClock(14, 10);
        int expected = 130;
        int actual = clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestUnaryPlus()
    {
        DialClock clockToPass = new DialClock(1, 40);
        DialClock expected = new DialClock(1, 40);
        DialClock actual = +clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestUnaryNegation()
    {
        DialClock clockToPass = new DialClock(1, 40);
        DialClock expected = new DialClock(22, 20);
        DialClock actual = -clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestIncrement()
    {
        DialClock clockToPass = new DialClock(1, 40);
        DialClock expected = new DialClock(1, 41);
        DialClock actual = ++clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDecrement()
    {
        DialClock clockToPass = new DialClock(1, 40);
        DialClock expected = new DialClock(1, 39);
        DialClock actual = --clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestAdditionDialClockToInt()
    {
        DialClock clockToPass = new DialClock(1, 40);
        int numberToPass = 10;
        DialClock expected = new DialClock(1, 50);
        DialClock actual = clockToPass + numberToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestAdditionIntToDialClock()
    {
        DialClock clockToPass = new DialClock(1, 40);
        int numberToPass = 10;
        DialClock expected = new DialClock(1, 50);
        DialClock actual = numberToPass + clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestSubtractionIntFromDialClock()
    {
        DialClock clockToPass = new DialClock(1, 40);
        int numberToPass = 15;
        DialClock expected = new DialClock(1, 25);
        DialClock actual = clockToPass - numberToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestSubtractionDialClockFromInt()
    {
        DialClock clockToPass = new DialClock(1, 40);
        int numberToPass = 15;
        DialClock expected = new DialClock(22, 35);
        DialClock actual = numberToPass - clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGreaterThanAlpha()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 0);
        bool expected = true;
        bool actual = firstClockToPass > secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGreaterThanBeta()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 15);
        bool expected = false;
        bool actual = firstClockToPass > secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGreaterThanGamma()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 30);
        bool expected = false;
        bool actual = firstClockToPass > secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestLessThanAlpha()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 0);
        bool expected = false;
        bool actual = firstClockToPass < secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestLessThanBeta()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 15);
        bool expected = false;
        bool actual = firstClockToPass < secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestLessThanGamma()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 30);
        bool expected = true;
        bool actual = firstClockToPass < secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGreaterThanOrEqualAlpha()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 0);
        bool expected = true;
        bool actual = firstClockToPass >= secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGreaterThanOrEqualBeta()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 15);
        bool expected = true;
        bool actual = firstClockToPass >= secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestGreaterThanOrEqualGamma()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 30);
        bool expected = false;
        bool actual = firstClockToPass >= secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestLessThanOrEqualAlpha()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 0);
        bool expected = false;
        bool actual = firstClockToPass <= secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestLessThanOrEqualBeta()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 15);
        bool expected = true;
        bool actual = firstClockToPass <= secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestLessThanOrEqualGamma()
    {
        DialClock firstClockToPass = new DialClock(0, 15);
        DialClock secondClockToPass = new DialClock(0, 30);
        bool expected = true;
        bool actual = firstClockToPass <= secondClockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestEqualsWithNull()
    {
        DialClock clockToPass = new DialClock();
        bool expected = false;
        bool actual = clockToPass.Equals(null);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestEqualsWithGarbage()
    {
        DialClock clockToPass = new DialClock();
        int garbageToPass = 0;
        bool expected = false;
        bool actual = clockToPass.Equals(garbageToPass);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockEqualsAlpha()
    {
        DialClock firstClockToPass = new DialClock(3, 3);
        DialClock secondClockToPass = new DialClock(3, 3);
        bool expected = true;
        bool actual = firstClockToPass.Equals(secondClockToPass);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockEqualsBeta()
    {
        DialClock firstClockToPass = new DialClock(3, 3);
        DialClock secondClockToPass = new DialClock(7, 3);
        bool expected = false;
        bool actual = firstClockToPass.Equals(secondClockToPass);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockEqualsGamma()
    {
        DialClock firstClockToPass = new DialClock(3, 3);
        DialClock secondClockToPass = new DialClock(3, 7);
        bool expected = false;
        bool actual = firstClockToPass.Equals(secondClockToPass);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockEqualsDelta()
    {
        DialClock firstClockToPass = new DialClock(3, 3);
        DialClock secondClockToPass = new DialClock(7, 7);
        bool expected = false;
        bool actual = firstClockToPass.Equals(secondClockToPass);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertAlpha()
    {
        DialClock clockToPass = new DialClock(0, 0);
        string expected = "00:00";
        string actual = clockToPass.ToString();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertBeta()
    {
        DialClock clockToPass = new DialClock(5, 9);
        string expected = "05:09";
        string actual = clockToPass.ToString();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertGamma()
    {
        DialClock clockToPass = new DialClock(10, 20);
        string expected = "10:20";
        string actual = clockToPass.ToString();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestStringConvertDelta()
    {
        DialClock clockToPass = new DialClock(23, 59);
        string expected = "23:59";
        string actual = clockToPass.ToString();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestCalculateAngleAlpha()
    {
        DialClock clockToPass = new DialClock(0, 0);
        double expected = 0;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleBeta()
    {
        DialClock clockToPass = new DialClock(0, 1);
        double expected = 5.5;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleGamma()
    {
        DialClock clockToPass = new DialClock(0, 2);
        double expected = 11;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleDelta()
    {
        DialClock clockToPass = new DialClock(0, 33);
        double expected = 178.5;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleEpsilon()
    {
        DialClock clockToPass = new DialClock(1, 6);
        double expected = 3;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleZeta()
    {
        DialClock clockToPass = new DialClock(3, 0);
        double expected = 90;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleEta()
    {
        DialClock clockToPass = new DialClock(6, 0);
        double expected = 180;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleTheta()
    {
        DialClock clockToPass = new DialClock(9, 0);
        double expected = 90;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleLota()
    {
        DialClock clockToPass = new DialClock(11, 59);
        double expected = 5.5;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleKappa()
    {
        DialClock clockToPass = new DialClock(12, 0);
        double expected = 0;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleLambda()
    {
        DialClock clockToPass = new DialClock(12, 1);
        double expected = 5.5;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestCalculateAngleMu()
    {
        DialClock clockToPass = new DialClock(23, 59);
        double expected = 5.5;
        double actual = clockToPass.CalculateClockHandsAngle();
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleAlpha()
    {
        DialClock clockToPass = new DialClock(0, 0);
        double expected = 0;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleBeta()
    {
        DialClock clockToPass = new DialClock(0, 1);
        double expected = 5.5;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleGamma()
    {
        DialClock clockToPass = new DialClock(0, 2);
        double expected = 11;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleDelta()
    {
        DialClock clockToPass = new DialClock(0, 33);
        double expected = 178.5;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleEpsilon()
    {
        DialClock clockToPass = new DialClock(1, 6);
        double expected = 3;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleZeta()
    {
        DialClock clockToPass = new DialClock(3, 0);
        double expected = 90;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleEta()
    {
        DialClock clockToPass = new DialClock(6, 0);
        double expected = 180;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleTheta()
    {
        DialClock clockToPass = new DialClock(9, 0);
        double expected = 90;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleLota()
    {
        DialClock clockToPass = new DialClock(11, 59);
        double expected = 5.5;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleKappa()
    {
        DialClock clockToPass = new DialClock(12, 0);
        double expected = 0;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleLambda()
    {
        DialClock clockToPass = new DialClock(12, 1);
        double expected = 5.5;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestStaticCalculateAngleMu()
    {
        DialClock clockToPass = new DialClock(23, 59);
        double expected = 5.5;
        double actual = DialClock.CalculateClockHandsAngle(clockToPass);
        Assert.AreEqual(expected, actual, delta);
    }

    [TestMethod]
    public void TestDialClockToBoolAlpha()
    {
        DialClock clockToPass = new DialClock(0, 0);
        bool expected = true;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolBeta()
    {
        DialClock clockToPass = new DialClock(0, 1);
        bool expected = false;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolGamma()
    {
        DialClock clockToPass = new DialClock(0, 5);
        bool expected = true;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolDelta()
    {
        DialClock clockToPass = new DialClock(0, 33);
        bool expected = false;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolEpsilon()
    {
        DialClock clockToPass = new DialClock(0, 35);
        bool expected = true;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolZeta()
    {
        DialClock clockToPass = new DialClock(0, 65);
        bool expected = true;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolEta()
    {
        DialClock clockToPass = new DialClock(0, 66);
        bool expected = false;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolTheta()
    {
        DialClock clockToPass = new DialClock(3, 49);
        bool expected = false;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestDialClockToBoolLota()
    {
        DialClock clockToPass = new DialClock(6, 0);
        bool expected = true;
        bool actual = (bool)clockToPass;
        Assert.AreEqual(expected, actual);
    }
}