MyStruct.Nested instance = new MyStruct.Nested();
instance.Method();

// Strukturların daxilində inner klas ola bilər.
struct MyStruct
{
    public class Nested
    {
        public void Method()
        {
            Console.WriteLine("Nested");
        }
    }
}