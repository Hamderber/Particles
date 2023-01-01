﻿using Mono.Data.Sqlite;

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
    /// <summary>
    /// Units: u
    /// </summary>
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
    public bool IsStable = false;

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
        if (HalfLife == "Stable") IsStable = true;
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
        if (HalfLife == "Stable") IsStable = true;
    }

    public List<Particle> Decay(DecayType decayType)
    {
        switch (decayType)
        {
            case DecayType.None:
                List<Particle> list = new List<Particle>();
                list.Add(this);
                return list;
            case DecayType.Alpha:
                return (AlphaDecay());
            /*case DecayType.BetaPlus:
            return (BetaPlusDecay());
        case DecayType.BetaMinus:
            return (BetaMinusDecay());
        case DecayType.Gamma:
            return (GammaDecay());
        case DecayType.NeutronEmission:
            return (NeutronEmissionDecay());
        case DecayType.ElectronCapture:
            return (ElectronCaptureDecay());
        case DecayType.Fission:
            return (FissionDecay()); */
            default:
                List<Particle> dList = new List<Particle>();
                dList.Add(this);
                return dList;
        }
    }

    public List<Particle> AlphaDecay()
    {
        List<Particle> result = new List<Particle>();
        Particle newParticle = DataBaseInteract.LoadElementData(MassNumber - 4, AtomicNumber - 2);

        //Checks if the element trying to decay is stable
        if (IsStable)
        {
            Console.WriteLine($"Stability prevents decay. Result is the same as the input.");
            result.Add(this);
        }
        //Check to see if the unstable element's requested decay is possible
        else if (MassNumber - 4 < 1 || AtomicNumber - 2 < 1 || newParticle == null)
        {
            Console.WriteLine($"Decay requested is not possible. Result is the same as the input.");
            result.Add(this);
        }
        //Do the decay if it is possible
        else
        {
            Particle alpha = DataBaseInteract.LoadElementData(4, 2);
            double energyFromMass = -Constants.amuToMev * (newParticle.AtomicMass + alpha.AtomicMass - this.AtomicMass);
            newParticle.KineticEnergy = energyFromMass * alpha.AtomicMass / newParticle.AtomicMass;
            alpha.KineticEnergy = energyFromMass - newParticle.KineticEnergy;
            result.Add(newParticle);
            result.Add(alpha);
        }
        Console.WriteLine($"{Tools.FormatDecay(this, result)}");
        return result;
    }

    public string ToStringSimple()
    {
        return $"{Tools.FormatParticle(this)}";
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

public enum DecayType
{
    None = 0,
    Alpha = 1,
    BetaPlus = 2,
    BetaMinus = 3,
    Gamma = 4,
    NeutronEmission = 5,
    ElectronCapture = 6,
    Fission = 7
}