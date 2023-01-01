using Mono.Data.Sqlite;

public class Particle
{
    public string Name = "Undefined";
    public string Symbol = "?";
    /// <summary>
    /// Quantity of neutrons and protons
    /// </summary>
    public int MassNumber = 0;
    /// <summary>
    /// Quantity of protons
    /// </summary>
    public int AtomicNumber = 0;
    public double AtomicMass = 0;
    /// <summary>
    /// Units: % of 100 (max 100.00000)
    /// </summary>
    public double Abundance = 0;
    /// <summary>
    /// Units: MeV
    /// </summary>
    public double MassDefect = 0;
    /// <summary>
    /// Units: MeV
    /// </summary>
    public double BindingEnergy = 0;
    /// <summary>
    /// Written in scientific notation and time. Needs a string parse to derrive
    /// "Stable" literally means infinite halflife
    /// </summary>
    public string HalfLife = "0ns";
    /// <summary>
    /// Units: MeV
    /// </summary>
    public double KineticEnergy = 0;

    public Particle() { }

    public Particle(string elementName, string symbol, int massNumber, int atomicNumber, double atomicMass, double abundance, double massDefect, double bindingEnergy, string halfLife)
    {
        Name = elementName;
        Symbol = symbol;
        MassNumber = massNumber;
        AtomicNumber = atomicNumber;
        AtomicMass = atomicMass;
        Abundance = abundance;
        MassDefect = massDefect;
        BindingEnergy = bindingEnergy;
        HalfLife = halfLife;
    }

    public Particle(SqliteDataReader rowData)
    {
        Name = rowData["ElementName"].ToString();
        Symbol = rowData["Symbol"].ToString();
        MassNumber = Convert.ToInt32(rowData["MassNumber"].ToString());
        AtomicNumber = Convert.ToInt32(rowData["AtomicNumber"].ToString());
        AtomicMass = Convert.ToDouble(rowData["AtomicMass"].ToString());
        Abundance = Convert.ToDouble(rowData["Abundance"].ToString());
        MassDefect = Convert.ToDouble(rowData["MassDefect"].ToString());
        BindingEnergy = Convert.ToDouble(rowData["BindingEnergy"].ToString());
        HalfLife = rowData["HalfLife"].ToString();
    }

    public override string ToString()
    {
        return
            $"-----------------------------------------------------------------------------------------------------\n" +
            $"Element: {Name}   ({Symbol})   ({HalfLife})\n" +
            $"Mass Number: {MassNumber} (p+n) | Atomic Number: {AtomicNumber} (p) | Atomic Mass: {AtomicMass}u\n" +
            $"Abundance: %{Abundance} | Mass Defect: {MassDefect}MeV | Binding Energy: {BindingEnergy}MeV\n" +
            $"-----------------------------------------------------------------------------------------------------";
    }
}