using BracketMatchChecker;

namespace BracketMatchCheckerTests;

[TestClass]
public class Tests
{
    private readonly BracketCheck _bracketCheck;

    public Tests()
    {
        _bracketCheck = new BracketCheck();
    }

    [TestMethod]
    public void MatchingPairOnly()
    {
        Assert.IsTrue(_bracketCheck.MatchingBracketCheck("<>"));
    }

    [TestMethod]
    public void IncorrectOrder()
    {
        Assert.IsFalse(_bracketCheck.MatchingBracketCheck("><"));
    }

    [TestMethod]
    public void MissingClosingBracket()
    {
        Assert.IsFalse(_bracketCheck.MatchingBracketCheck("<<>"));
    }

    [TestMethod]
    public void NoBrackets()
    {
        Assert.IsTrue(_bracketCheck.MatchingBracketCheck(""));
    }

    [TestMethod]
    public void IgnoreNonBracketChars()
    {
        Assert.IsTrue(_bracketCheck.MatchingBracketCheck("<abc...xyz>"));
    }
}