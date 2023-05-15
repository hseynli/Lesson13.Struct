ZipCode zipCode = new ZipCode(12345, 1234);

Console.WriteLine(zipCode.FiveDigitCode);
Console.WriteLine(zipCode.PlusFourExtension);

struct ZipCode
{
    // Fields
    int fiveDigitCode;
    int plusFourExtension;

    // Ctor.
    public ZipCode(int fiveDigitCode, int plusFourExtension)
    {
        this.fiveDigitCode = fiveDigitCode;
        this.plusFourExtension = plusFourExtension;
    }

    public ZipCode(int fiveDigitCode)
        : this(fiveDigitCode, 0)
    {
    }

    // Properties.
    public int FiveDigitCode
    {
        get { return fiveDigitCode; }
    }

    public int PlusFourExtension
    {
        get { return plusFourExtension; }
    }
}