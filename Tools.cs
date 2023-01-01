public static class Tools
{
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
        return output;
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
        switch (particle.AtomicNumber)
        {
            case 1:
                particle.Symbol = "H";
                particle.Name = "Hydrogen";
                break;
            case 2:
                particle.Symbol = "He";
                particle.Name = "Helium";
                break;
            case 3:
                particle.Symbol = "Li";
                particle.Name = "Lithium";
                break;
            case 4:
                particle.Symbol = "Be";
                particle.Name = "Beryllium";
                break;
            case 5:
                particle.Symbol = "B";
                particle.Name = "Boron";
                break;
            case 6:
                particle.Symbol = "C";
                particle.Name = "Carbon";
                break;
            case 7:
                particle.Symbol = "N";
                particle.Name = "Nitrogen";
                break;
            case 8:
                particle.Symbol = "O";
                particle.Name = "Oxygen";
                break;
            case 9:
                particle.Symbol = "F";
                particle.Name = "Fluorine";
                break;
            case 10:
                particle.Symbol = "Ne";
                particle.Name = "Neon";
                break;
            case 11:
                particle.Symbol = "Na";
                particle.Name = "Sodium";
                break;
            case 12:
                particle.Symbol = "Mg";
                particle.Name = "Magnesium";
                break;
            case 13:
                particle.Symbol = "Al";
                particle.Name = "Aluminum";
                break;
            case 14:
                particle.Symbol = "Si";
                particle.Name = "Silicon";
                break;
            case 15:
                particle.Symbol = "P";
                particle.Name = "Phosphorus";
                break;
            case 16:
                particle.Symbol = "S";
                particle.Name = "Sulfur";
                break;
            case 17:
                particle.Symbol = "Cl";
                particle.Name = "Chlorine";
                break;
            case 18:
                particle.Symbol = "Ar";
                particle.Name = "Argon";
                break;
            case 19:
                particle.Symbol = "K";
                particle.Name = "Potassium";
                break;
            case 20:
                particle.Symbol = "Ca";
                particle.Name = "Calcium";
                break;
            case 21:
                particle.Symbol = "Sc";
                particle.Name = "Scandium";
                break;
            case 22:
                particle.Symbol = "Ti";
                particle.Name = "Titanium";
                break;
            case 23:
                particle.Symbol = "V";
                particle.Name = "Vanadium";
                break;
            case 24:
                particle.Symbol = "Cr";
                particle.Name = "Chromium";
                break;
            case 25:
                particle.Symbol = "Mn";
                particle.Name = "Manganese";
                break;
            case 26:
                particle.Symbol = "Fe";
                particle.Name = "Iron";
                break;
            case 27:
                particle.Symbol = "Co";
                particle.Name = "Cobalt";
                break;
            case 28:
                particle.Symbol = "Ni";
                particle.Name = "Nickel";
                break;
            case 29:
                particle.Symbol = "Cu";
                particle.Name = "Copper";
                break;
            case 30:
                particle.Symbol = "Zn";
                particle.Name = "Zinc";
                break;
            case 31:
                particle.Symbol = "Ga";
                particle.Name = "Gallium";
                break;
            case 32:
                particle.Symbol = "Ge";
                particle.Name = "Germanium";
                break;
            case 33:
                particle.Symbol = "As";
                particle.Name = "Arsenic";
                break;
            case 34:
                particle.Symbol = "Se";
                particle.Name = "Selenium";
                break;
            case 35:
                particle.Symbol = "Br";
                particle.Name = "Bromine";
                break;
            case 36:
                particle.Symbol = "Kr";
                particle.Name = "Krypton";
                break;
            case 37:
                particle.Symbol = "Rb";
                particle.Name = "Rubidium";
                break;
            case 38:
                particle.Symbol = "Sr";
                particle.Name = "Strontium";
                break;
            case 39:
                particle.Symbol = "Y";
                particle.Name = "Yttrium";
                break;
            case 40:
                particle.Symbol = "Zr";
                particle.Name = "Zirconium";
                break;
            case 41:
                particle.Symbol = "Nb";
                particle.Name = "Niobium";
                break;
            case 42:
                particle.Symbol = "Mo";
                particle.Name = "Molybdenum";
                break;
            case 43:
                particle.Symbol = "Tc";
                particle.Name = "Technetium";
                break;
            case 44:
                particle.Symbol = "Ru";
                particle.Name = "Ruthenium";
                break;
            case 45:
                particle.Symbol = "Rh";
                particle.Name = "Rhodium";
                break;
            case 46:
                particle.Symbol = "Pd";
                particle.Name = "Palladium";
                break;
            case 47:
                particle.Symbol = "Ag";
                particle.Name = "Silver";
                break;
            case 48:
                particle.Symbol = "Cd";
                particle.Name = "Cadmium";
                break;
            case 49:
                particle.Symbol = "In";
                particle.Name = "Indium";
                break;
            case 50:
                particle.Symbol = "Sn";
                particle.Name = "Tin";
                break;
            case 51:
                particle.Symbol = "Sb";
                particle.Name = "Antimony";
                break;
            case 52:
                particle.Symbol = "Te";
                particle.Name = "Tellurium";
                break;
            case 53:
                particle.Symbol = "I";
                particle.Name = "Iodine";
                break;
            case 54:
                particle.Symbol = "Xe";
                particle.Name = "Xenon";
                break;
            case 55:
                particle.Symbol = "Cs";
                particle.Name = "Cesium";
                break;
            case 56:
                particle.Symbol = "Ba";
                particle.Name = "Barium";
                break;
            case 57:
                particle.Symbol = "La";
                particle.Name = "Lanthanum";
                break;
            case 58:
                particle.Symbol = "Ce";
                particle.Name = "Cerium";
                break;
            case 59:
                particle.Symbol = "Pr";
                particle.Name = "Praseodymium";
                break;
            case 60:
                particle.Symbol = "Nd";
                particle.Name = "Neodymium";
                break;
            case 61:
                particle.Symbol = "Pm";
                particle.Name = "Promethium";
                break;
            case 62:
                particle.Symbol = "Sm";
                particle.Name = "Samarium";
                break;
            case 63:
                particle.Symbol = "Eu";
                particle.Name = "Europium";
                break;
            case 64:
                particle.Symbol = "Gd";
                particle.Name = "Gadolinium";
                break;
            case 65:
                particle.Symbol = "Tb";
                particle.Name = "Terbium";
                break;
            case 66:
                particle.Symbol = "Dy";
                particle.Name = "Dysprosium";
                break;
            case 67:
                particle.Symbol = "Ho";
                particle.Name = "Holmium";
                break;
            case 68:
                particle.Symbol = "Er";
                particle.Name = "Erbium";
                break;
            case 69:
                particle.Symbol = "Tm";
                particle.Name = "Thulium";
                break;
            case 70:
                particle.Symbol = "Yb";
                particle.Name = "Ytterbium";
                break;
            case 71:
                particle.Symbol = "Lu";
                particle.Name = "Lutetium";
                break;
            case 72:
                particle.Symbol = "Hf";
                particle.Name = "Hafnium";
                break;
            case 73:
                particle.Symbol = "Ta";
                particle.Name = "Tantalum";
                break;
            case 74:
                particle.Symbol = "W";
                particle.Name = "Tungsten";
                break;
            case 75:
                particle.Symbol = "Re";
                particle.Name = "Rhenium";
                break;
            case 76:
                particle.Symbol = "Os";
                particle.Name = "Osmium";
                break;
            case 77:
                particle.Symbol = "Ir";
                particle.Name = "Iridium";
                break;
            case 78:
                particle.Symbol = "Pt";
                particle.Name = "Platinum";
                break;
            case 79:
                particle.Symbol = "Au";
                particle.Name = "Gold";
                break;
            case 80:
                particle.Symbol = "Hg";
                particle.Name = "Mercury";
                break;
            case 81:
                particle.Symbol = "Tl";
                particle.Name = "Thallium";
                break;
            case 82:
                particle.Symbol = "Pb";
                particle.Name = "Lead";
                break;
            case 83:
                particle.Symbol = "Bi";
                particle.Name = "Bismuth";
                break;
            case 84:
                particle.Symbol = "Po";
                particle.Name = "Polonium";
                break;
            case 85:
                particle.Symbol = "At";
                particle.Name = "Astatine";
                break;
            case 86:
                particle.Symbol = "Rn";
                particle.Name = "Radon";
                break;
            case 87:
                particle.Symbol = "Fr";
                particle.Name = "Francium";
                break;
            case 88:
                particle.Symbol = "Ra";
                particle.Name = "Radium";
                break;
            case 89:
                particle.Symbol = "Ac";
                particle.Name = "Actinium";
                break;
            case 90:
                particle.Symbol = "Th";
                particle.Name = "Thorium";
                break;
            case 91:
                particle.Symbol = "Pa";
                particle.Name = "Protactinium";
                break;
            case 92:
                particle.Symbol = "U";
                particle.Name = "Uranium";
                break;
            case 93:
                particle.Symbol = "Np";
                particle.Name = "Neptunium";
                break;
            case 94:
                particle.Symbol = "Pu";
                particle.Name = "Plutonium";
                break;
            case 95:
                particle.Symbol = "Am";
                particle.Name = "Americium";
                break;
            case 96:
                particle.Symbol = "Cm";
                particle.Name = "Curium";
                break;
            case 97:
                particle.Symbol = "Bk";
                particle.Name = "Berkelium";
                break;
            case 98:
                particle.Symbol = "Cf";
                particle.Name = "Californium";
                break;
            case 99:
                particle.Symbol = "Es";
                particle.Name = "Einsteinium";
                break;
            case 100:
                particle.Symbol = "Fm";
                particle.Name = "Fermium";
                break;
            case 101:
                particle.Symbol = "Md";
                particle.Name = "Mendelevium";
                break;
            case 102:
                particle.Symbol = "No";
                particle.Name = "Nobelium";
                break;
            case 103:
                particle.Symbol = "Lr";
                particle.Name = "Lawrencium";
                break;
            case 104:
                particle.Symbol = "Rf";
                particle.Name = "Rutherfordium";
                break;
            case 105:
                particle.Symbol = "Db";
                particle.Name = "Dubnium";
                break;
            case 106:
                particle.Symbol = "Sg";
                particle.Name = "Seaborgium";
                break;
            case 107:
                particle.Symbol = "Bh";
                particle.Name = "Bohrium";
                break;
            case 108:
                particle.Symbol = "Hs";
                particle.Name = "Hassium";
                break;
            case 109:
                particle.Symbol = "Mt";
                particle.Name = "Meitnerium";
                break;
            case 110:
                particle.Symbol = "Ds";
                particle.Name = "Darmstadtium";
                break;
            case 111:
                particle.Symbol = "Rg";
                particle.Name = "Roentgenium";
                break;
            case 112:
                particle.Symbol = "Uub";
                particle.Name = "Ununbiium";
                break;
            default:
                break;
        }
    }
}