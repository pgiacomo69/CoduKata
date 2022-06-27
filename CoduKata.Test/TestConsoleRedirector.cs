using System.Text;

namespace CoduKata.Test;

public class TestConsoleRedirector
{
    private StringBuilder FakeOutput;
    
    public TestConsoleRedirector()
    {
        FakeOutput = new StringBuilder();
        System.Console.SetOut(new StringWriter(FakeOutput));
        System.Console.SetIn(new StringReader("a\n"));
    }

    public String ReadFakeOutputContent()
    {
        var output = FakeOutput.ToString();
        FakeOutput.Clear();
        return output;
    }


}