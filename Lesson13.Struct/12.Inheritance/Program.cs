MyStruct instance = new MyStruct();

ValueType valueType = instance as ValueType;

Console.WriteLine("instance  = {0}", instance.GetHashCode());
Console.WriteLine("valueType = {0}", valueType.GetHashCode());

// Bütün strukturlar birbaşa olaraq ValueType abstrakt klasını inherit edir.
struct MyStruct // : ValueType
{
    public void Method()
    {
        Console.WriteLine("Method");
    }
}