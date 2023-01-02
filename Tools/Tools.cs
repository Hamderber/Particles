
using Newtonsoft.Json;

public static class Tools
{
    private const string PARTICLE_DATA_FILE = @"Data\ParticleData.json";
    private static List<Particle> Particles = new();

    static Tools()
    {
        if (File.Exists(PARTICLE_DATA_FILE))
        {
            var particleData = File.ReadAllText(@"Data\ParticleData.json");
            Particles = JsonConvert.DeserializeObject<List<Particle>>(particleData);
        }
        else
        {
            throw new ApplicationException("Particle data file could not be found.");
        }
    }

    public static string FormatParticle(Particle particle)
    {
        if (particle.MassNumber > 0 && particle.AtomicNumber > 0)
        {
            string result = $"({particle.MassNumber}\u2215{particle.AtomicNumber} {particle.Symbol}";
            if (particle.KineticEnergy > 0)
            {
                result += $" + {particle.KineticEnergy}MeV";
            }
            result += ")";
            return result;
        }
        else
        {
            switch (particle.Name)
            {
                case ("Gamma"):
                    return $"({particle.Symbol} {particle.KineticEnergy} MeV)";
                default:
                    break;
            }
            return $"({particle.Symbol})";
        }
    }

    public static string FormatDecay(Particle initialParticle, List<Particle> newParticles)
    {
        string output = $"\nDecay:  {initialParticle.ToStringSimple()} -> ";
        for (int i = 0; i < newParticles.Count; i++)
        {
            output += $"{newParticles[i].ToStringSimple()}";
            if (i != newParticles.Count - 1)
            {
                output += " + ";
            }
        }
        return output + "\n";
    }

    public static string ToSuperscript(this int number)
    //https://stackoverflow.com/questions/17704169/how-to-write-superscript-in-a-string-and-display-using-messagebox-show
    {
        const string SuperscriptDigits = "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";
        string Superscript = "";
        Superscript += new string(number.ToString().Select(x => SuperscriptDigits[x - '0']).ToArray());
        return Superscript;
    }

    public static string ToSubscript(this int number)
    {
        const string SubscriptDigits = "\u2080\u2081\u2082\u2083\u2084\u2085\u2086\u2087\u2088\u2089";
        string Subscript = "";
        Subscript += new string(number.ToString().Select(x => SubscriptDigits[x - '0']).ToArray());
        return Subscript;
    }

    /// <summary>
    /// Assigns the appropriate symbol and name to an element based off of the atomic number
    /// </summary>
    /// <param name="particle"></param>
    public static void ClassifyParticle(Particle particle)
    {
        var foundParticle = Particles.FirstOrDefault(_ => _.AtomicNumber == particle.AtomicNumber);
        if (foundParticle != null)
        {
            particle.Symbol = foundParticle.Symbol;
            particle.Name = foundParticle.Name;
        }
    }

    /// <summary>
    /// Splits a list of type T into a list of smaller lists of given size
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    /// https://stackoverflow.com/questions/11463734/split-a-list-into-smaller-lists-of-n-size
    public static List<List<T>> ChunkList<T>(List<T> list, int size) where T : class
    {
        if (size <= 0) return new List<List<T>>() { list };
        return list.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / size)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
    }

    public static int OptimizeSQLiteChunkSize()
    {
        Console.WriteLine("Optimization is enabled. This will take some time.\n");
        using (new TimedBlock("Optimizing SQLite chunk size"))
        {
            int result = (
                Debug.OptimizeSQLiteChunkSize() +
                Debug.OptimizeSQLiteChunkSize() +
                Debug.OptimizeSQLiteChunkSize() +
                Debug.OptimizeSQLiteChunkSize() +
                Debug.OptimizeSQLiteChunkSize()) / 5;
            Console.WriteLine($"\nAverage optimal chunk size for current hardware is {result}");
            return result;
        }
    }
}