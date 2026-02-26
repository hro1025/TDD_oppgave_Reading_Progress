using TDD_oppgave_Reading_Progress;
using Xunit;

namespace ReadingProgressTests;

public class XUnitTests
{
    [Fact]
    public void ReadingProgressTest1()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress();

        Assert.Equal(0, result);
    }
}
