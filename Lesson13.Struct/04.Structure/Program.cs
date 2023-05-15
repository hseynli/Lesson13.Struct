// İstifadəçi konstruktorunu çağıraraq strukturun yaradılması
MyStruct instance = new MyStruct(1);

Console.WriteLine(instance.field);

struct MyStruct
{
    public int field;

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