MyStruct instance = new MyStruct();

Console.WriteLine(instance.field);


struct MyStruct
{
    public int field;

    // Default konstruktor yaradılmadan da default konstruktor çağıran instance yaratmaq mümkündür.
    //public MyStruct()
    //{
    //}

    // Əgər istifadəçi konstruktoru varsa, onda mütləq bütün field-ləri hər-hansı dəyərə mənimsətmək lazımdır.
    public MyStruct(int value)
    {
        Console.WriteLine("Constructor");
        this.field = value;
    }
}