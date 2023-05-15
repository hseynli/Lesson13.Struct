MyClass.MyStruct instance = new MyClass.MyStruct();
instance.Method();

// Klasların daxilində struktur yaratmaq mümkündür.
class MyClass
{
    public struct MyStruct
    {
        public void Method()
        {
            Console.WriteLine("Hello.");
        }
    }
}