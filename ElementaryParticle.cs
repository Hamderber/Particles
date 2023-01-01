public class ElementaryParticle
{


    public ElementaryParticle()
    {
        //Particle gamma = new Particle(0, 0, "γ", "Gamma");
    }
}

public static class Constants
{
    /// <summary>
    /// 931.493614838934 Mev
    /// </summary>
    public static double amuToMev = 931.493614838934;
    /// <summary>
    /// Units are in amu
    /// </summary>
    public static double protonMass = 1.00727647;
    /// <summary>
    /// Units are in amu
    /// </summary>
    public static double neutronMass = 1.00866491588;
}

public interface IParticle
{
    public string Name { get; set; }
    public string Symbol { get; set; }
    public int MassNumber { get; set; }
    public int AtomicNumber { get; set; }
    public double KineticEnergy { get; set; }
    public double AtomicMass { get; set; }
}
