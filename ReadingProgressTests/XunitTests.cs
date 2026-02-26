using TDD_oppgave_Reading_Progress;
using Xunit;

namespace ReadingProgressTests;

public class XUnitTests
{
    [Fact]
    public void ReadingProgress_Step1()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress_Step1();

        Assert.Equal(0, result);
    }

    [Fact]
    public void ReadingProgress_Step2()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress_Step2();

        Assert.Equal(0, result);
    }
}
