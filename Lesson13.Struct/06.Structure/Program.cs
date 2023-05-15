MyStruct instance = new MyStruct { field = 0 };

Console.WriteLine(instance.field);



struct MyStruct
{
    public int field;

    // Statik konstruktor statik üzvlərə müraciət zamanı həmişə birinci işə düşür.
    static MyStruct()
    {
        Console.WriteLine("Static Constructor");
    }

    // Əgər struktrun daxilində istifadəçi konstruktoru varsa, onda bütün field-ləri ilkin dəyərə mənimsətmək lazımdır.
    public MyStruct(int value)
    {
        Console.WriteLine("Constructor");
        this.field = value;
    }
}