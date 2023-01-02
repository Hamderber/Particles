public static class Debug
{
    public static int OptimizeSQLiteChunkSize()
    {
        if (!Program.RegenerateSQLiteDBsEachRun) { return DataBaseInteract.SizeOfDataListChunks; }
        using (new TimedBlock("Determining optimal database chunk size"))
        {
            int currentChunkSize = 1;
            int optimalChunkSize = 1;
            double bestTime = 10000000;
            for (int i = 1; i < 110/*DataBaseBuilder.SizeOfTable_Isotopes*/; i++)//This WILL cause SQLite errors with numbers > about 111
            {
                currentChunkSize = i;
                DataBaseInteract.DeleteDataBase();

                var startTime = DateTime.Now;
                DataBaseInteract.SizeOfDataListChunks = currentChunkSize;
                DataBaseInteract.CreateDataBase();
                var endTime = DateTime.Now;
                var span = (endTime - startTime).TotalMilliseconds;
                if (span < bestTime)
                {
                    optimalChunkSize = currentChunkSize;
                    bestTime = span;
                    Console.Write($"{bestTime}ms -> ");
                }
            }
            Console.WriteLine($"\n{bestTime}ms was the best time, so the optimal chunk size for current hardware is {optimalChunkSize}\n");
            return optimalChunkSize;
        }
    }
}