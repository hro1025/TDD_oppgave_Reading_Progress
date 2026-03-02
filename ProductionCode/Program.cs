using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace TDD_oppgave_Reading_Progress;

public class ReadingProgress
{
    public double BookProgress(double pagesRead, double totalPages)
    {
        if (totalPages > 0)
        {
            double finalPrecentage = pagesRead / totalPages * 100;

            return finalPrecentage;
        }

        if (pagesRead > totalPages)
        {
            double finalPrecentage = pagesRead;

            return finalPrecentage;
        }
        if (pagesRead < 0)
        {
            double finalPrecentage = totalPages / pagesRead;

            return finalPrecentage;
        }
        else
        {
            throw new Exception("R.I.P");
        }
    }
}
