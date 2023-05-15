MyStruct instance;

instance.Method();

// Strukturlar ancaq interfeysi realizasiya edə bilər.
// Strukturlar digər strukturu və ya klası inherit edə bilməz.
interface IInterface
{
    void Method();
}

struct MyStruct : IInterface
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}