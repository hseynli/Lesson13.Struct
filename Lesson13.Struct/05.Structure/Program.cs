// Statik sahələrin dəyərə mənimsədilməsi mütləq deyil.
//MyStruct.Field = 1;

MyStruct.Show();


// Strukturlar daxilində statik üzvlər saxlaya bilər
struct MyStruct
{
    public static int Field
    {
        get;
        set;
    }

    public static void Show()
    {
        Console.WriteLine(Field);
    }
}