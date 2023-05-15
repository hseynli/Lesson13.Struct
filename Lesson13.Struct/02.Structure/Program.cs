// Struktur tipinin birbaşa olaraq konstruktor ilə çağırılması.

//Əgər strukturun daxilində field-ə müraciət edən üzvlər varsa,
//onda instance yaradan zaman default konstruktoru çağırmaq lazımdır (əks halda xəta baş verəcək).

MyStruct instance = new MyStruct(); //Şərhə salmaq

//instance.field = 1; //Şərhdən çıxarmaq (bütün field-lərə dəyər mənimsətmək lazımdır)
instance.Field = 1;

Console.WriteLine(instance.Field);
 
struct MyStruct
{
    private int field;

    public int Field
    {
        get { return field; }
        set { field = value; }
    }

    public void Show()
    {
        Console.WriteLine(field);
    }
}