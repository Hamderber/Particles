/*public class Particle : ElementaryParticle, IParticle
{
    /// <summary>
    /// Total number of neutrons and protons.
    /// https://en.wikipedia.org/wiki/Mass_number
    /// </summary>
    public int MassNumber { get; set; }
    /// <summary>
    /// Number of protons, which is what a simple element is classified by.
    /// https://en.wikipedia.org/wiki/Atomic_number
    /// </summary>
    public int AtomicNumber { get; set; }
    /// <summary>
    /// https://www.angelo.edu/faculty/kboudrea/periodic/structure_numbers.htm
    /// </summary>
    public string Symbol { get; set; }
    public string Name { get; set; }
    public double KineticEnergy { get; set; }
    /// <summary>
    /// Units are in amu
    /// </summary>
    public double AtomicMass { get; set; }
    *//*    public double Abundance { get; set; }
        public double MassDefect { get; set; }
        public double BindingEnergy { get; set; }
        public string HalfLife { get; set; }*//*
    public Particle()
    {
        MassNumber = 1;
        AtomicNumber = 1;
        Symbol = "H";
        Name = "Hydrogen";
    }

    public Particle(int massNumber, int protonNumber)
    {
        MassNumber = massNumber;
        AtomicNumber = protonNumber;
        Symbol = "?";
        Name = "Unidentified";
        AtomicMass = -1;
        Tools.ClassifyParticle(this);

    }

    public Particle(int massNumber, int protonNumber, double mass)
    {
        MassNumber = massNumber;
        AtomicNumber = protonNumber;
        Symbol = "?";
        Name = "Unidentified";
        AtomicMass = mass;
        Tools.ClassifyParticle(this);
    }

    public Particle(int massNumber, int protonNumber, double mass, string chemicalSymbol, string name)
    {
        MassNumber = massNumber;
        AtomicNumber = protonNumber;
        Symbol = chemicalSymbol;
        Name = name;
        AtomicMass = mass;
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
            *//*case DecayType.BetaPlus:
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
                return (FissionDecay());*//*
            default:
                List<Particle> dList = new List<Particle>();
                dList.Add(this);
                return dList;
        }
    }

    public List<Particle> AlphaDecay()
    {
        List<Particle> result = new List<Particle>();

        Particle newParticle = new Particle(MassNumber - 4, AtomicNumber - 2);

        Particle alpha = new Particle(4, 2);
        alpha.AtomicMass = 4.0026032545;
        alpha.KineticEnergy = -Constants.amuToMev * (newParticle.AtomicMass + alpha.AtomicMass - this.AtomicMass);
        Console.WriteLine(alpha.KineticEnergy);//not what i want it to be https://www.sciencedirect.com/topics/physics-and-astronomy/alpha-decay
        result.Add(newParticle);
        result.Add(alpha);

        Console.WriteLine(Tools.FormatDecay(this, result));
        return result;
    }

    public Particle BetaPlusDecay()
    {
        Console.WriteLine();
        Particle newParticle = new Particle(MassNumber, AtomicNumber - 1);
        Console.WriteLine(newParticle);
        return newParticle;
    }

    public Particle BetaMinusDecay()
    {
        Console.WriteLine(this);
        Particle newParticle = new Particle(MassNumber, AtomicNumber + 1);
        Console.WriteLine(newParticle);
        return newParticle;
    }

    public Particle GammaDecay()
    {
        Console.WriteLine(this);
        return this;
    }

    public Particle NeutronEmissionDecay()
    {
        Console.WriteLine(this);
        Particle newParticle = new Particle(MassNumber - 1, AtomicNumber);
        Console.WriteLine(newParticle);
        return newParticle;
    }

    public Particle ElectronCaptureDecay()
    {
        Console.WriteLine(this);
        Particle newParticle = new Particle(MassNumber, AtomicNumber - 1);
        Console.WriteLine(newParticle);
        return newParticle;
    }

    public Particle FissionDecay()
    {
        Console.WriteLine(this);
        return this;
    }

    public override string ToString()
    {
        return Tools.FormatParticle(this);
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
}
*/