public class DataBaseInteract
{
    public static void ClearDataBase()
    {
        using (new TimedBlock("Clearing all data in database"))
        {
            using (var basicSql = new BasicSql())
            {
                if (Program.RegenerateSQLiteDBsEachRun)
                {
                    basicSql.ExecuteNonReader(@"
                        DROP TABLE IF EXISTS Elements;");
                    Console.WriteLine($"All of the database was cleared.");
                }
                else
                {
                    Console.WriteLine($"Database was not cleared.");
                }
            }
        }
    }

    /// <summary>
    /// https://www.codeproject.com/Articles/33052/Visual-Representation-of-SQL-Joins
    /// </summary>
    public static void CreateDataBase()
    {
        using (new TimedBlock("Creating tables in the database"))
        {
            using (var basicSql = new BasicSql())
            {
                basicSql.ExecuteNonReader(@"
                    CREATE TABLE IF NOT EXISTS Elements 
                    (ElementName VARCHAR(100) NOT NULL, Symbol VARCHAR(3) NOT NULL, MassNumber INTEGER NOT NULL, 
                     AtomicNumber INTEGER NOT NULL, AtomicMass NUM NOT NULL, Abundance NUM NOT NULL, 
                     MassDefect NUM NOT NULL, BindingEnergy NUM NOT NULL, HalfLife VARCHAR(100) NOT NULL);");
            }
        }
    }

    public static void UpdateElementData(List<Particle> elements)
    {
        using (new TimedBlock("Update multiple elements data in database"))
        {
            using (var basicSql = new BasicSql())
            {
                List<object[]> data = new List<object[]>();
                foreach (var element in elements)
                {
                    data.Add(new object[] { element.Name, element.Symbol, element.MassNumber, element.AtomicNumber, element.AtomicMass, element.Abundance, element.MassDefect, element.BindingEnergy, element.HalfLife });
                }
                var prams = new List<KeyValuePair<string, string>>();
                var sql = @"
                        INSERT INTO	Elements
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

                foreach (var element in elements)
                {
                    Console.WriteLine($"\n\nElement {element.Name} was added to the database with the following information:\n\n{element}");
                }
            }
        }
    }

    public static Particle LoadElementData(int massNumber, int atomicNumber)
    {
        using (new TimedBlock($"Loading element data for {massNumber - atomicNumber} neutrons and {atomicNumber} protons"))
        {
            Particle element = null;
            using (var basicSql = new BasicSql())
            {
                string sql = @"SELECT * FROM Elements WHERE MassNumber = $massNumber AND AtomicNumber = $atomicNumber";
                basicSql.ExecuteReader(
                sql,
                new List<KeyValuePair<string, string>>()
                {
                            new KeyValuePair<string, string>("$massNumber", massNumber.ToString()),
                            new KeyValuePair<string, string>("$atomicNumber", atomicNumber.ToString())
                },
                (rowData) =>
                {
                    element = new Particle(rowData);
                });
            }
            return element;
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
        Element
    }
}