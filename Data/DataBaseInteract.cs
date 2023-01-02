public class DataBaseInteract
{
    public static bool ConsoleLogs = true;
    public static int SizeOfDataListChunks = 50;

    public static void DeleteDataBase()
    {
        using (new TimedBlock("Deleting the database"))
        {
            if (Program.RegenerateSQLiteDBsEachRun)
            {
                string fileLocation = System.IO.Path.Combine(SQLiteData.Path, SQLiteData.DataFileName);
                if (File.Exists(fileLocation))
                {
                    File.Delete(System.IO.Path.Combine(SQLiteData.Path, SQLiteData.DataFileName));
                    if (ConsoleLogs) Console.WriteLine($"All of the database was cleared.");
                }
            }
        }
    }

    public static void ClearDataBase()
    {
        using (var basicSql = new BasicSql())
        {
            if (Program.RegenerateSQLiteDBsEachRun)
            {
                using (new TimedBlock("Clearing all data in the database"))
                {
                    basicSql.ExecuteNonReader(@"
                        DROP TABLE IF EXISTS Isotopes;");
                    if (ConsoleLogs) Console.WriteLine($"All of the database was cleared.");
                }
            }
            else
            {
                if (ConsoleLogs) Console.WriteLine($"Database was not cleared.");
            }
        }
    }

    /// <summary>
    /// https://www.codeproject.com/Articles/33052/Visual-Representation-of-SQL-Joins
    /// </summary>
    public static void CreateDataBase()
    {
        using (new TimedBlock("Creating all tables in the database"))
        {
            using (var basicSql = new BasicSql())
            {
                basicSql.ExecuteNonReader(@"
                    CREATE TABLE IF NOT EXISTS Isotopes 
                    (ElementName VARCHAR(100) NOT NULL, Symbol VARCHAR(3) NOT NULL, MassNumber INTEGER NOT NULL, 
                     AtomicNumber INTEGER NOT NULL, AtomicMass NUM NOT NULL, Abundance NUM NOT NULL, 
                     MassDefect NUM NOT NULL, BindingEnergy NUM NOT NULL, HalfLife VARCHAR(100) NOT NULL);");
            }
        }
        DataBaseBuilder.Build();
    }

    public static void UpdateIsotopeData(List<Particle> isotopes)
    {
        if (isotopes.Count == 0) { return; }
        using (new TimedBlock($"Updating {isotopes.Count} items in the Isotope database in groups of {SizeOfDataListChunks}"))
        {
            List<List<Particle>> isotopeChunkLists = Tools.ChunkList(isotopes, SizeOfDataListChunks);
            using (var basicSql = new BasicSql(true))
            {
                basicSql.BeginTransaction();

                foreach (List<Particle> isotopeChunkList in isotopeChunkLists)
                {
                    List<object[]> data = new List<object[]>();
                    foreach (var isotope in isotopeChunkList)
                    {
                        data.Add(new object[] { isotope.Name, isotope.Symbol, isotope.MassNumber, isotope.AtomicNumber, isotope.AtomicMass, isotope.Abundance, isotope.MassDefect, isotope.BindingEnergy, isotope.HalfLife });
                    }
                    var prams = new List<KeyValuePair<string, string>>();
                    var sql = @"
                        INSERT INTO	Isotopes
                        (ElementName, Symbol, MassNumber, AtomicNumber, AtomicMass, Abundance, MassDefect, BindingEnergy, HalfLife)
                        VALUES";
                    var idx = 0;
                    foreach (var obj in data)
                    {
                        sql += idx > 0 ? "," : "";
                        sql += $"($elementName{idx},$symbol{idx},$massNumber{idx},$atomicNumber{idx},$atomicMass{idx},$abundance{idx},$massDefect{idx},$bindingEnergy{idx},$halfLife{idx})";
                        prams.Add(new KeyValuePair<string, string>($"$elementName{idx}", obj[0].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$symbol{idx}", obj[1].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$massNumber{idx}", obj[2].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$atomicNumber{idx}", obj[3].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$atomicMass{idx}", obj[4].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$abundance{idx}", obj[5].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$massDefect{idx}", obj[6].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$bindingEnergy{idx}", obj[7].ToString()));
                        prams.Add(new KeyValuePair<string, string>($"$halfLife{idx}", obj[8].ToString()));
                        idx++;
                    }
                    basicSql.ExecuteNonReader(sql, prams);
                    if (ConsoleLogs)
                    {
                        foreach (var isotope in isotopeChunkList)
                        {
                            Console.WriteLine($"\n\nIsotope {isotope.Name} was added to the database with the following information:\n\n{isotope}");
                        }
                    }
                }

                basicSql.CommitTransaction();
            }
        }
    }

    public static Particle LoadIsotopeData(int massNumber, int atomicNumber)
    {
        using (new TimedBlock($"Loading isotope data for {massNumber - atomicNumber} neutrons and {atomicNumber} protons"))
        {
            Particle isotope = null;
            using (var basicSql = new BasicSql())
            {
                string sql = @"SELECT * FROM Isotopes WHERE MassNumber = $massNumber AND AtomicNumber = $atomicNumber";
                basicSql.ExecuteReader(
                sql,
                new List<KeyValuePair<string, string>>()
                {
                            new KeyValuePair<string, string>("$massNumber", massNumber.ToString()),
                            new KeyValuePair<string, string>("$atomicNumber", atomicNumber.ToString())
                },
                (rowData) =>
                {
                    isotope = new Particle(rowData);
                });
            }
            return isotope;
        }

        /*public static T LoadDataObject<T>(DataObjectType dataType, string objectName, string objectId = null) where T : class
        {
            if (dataType == DataObjectType.Element)
            {
                Element element = null;
                using (new TimedBlock($"Loading element {objectName} data"))
                {
                    using (var basicSql = new BasicSql())
                    {
                        string sql = @"SELECT * FROM Elements WHERE MassNumber = $massNumber";
                        basicSql.ExecuteReader(
                        sql,
                        new List<KeyValuePair<string, string>>()
                        {
                                new KeyValuePair<string, string>("$objectName", objectName),
                        },
                        (rowData) =>
                        {
                            element = new Element(rowData);
                        });
                    }
                }
                return element as T;
            }
            return default;
        }*/
    }

    public enum DataObjectType
    {
        Isotope,
        Element
    }
}