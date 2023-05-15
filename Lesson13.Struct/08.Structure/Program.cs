MyStruct instance = new MyStruct();

instance.MyProperty = 1;
Console.WriteLine(instance.MyProperty);

// Strukturlarda auto-propery-lərdən istifadə etmək olar.
// Amma instance yaradanda konstruktoru çağırmaq lazımdır.
struct MyStruct
{
    public int MyProperty { get; set; }
} 