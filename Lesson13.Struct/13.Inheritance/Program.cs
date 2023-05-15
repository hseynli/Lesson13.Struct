Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hər-hansı klas strukturu inherit edə bilməz.");

struct MyStruct
{
    // Strukturlarda protected üzv ola bilməz.
    //protected int field;
}

class MyClass //: MyStruct
{
}