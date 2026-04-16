namespace ConsoleApplication1;

/// <summary>
/// Generates a reverse-ordered, comma delimited
/// list of even numbers from 100 to 0 inclusive
/// </summary>
public class ReverseEvenNumberGenerator : IOutputGenerator
{
    /// <summary>
    /// Use this method to provide a stream of values to GenerateOutput
    /// </summary>
    /// <returns>integers 0 to 100 inclusive</returns>
    private static IEnumerable<int> GetStream()
    {
        return Enumerable.Range(0, 101);
    }

    /// <summary>
    /// Make changes to this method.
    /// See <see cref="UnitTestProject1.UnitTests.TestReverseEvenNumberGenerator"/> for the unit test.
    /// </summary>
    /// <returns>reverse-ordered, comma delimited list of even numbers from 100 to 0 inclusive</returns>
    public string GenerateOutput()
    {
        // use GetStream() for the input range
        return "Not Implemented.";
    }
}
