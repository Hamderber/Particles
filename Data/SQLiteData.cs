using Mono.Data.Sqlite;

public class SQLiteData
{
    public static bool ConsoleLogs = true;
    public static string DataFileName = "data.db";
    public static string DataDirectory = "CourseyPersonalProjects";
    public static string DataSubDirectory = "Particles";
    public static string Path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DataDirectory);

    public static void Initialize()
    {

        if (Directory.Exists(System.IO.Path.Combine(Path, DataSubDirectory)))
        {
            Path = System.IO.Path.Combine(Path, DataSubDirectory);
            if (ConsoleLogs) Console.WriteLine($"Subdirectory \"{DataSubDirectory}\" already exists with path \"{Path}\"");
            if (Program.RegenerateSQLiteDBsEachRun)
            {
                DataBaseInteract.DeleteDataBase();
                DataBaseInteract.CreateDataBase();
            }
        }
        else
        {
            Directory.CreateDirectory(System.IO.Path.Combine(Path, DataSubDirectory));
            Path = System.IO.Path.Combine(Path, DataSubDirectory);
            if (ConsoleLogs) Console.WriteLine($"Subdirectory \"{DataSubDirectory}\" didn't exist. Creating subdirectory \"{DataSubDirectory}\" with path \"{Path}\"");
        }
        if (ConsoleLogs) Console.WriteLine($"Reading from \"{Path}\"");
    }
}

public class BasicSql : IDisposable
{
    private string DataFilePath => System.IO.Path.Combine(SQLiteData.Path, SQLiteData.DataFileName);
    private static SqliteConnection _connection;
    private bool _disposedValue;
    private static string DataPath = SQLiteData.Path;
    public bool UseTransaction;
    private SqliteTransaction _transaction;

    static BasicSql() { }
    public BasicSql(bool useTransaction = false)
    {
        UseTransaction = useTransaction;
        if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
        {
            OpenConnection();
        }
    }

    public void BeginTransaction()
    {
        if (!UseTransaction)
        {
            throw new ApplicationException("Cannot start a transaction when BasicSql was told not to use transactions.");
        }

        _transaction = _connection.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _transaction.Commit();
        _transaction = null;
    }

    public void RollbackTransaction()
    {
        _transaction.Rollback();
        _transaction = null;
    }

    public void ExecuteNonReader(string sql)
    {
        OpenConnection();
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    public void ExecuteNonReader(string sql, IEnumerable<KeyValuePair<string, string>> parameters)
    {
        OpenConnection();
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                foreach (var pram in parameters)
                {
                    command.Parameters.AddWithValue(pram.Key, pram.Value);
                }
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    public void ExecuteReader(string sql, Action<SqliteDataReader> rowAction)
    {
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rowAction?.Invoke(reader);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    public void ExecuteReader(string sql, IEnumerable<KeyValuePair<string, string>> parameters, Action<SqliteDataReader> rowAction)
    {
        OpenConnection();
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                foreach (var pram in parameters)
                {
                    command.Parameters.AddWithValue(pram.Key, pram.Value);
                }
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rowAction?.Invoke(reader);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    public N ExecuteScalar<N>(string sql)
    {
        N result = default;
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = (N)reader[0];
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return result;
    }

    public N ExecuteScalar<N>(string sql, IEnumerable<KeyValuePair<string, string>> parameters)
    {
        N result = default;
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                foreach (var pram in parameters)
                {
                    command.Parameters.AddWithValue(pram.Key, pram.Value);
                }
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = (N)reader[0];
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return result;
    }

    public string ExecuteScalar(string sql, IEnumerable<KeyValuePair<string, string>> parameters)
    {
        OpenConnection();
        var result = "";
        try
        {
            using (var command = _connection.CreateCommand())
            {
                if (UseTransaction)
                {
                    command.Transaction = _transaction;
                }

                command.CommandText = sql;
                foreach (var pram in parameters)
                {
                    command.Parameters.AddWithValue(pram.Key, pram.Value);
                }
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader[0]?.ToString();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        return result;
    }

    private void OpenConnection()
    {
        if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
        {
            try
            {
                _connection = new SqliteConnection($"URI=file:{DataFilePath}");//URI=file:
                _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    public void RunScript(string script)
    {
        using (var cmd = _connection.CreateCommand())
        {
            cmd.CommandText = script;
            cmd.ExecuteNonQuery();
        }
    }
    public static void DebugRowData(SqliteDataReader rowData, bool debugThatClass)
    {
        if (debugThatClass)
        {
            var fieldCount = rowData.FieldCount;
            string debug = "";
            for (var currentFieldIdx = 0; currentFieldIdx < fieldCount; currentFieldIdx++)
            {
                debug += $"{rowData.GetFieldType(currentFieldIdx)} - {rowData.GetName(currentFieldIdx)} - {rowData[currentFieldIdx].ToString()}\n";
            }
            Console.WriteLine(debug);
        }
    }

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close();
                }
            }
            _disposedValue = true;
        }
    }
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
    #endregion
}