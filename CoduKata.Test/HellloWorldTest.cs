namespace CoduKata.Test;


[UsesVerify]
public class HellloWorldTest
{
    private TestConsoleRedirector _testConsoleRedirector = new TestConsoleRedirector();
    
    [Fact]
    public Task Test_HelloWorld_ShouldPrintHelloWorld()
    {
        Program.PrintHelloWorld();
        var printHelloWorldoutput = _testConsoleRedirector.ReadFakeOutputContent();
        return Verify(printHelloWorldoutput);
    }
}