class Program
{
    public static bool RegenerateSQLiteDBsEachRun = true;
    public static bool ReOptimizeSQLiteChunkSize = false;

    static void Main(string[] args)
    {
        Console.WriteLine("\nCoursey's Personal Project:\n");
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        //SETTINGS:

        RegenerateSQLiteDBsEachRun = true;
        TimedBlock.Enabled = false;
        SQLiteData.ConsoleLogs = false;
        DataBaseInteract.ConsoleLogs = false;
        DataBaseInteract.SizeOfDataListChunks = ReOptimizeSQLiteChunkSize == true ? Tools.OptimizeSQLiteChunkSize() : 38;

        //

        SQLiteData.Initialize();

        Particle C8 = DataBaseInteract.LoadIsotopeData(8, 6);
        //Console.WriteLine($"Loaded particle with data:\n{C8}");

        C8.Decay(DecayType.Alpha);

        Particle Li7 = DataBaseInteract.LoadIsotopeData(7, 3);
        //Console.WriteLine($"Loaded particle with data:\n{Li7}");

        Li7.Decay(DecayType.Alpha);

        Particle B8 = DataBaseInteract.LoadIsotopeData(8, 5);
        //Console.WriteLine($"Loaded particle with data:\n{B8}");

        B8.Decay(DecayType.Alpha);

        Particle U238 = DataBaseInteract.LoadIsotopeData(238, 92);
        //Console.WriteLine($"Loaded particle with data:\n{U238}");

        U238.Decay(DecayType.Alpha);

        Particle C14 = DataBaseInteract.LoadIsotopeData(14, 6);
        //Console.WriteLine($"Loaded particle with data:\n{C14}");

        C14.Decay(DecayType.BetaMinus);

        Particle C11 = DataBaseInteract.LoadIsotopeData(11, 6);
        //Console.WriteLine($"Loaded particle with data:\n{C11}");

        C11.Decay(DecayType.BetaPlus);

        Console.WriteLine("\n\n\n\n");
    }
}