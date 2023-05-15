// Struktur tipin konstruktor çağrılmadan instance-nın yaradılması.
MyStruct instance;

instance.field = 1; // Şərhə salmaq.

// İlkin dəyərə mənimsədilməmiş field-in ekrana çıxarılma cəhdi xətaya gətirib çıxaracaq.
Console.WriteLine(instance.field);

struct MyStruct
{
    public int field;
}