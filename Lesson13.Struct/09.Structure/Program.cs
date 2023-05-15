ZipCode zipCode = new ZipCode();

zipCode.FiveDigitCode = 12345;
zipCode.PlusFourExtension = 1234;

Console.WriteLine(zipCode.FiveDigitCode);
Console.WriteLine(zipCode.PlusFourExtension);


struct ZipCode
{
    // Fields
    int fiveDigitCode;
    int plusFourExtension;

    // Property.
    public int FiveDigitCode
    {
        get { return fiveDigitCode; }
        set { fiveDigitCode = value; }
    }

    public int PlusFourExtension
    {
        get { return plusFourExtension; }
        set { plusFourExtension = value; }
    }
}