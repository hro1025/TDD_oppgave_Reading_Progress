using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace TDD_oppgave_Reading_Progress;

public class ReadingProgress
{
    public int BookProgress_Step1()
    {
        throw new NotImplementedException("Not implemented yet");
    }

    public int BookProgress_Step2()
    {
        return 0;
        throw new NotImplementedException("Not implemented yet");
    }

    public int BookProgress_Step3(int side)
    {
        if (side == 0)
        {
            return 0;
        }
        else
        {
            return side;
        }
    }

    public double BookProgress_Step4()
    {
        double totalPages = 360;
        double pagesRead = 180;

        double result = pagesRead / totalPages * 100;
        return result;
    }

    public double BookProgress_Step5()
    {
        double totalPages = 300;
        double pagesRead = 51;

        double result = pagesRead / totalPages * 100;
        return result;
    }
}
