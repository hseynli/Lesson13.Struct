// Konstruktor çağırmadan instance-ın yaradılması.
MyStruct instance;


// İnisalizasiya olunmamış dəyişəndən istifadə etmək mümkün deyil.
// Çünki konstruktor çağırılmayıb və field dəyişəni heç bir dəyərə mənimsədilməyib.

//Console.WriteLine(instance.field);   // Şərhdən çıxarmaq.

struct MyStruct
{
    public int field;

    // Parametrli istifadəçi konstruktoru.
    public MyStruct(int value)
    {
        this.field = value;

        Console.WriteLine(value);
    }
}