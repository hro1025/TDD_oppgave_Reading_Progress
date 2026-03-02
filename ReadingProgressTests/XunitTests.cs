using System.Runtime;
using System.Text;
using Microsoft.VisualBasic;
using TDD_oppgave_Reading_Progress;
using Xunit;

namespace ReadingProgressTests;

public class XUnitTests
{
    [Fact]
    public void ReadingProgressHalf()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress(50, 100);

        Assert.Equal(50, result);
    }

    [Fact]
    public void ReadingProgressZero()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress(0, 100);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ReadingProgressNothing()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress(0, 0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ReadingProgressGreater()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress(10, 0);

        Assert.Equal(10, result);
    }

    [Fact]
    public void ReadingProgressMinus()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress(10, 2222);

        Assert.Equal(0.45004500450045004, result);
    }
}
