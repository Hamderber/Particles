
class Program
{
    public static bool RegenerateSQLiteDBsEachRun = false;
    static void Main(string[] args)
    {
        //SETTINGS:

        RegenerateSQLiteDBsEachRun = true;
        TimedBlock.Enabled = false;
        SQLiteData.ConsoleLogs = false;
        DataBaseInteract.ConsoleLogs = false;

        //
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("\nCoursey's Personal Project:\n");
        SQLiteData.Initialize();

        if (RegenerateSQLiteDBsEachRun)
        {
            DataBaseInteract.ClearDataBase();
            DataBaseInteract.CreateDataBase();
            DataBaseBuilder.Build();
        }

        Particle C8 = DataBaseInteract.LoadElementData(8, 6);
        Console.WriteLine($"Loaded particle with data:\n{C8}");
    }
}