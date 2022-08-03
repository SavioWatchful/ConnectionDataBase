namespace ConnectionDataBase;

public abstract class DbConnection
{
    private string _connectionString;
    public string ConnectionString { get; set; }

    public DbConnection(TimeSpan timeout)
    {
        timeout = OpenConnectionPt(_)
    }

    private TimeSpan _timeout;
    public TimeSpan Timeout 
    {
        get
        {
            DateTime.Now - OpenConnectionPt(_timeout)
        }

    }

    public abstract void OpenConnectionPt();

    public abstract void CloseConnectionPt();

}