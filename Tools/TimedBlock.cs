public class TimedBlock : IDisposable
{
    public static bool Enabled = true;
    private bool _disposedValue;
    private string _blockName;
    private DateTime _start;

    public TimedBlock(string blockName)
    {
        _blockName = blockName;
        _start = DateTime.Now;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        var stop = DateTime.Now;
        var span = stop - _start;
        if (Enabled) Console.WriteLine($"{_blockName} took {span.TotalMilliseconds} ms");
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}