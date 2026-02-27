using System.Runtime;
using System.Text;
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

    [Fact]
    public void ReadingProgress_Step3()
    {
        var target = new ReadingProgress();

        var result = target.BookProgress_Step3(0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void ReadingProgress_Step4()
    {
        var target = new ReadingProgress();

        var value = target.BookProgress_Step4();

        Assert.Equal(50, value, precision: 2);
    }

    [Fact]
    public void ReadingProgress_Step5()
    {
        var target = new ReadingProgress();

        var value = target.BookProgress_Step5();

        Assert.Equal(17, value, precision: 2);
    }
}
