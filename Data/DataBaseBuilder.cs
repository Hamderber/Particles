public class DataBaseBuilder
{
    public static void Build()
    {
        List<Particle> elementsToAdd = new List<Particle>();

        #region Hydrogen ------------------------------------------------------ Hydrogen
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-1
            symbol: "H",
            massNumber: 1,//p+n
            atomicNumber: 1,
            atomicMass: 1.00782503207,//atomic weight
            abundance: 99.985,
            massDefect: 7.2889705,//mass excess
            bindingEnergy: 0.0,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-2
            symbol: "H",
            massNumber: 2,//p+n
            atomicNumber: 1,
            atomicMass: 2.01410177785,//atomic weight
            abundance: 0.015,
            massDefect: 13.13572158,//mass excess
            bindingEnergy: 1.112283,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-3
            symbol: "H",
            massNumber: 3,//p+n
            atomicNumber: 1,
            atomicMass: 3.01604927767,//atomic weight
            abundance: 0.0,
            massDefect: 14.949806,//mass excess
            bindingEnergy: 2.827266,
            halfLife: "12.32y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-4
            symbol: "H",
            massNumber: 4,//p+n
            atomicNumber: 1,
            atomicMass: 4.027806424,//atomic weight
            abundance: 0.0,
            massDefect: 25.901518,//mass excess
            bindingEnergy: 1.400351,
            halfLife: "9.917391304348e-14ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-5
            symbol: "H",
            massNumber: 5,//p+n
            atomicNumber: 1,
            atomicMass: 5.035311488,//atomic weight
            abundance: 0.0,
            massDefect: 32.89244,//mass excess
            bindingEnergy: 1.33636,
            halfLife: "8.00350877193e-14ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-6
            symbol: "H",
            massNumber: 6,//p+n
            atomicNumber: 1,
            atomicMass: 6.044942594,//atomic weight
            abundance: 0.0,
            massDefect: 41.863757,//mass excess
            bindingEnergy: 0.963633,
            halfLife: "2.9e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hydrogen",//H-7
            symbol: "H",
            massNumber: 7,//p+n
            atomicNumber: 1,
            atomicMass: 7.052749,//atomic weight
            abundance: 0.0,
            massDefect: 49.135,//mass excess
            bindingEnergy: 0.9401,
            halfLife: "2.3e-14ns"
        ));
        #endregion

        #region Helium ------------------------------------------------------ Helium
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-3
            symbol: "He",
            massNumber: 3,//p+n
            atomicNumber: 2,
            atomicMass: 3.01602931914,//atomic weight
            abundance: 0.000137,
            massDefect: 14.93121475,//mass excess
            bindingEnergy: 2.572681,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-4
            symbol: "He",
            massNumber: 4,//p+n
            atomicNumber: 2,
            atomicMass: 4.00260325415,//atomic weight
            abundance: 99.999863,
            massDefect: 2.42491565,//mass excess
            bindingEnergy: 7.073915,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-5
            symbol: "He",
            massNumber: 5,//p+n
            atomicNumber: 2,
            atomicMass: 5.012223624,//atomic weight
            abundance: 0.0,
            massDefect: 11.386233,//mass excess
            bindingEnergy: 5.481132,
            halfLife: "7.603333333333e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-6
            symbol: "He",
            massNumber: 6,//p+n
            atomicNumber: 2,
            atomicMass: 6.018889124,//atomic weight
            abundance: 0.0,
            massDefect: 17.595106,//mass excess
            bindingEnergy: 4.878017,
            halfLife: "806.7ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-7
            symbol: "He",
            massNumber: 7,//p+n
            atomicNumber: 2,
            atomicMass: 7.028020618,//atomic weight
            abundance: 0.0,
            massDefect: 26.101038,//mass excess
            bindingEnergy: 4.11907,
            halfLife: "3.041333333333e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-8
            symbol: "He",
            massNumber: 8,//p+n
            atomicNumber: 2,
            atomicMass: 8.033921897,//atomic weight
            abundance: 0.0,
            massDefect: 31.598044,//mass excess
            bindingEnergy: 3.925975,
            halfLife: "119ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-9
            symbol: "He",
            massNumber: 9,//p+n
            atomicNumber: 2,
            atomicMass: 9.043950286,//atomic weight
            abundance: 0.0,
            massDefect: 40.939429,//mass excess
            bindingEnergy: 3.348637,
            halfLife: "7e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Helium",//He-10
            symbol: "He",
            massNumber: 10,//p+n
            atomicNumber: 2,
            atomicMass: 10.052398837,//atomic weight
            abundance: 0.0,
            massDefect: 48.809203,//mass excess
            bindingEnergy: 3.033927,
            halfLife: "1.520666666667e-12ns"
        ));
        #endregion

        #region Lithium ------------------------------------------------------ Lithium
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-4
            symbol: "Li",
            massNumber: 4,//p+n
            atomicNumber: 3,
            atomicMass: 4.027185558,//atomic weight
            abundance: 0.0,
            massDefect: 25.323185,//mass excess
            bindingEnergy: 1.153761,
            halfLife: "7.565505804312e-14ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-5
            symbol: "Li",
            massNumber: 5,//p+n
            atomicNumber: 3,
            atomicMass: 5.0125378,//atomic weight
            abundance: 0.0,
            massDefect: 11.678886,//mass excess
            bindingEnergy: 5.266132,
            halfLife: "3.041333333333e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-6
            symbol: "Li",
            massNumber: 6,//p+n
            atomicNumber: 3,
            atomicMass: 6.015122794,//atomic weight
            abundance: 7.59,
            massDefect: 14.086793,//mass excess
            bindingEnergy: 5.332345,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-7
            symbol: "Li",
            massNumber: 7,//p+n
            atomicNumber: 3,
            atomicMass: 7.016004548,//atomic weight
            abundance: 92.41,
            massDefect: 14.908141,//mass excess
            bindingEnergy: 5.606291,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-8
            symbol: "Li",
            massNumber: 8,//p+n
            atomicNumber: 3,
            atomicMass: 8.022487362,//atomic weight
            abundance: 0.0,
            massDefect: 20.946844,//mass excess
            bindingEnergy: 5.159582,
            halfLife: "839.9ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-9
            symbol: "Li",
            massNumber: 9,//p+n
            atomicNumber: 3,
            atomicMass: 9.026789505,//atomic weight
            abundance: 0.0,
            massDefect: 24.954264,//mass excess
            bindingEnergy: 5.037839,
            halfLife: "178.3ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-10
            symbol: "Li",
            massNumber: 10,//p+n
            atomicNumber: 3,
            atomicMass: 10.035481259,//atomic weight
            abundance: 0.0,
            massDefect: 33.050581,//mass excess
            bindingEnergy: 4.531555,
            halfLife: "2e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-11
            symbol: "Li",
            massNumber: 11,//p+n
            atomicNumber: 3,
            atomicMass: 11.043797715,//atomic weight
            abundance: 0.0,
            massDefect: 40.79731,//mass excess
            bindingEnergy: 4.149104,
            halfLife: "8.59ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Lithium",//Li-12
            symbol: "Li",
            massNumber: 12,//p+n
            atomicNumber: 3,
            atomicMass: 12.05378,//atomic weight
            abundance: 0.0,
            massDefect: 50.096,//mass excess
            bindingEnergy: 3.701,
            halfLife: "10ns"
        ));
        #endregion

        #region Beryllium ------------------------------------------------------ Beryllium
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-6
            symbol: "Be",
            massNumber: 6,//p+n
            atomicNumber: 4,
            atomicMass: 6.019726317,//atomic weight
            abundance: 0.0,
            massDefect: 18.374947,//mass excess
            bindingEnergy: 4.487262,
            halfLife: "5e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-7
            symbol: "Be",
            massNumber: 7,//p+n
            atomicNumber: 4,
            atomicMass: 7.016929828,//atomic weight
            abundance: 0.0,
            massDefect: 15.770034,//mass excess
            bindingEnergy: 5.3714,
            halfLife: "53.21759259259d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-8
            symbol: "Be",
            massNumber: 8,//p+n
            atomicNumber: 4,
            atomicMass: 8.005305103,//atomic weight
            abundance: 0.0,
            massDefect: 4.941672,//mass excess
            bindingEnergy: 7.062435,
            halfLife: "8.190305206463e-8ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-9
            symbol: "Be",
            massNumber: 9,//p+n
            atomicNumber: 4,
            atomicMass: 9.012182201,//atomic weight
            abundance: 100.0,
            massDefect: 11.347648,//mass excess
            bindingEnergy: 6.462758,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-10
            symbol: "Be",
            massNumber: 10,//p+n
            atomicNumber: 4,
            atomicMass: 10.013533818,//atomic weight
            abundance: 0.0,
            massDefect: 12.60667,//mass excess
            bindingEnergy: 6.497711,
            halfLife: "1.512557077626e6y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-11
            symbol: "Be",
            massNumber: 11,//p+n
            atomicNumber: 4,
            atomicMass: 11.021657749,//atomic weight
            abundance: 0.0,
            massDefect: 20.174064,//mass excess
            bindingEnergy: 5.952822,
            halfLife: "13.81s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-12
            symbol: "Be",
            massNumber: 12,//p+n
            atomicNumber: 4,
            atomicMass: 12.026920737,//atomic weight
            abundance: 0.0,
            massDefect: 25.076506,//mass excess
            bindingEnergy: 5.720826,
            halfLife: "21.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-13
            symbol: "Be",
            massNumber: 13,//p+n
            atomicNumber: 4,
            atomicMass: 13.035693007,//atomic weight
            abundance: 0.0,
            massDefect: 33.247823,//mass excess
            bindingEnergy: 5.27307,
            halfLife: "2.7e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-14
            symbol: "Be",
            massNumber: 14,//p+n
            atomicNumber: 4,
            atomicMass: 14.04289292,//atomic weight
            abundance: 0.0,
            massDefect: 39.954498,//mass excess
            bindingEnergy: 4.993897,
            halfLife: "4.35ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-15
            symbol: "Be",
            massNumber: 15,//p+n
            atomicNumber: 4,
            atomicMass: 15.05346,//atomic weight
            abundance: 0.0,
            massDefect: 49.798,//mass excess
            bindingEnergy: 4.543,
            halfLife: "200ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Beryllium",//Be-16
            symbol: "Be",
            massNumber: 16,//p+n
            atomicNumber: 4,
            atomicMass: 16.06192,//atomic weight
            abundance: 0.0,
            massDefect: 57.678,//mass excess
            bindingEnergy: 4.271,
            halfLife: "200ns"
        ));
        #endregion

        #region Boron ------------------------------------------------------ Boron
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-7
            symbol: "B",
            massNumber: 7,//p+n
            atomicNumber: 5,
            atomicMass: 7.029917901,//atomic weight
            abundance: 0.0,
            massDefect: 27.868346,//mass excess
            bindingEnergy: 3.531306,
            halfLife: "3.258571428571e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-8
            symbol: "B",
            massNumber: 8,//p+n
            atomicNumber: 5,
            atomicMass: 8.024607233,//atomic weight
            abundance: 0.0,
            massDefect: 22.92149,//mass excess
            bindingEnergy: 4.717164,
            halfLife: "770ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-9
            symbol: "B",
            massNumber: 9,//p+n
            atomicNumber: 5,
            atomicMass: 9.013328782,//atomic weight
            abundance: 0.0,
            massDefect: 12.415681,//mass excess
            bindingEnergy: 6.25716,
            halfLife: "8.448148148148e-10ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-10
            symbol: "B",
            massNumber: 10,//p+n
            atomicNumber: 5,
            atomicMass: 10.012936992,//atomic weight
            abundance: 19.8,
            massDefect: 12.050731,//mass excess
            bindingEnergy: 6.475071,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-11
            symbol: "B",
            massNumber: 11,//p+n
            atomicNumber: 5,
            atomicMass: 11.009305406,//atomic weight
            abundance: 80.2,
            massDefect: 8.667931,//mass excess
            bindingEnergy: 6.927711,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-12
            symbol: "B",
            massNumber: 12,//p+n
            atomicNumber: 5,
            atomicMass: 12.014352104,//atomic weight
            abundance: 0.0,
            massDefect: 13.368899,//mass excess
            bindingEnergy: 6.631264,
            halfLife: "20.2ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-13
            symbol: "B",
            massNumber: 13,//p+n
            atomicNumber: 5,
            atomicMass: 13.017780217,//atomic weight
            abundance: 0.0,
            massDefect: 16.562166,//mass excess
            bindingEnergy: 6.496402,
            halfLife: "17.33ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-14
            symbol: "B",
            massNumber: 14,//p+n
            atomicNumber: 5,
            atomicMass: 14.025404009,//atomic weight
            abundance: 0.0,
            massDefect: 23.663683,//mass excess
            bindingEnergy: 6.101645,
            halfLife: "12.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-15
            symbol: "B",
            massNumber: 15,//p+n
            atomicNumber: 5,
            atomicMass: 15.031103021,//atomic weight
            abundance: 0.0,
            massDefect: 28.972278,//mass excess
            bindingEnergy: 5.87905,
            halfLife: "9.93ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-16
            symbol: "B",
            massNumber: 16,//p+n
            atomicNumber: 5,
            atomicMass: 16.039808829,//atomic weight
            abundance: 0.0,
            massDefect: 37.081686,//mass excess
            bindingEnergy: 5.509228,
            halfLife: "0.19ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-17
            symbol: "B",
            massNumber: 17,//p+n
            atomicNumber: 5,
            atomicMass: 17.046989906,//atomic weight
            abundance: 0.0,
            massDefect: 43.770816,//mass excess
            bindingEnergy: 5.266461,
            halfLife: "5.08ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-18
            symbol: "B",
            massNumber: 18,//p+n
            atomicNumber: 5,
            atomicMass: 18.05617,//atomic weight
            abundance: 0.0,
            massDefect: 52.322,//mass excess
            bindingEnergy: 4.947,
            halfLife: "26ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Boron",//B-19
            symbol: "B",
            massNumber: 19,//p+n
            atomicNumber: 5,
            atomicMass: 19.06373,//atomic weight
            abundance: 0.0,
            massDefect: 59.364,//mass excess
            bindingEnergy: 4.741,
            halfLife: "2.92ms"
        ));
        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Carbon ------------------------------------------------------ Carbon
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-8
            symbol: "C",
            massNumber: 8,//p+n
            atomicNumber: 6,
            atomicMass: 8.037675025,//atomic weight
            abundance: 0.0,
            massDefect: 35.09406,//mass excess
            bindingEnergy: 3.0978,
            halfLife: "2e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-9
            symbol: "C",
            massNumber: 9,//p+n
            atomicNumber: 6,
            atomicMass: 9.031036689,//atomic weight
            abundance: 0.0,
            massDefect: 28.910491,//mass excess
            bindingEnergy: 4.337476,
            halfLife: "126.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-10
            symbol: "C",
            massNumber: 10,//p+n
            atomicNumber: 6,
            atomicMass: 10.016853228,//atomic weight
            abundance: 0.0,
            massDefect: 15.698682,//mass excess
            bindingEnergy: 6.032041,
            halfLife: "19.29s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-11
            symbol: "C",
            massNumber: 11,//p+n
            atomicNumber: 6,
            atomicMass: 11.011433613,//atomic weight
            abundance: 0.0,
            massDefect: 10.650342,//mass excess
            bindingEnergy: 6.67637,
            halfLife: "20.334m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-12
            symbol: "C",
            massNumber: 12,//p+n
            atomicNumber: 6,
            atomicMass: 12.0,//atomic weight
            abundance: 98.89,
            massDefect: 0.0,//mass excess
            bindingEnergy: 7.680144,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-13
            symbol: "C",
            massNumber: 13,//p+n
            atomicNumber: 6,
            atomicMass: 13.00335483778,//atomic weight
            abundance: 1.11,
            massDefect: 3.12501129,//mass excess
            bindingEnergy: 7.469849,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-14
            symbol: "C",
            massNumber: 14,//p+n
            atomicNumber: 6,
            atomicMass: 14.0032419887,//atomic weight
            abundance: 0.0,
            massDefect: 3.01989305,//mass excess
            bindingEnergy: 7.520319,
            halfLife: "5707.762557078y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-15
            symbol: "C",
            massNumber: 15,//p+n
            atomicNumber: 6,
            atomicMass: 15.010599256,//atomic weight
            abundance: 0.0,
            massDefect: 9.873144,//mass excess
            bindingEnergy: 7.100169,
            halfLife: "2.449s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-16
            symbol: "C",
            massNumber: 16,//p+n
            atomicNumber: 6,
            atomicMass: 16.014701252,//atomic weight
            abundance: 0.0,
            massDefect: 13.694129,//mass excess
            bindingEnergy: 6.922054,
            halfLife: "747ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-17
            symbol: "C",
            massNumber: 17,//p+n
            atomicNumber: 6,
            atomicMass: 17.022586116,//atomic weight
            abundance: 0.0,
            massDefect: 21.038832,//mass excess
            bindingEnergy: 6.557616,
            halfLife: "193ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-18
            symbol: "C",
            massNumber: 18,//p+n
            atomicNumber: 6,
            atomicMass: 18.026759354,//atomic weight
            abundance: 0.0,
            massDefect: 24.926178,//mass excess
            bindingEnergy: 6.425747,
            halfLife: "91ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-19
            symbol: "C",
            massNumber: 19,//p+n
            atomicNumber: 6,
            atomicMass: 19.034805018,//atomic weight
            abundance: 0.0,
            massDefect: 32.420666,//mass excess
            bindingEnergy: 6.117909,
            halfLife: "49ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-20
            symbol: "C",
            massNumber: 20,//p+n
            atomicNumber: 6,
            atomicMass: 20.040319754,//atomic weight
            abundance: 0.0,
            massDefect: 37.55761,//mass excess
            bindingEnergy: 5.958733,
            halfLife: "14ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-21
            symbol: "C",
            massNumber: 21,//p+n
            atomicNumber: 6,
            atomicMass: 21.04934,//atomic weight
            abundance: 0.0,
            massDefect: 45.96,//mass excess
            bindingEnergy: 5.659,
            halfLife: "129.99999999998ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Carbon",//C-22
            symbol: "C",
            massNumber: 22,//p+n
            atomicNumber: 6,
            atomicMass: 22.0572,//atomic weight
            abundance: 0.0,
            massDefect: 53.281,//mass excess
            bindingEnergy: 5.436,
            halfLife: "6.2ms"
        ));
        #endregion

        #region Nitrogen ------------------------------------------------------ Nitrogen
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-10
            symbol: "N",
            massNumber: 10,//p+n
            atomicNumber: 7,
            atomicMass: 10.041653674,//atomic weight
            abundance: 0.0,
            massDefect: 38.800148,//mass excess
            bindingEnergy: 3.64366,
            halfLife: "2e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-11
            symbol: "N",
            massNumber: 11,//p+n
            atomicNumber: 7,
            atomicMass: 11.026090956,//atomic weight
            abundance: 0.0,
            massDefect: 24.303569,//mass excess
            bindingEnergy: 5.364045,
            halfLife: "5.9e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-12
            symbol: "N",
            massNumber: 12,//p+n
            atomicNumber: 7,
            atomicMass: 12.018613197,//atomic weight
            abundance: 0.0,
            massDefect: 17.338082,//mass excess
            bindingEnergy: 6.170108,
            halfLife: "11ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-13
            symbol: "N",
            massNumber: 13,//p+n
            atomicNumber: 7,
            atomicMass: 13.005738609,//atomic weight
            abundance: 0.0,
            massDefect: 5.345481,//mass excess
            bindingEnergy: 7.238863,
            halfLife: "9.965m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-14
            symbol: "N",
            massNumber: 14,//p+n
            atomicNumber: 7,
            atomicMass: 14.00307400478,//atomic weight
            abundance: 99.634,
            massDefect: 2.86341704,//mass excess
            bindingEnergy: 7.475614,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-15
            symbol: "N",
            massNumber: 15,//p+n
            atomicNumber: 7,
            atomicMass: 15.00010889823,//atomic weight
            abundance: 0.366,
            massDefect: 0.10143805,//mass excess
            bindingEnergy: 7.699459,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-16
            symbol: "N",
            massNumber: 16,//p+n
            atomicNumber: 7,
            atomicMass: 16.006101658,//atomic weight
            abundance: 0.0,
            massDefect: 5.683658,//mass excess
            bindingEnergy: 7.373812,
            halfLife: "7.13s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-17
            symbol: "N",
            massNumber: 17,//p+n
            atomicNumber: 7,
            atomicMass: 17.008450261,//atomic weight
            abundance: 0.0,
            massDefect: 7.871368,//mass excess
            bindingEnergy: 7.286153,
            halfLife: "4.173s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-18
            symbol: "N",
            massNumber: 18,//p+n
            atomicNumber: 7,
            atomicMass: 18.014078959,//atomic weight
            abundance: 0.0,
            massDefect: 13.114466,//mass excess
            bindingEnergy: 7.03849,
            halfLife: "624ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-19
            symbol: "N",
            massNumber: 19,//p+n
            atomicNumber: 7,
            atomicMass: 19.017028697,//atomic weight
            abundance: 0.0,
            massDefect: 15.862129,//mass excess
            bindingEnergy: 6.948235,
            halfLife: "271ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-20
            symbol: "N",
            massNumber: 20,//p+n
            atomicNumber: 7,
            atomicMass: 20.023365807,//atomic weight
            abundance: 0.0,
            massDefect: 21.76511,//mass excess
            bindingEnergy: 6.70924,
            halfLife: "130ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-21
            symbol: "N",
            massNumber: 21,//p+n
            atomicNumber: 7,
            atomicMass: 21.02710824,//atomic weight
            abundance: 0.0,
            massDefect: 25.251164,//mass excess
            bindingEnergy: 6.608099,
            halfLife: "85ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-22
            symbol: "N",
            massNumber: 22,//p+n
            atomicNumber: 7,
            atomicMass: 22.034394934,//atomic weight
            abundance: 0.0,
            massDefect: 32.038675,//mass excess
            bindingEnergy: 6.366085,
            halfLife: "24ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-23
            symbol: "N",
            massNumber: 23,//p+n
            atomicNumber: 7,
            atomicMass: 23.04122,//atomic weight
            abundance: 0.0,
            massDefect: 38.396,//mass excess
            bindingEnergy: 6.164,
            halfLife: "14.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-24
            symbol: "N",
            massNumber: 24,//p+n
            atomicNumber: 7,
            atomicMass: 24.05104,//atomic weight
            abundance: 0.0,
            massDefect: 47.543,//mass excess
            bindingEnergy: 5.862,
            halfLife: "52.00000000001ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nitrogen",//N-25
            symbol: "N",
            massNumber: 25,//p+n
            atomicNumber: 7,
            atomicMass: 25.06066,//atomic weight
            abundance: 0.0,
            massDefect: 56.504,//mass excess
            bindingEnergy: 5.592,
            halfLife: "260ns"
        ));
        #endregion

        #region Oxygen ------------------------------------------------------ Oxygen
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-12
            symbol: "O",
            massNumber: 12,//p+n
            atomicNumber: 8,
            atomicMass: 12.034404895,//atomic weight
            abundance: 0.0,
            massDefect: 32.047954,//mass excess
            bindingEnergy: 4.87909,
            halfLife: "1.1405e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-13
            symbol: "O",
            massNumber: 13,//p+n
            atomicNumber: 8,
            atomicMass: 13.024812213,//atomic weight
            abundance: 0.0,
            massDefect: 23.112428,//mass excess
            bindingEnergy: 5.811994,
            halfLife: "8.59ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-14
            symbol: "O",
            massNumber: 14,//p+n
            atomicNumber: 8,
            atomicMass: 14.00859625,//atomic weight
            abundance: 0.0,
            massDefect: 8.007356,//mass excess
            bindingEnergy: 7.052308,
            halfLife: "1.176766666667m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-15
            symbol: "O",
            massNumber: 15,//p+n
            atomicNumber: 8,
            atomicMass: 15.003065617,//atomic weight
            abundance: 0.0,
            massDefect: 2.855605,//mass excess
            bindingEnergy: 7.463692,
            halfLife: "2.037333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-16
            symbol: "O",
            massNumber: 16,//p+n
            atomicNumber: 8,
            atomicMass: 15.99491461956,//atomic weight
            abundance: 99.762,
            massDefect: -4.73700141,//mass excess
            bindingEnergy: 7.976206,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-17
            symbol: "O",
            massNumber: 17,//p+n
            atomicNumber: 8,
            atomicMass: 16.999131703,//atomic weight
            abundance: 0.038,
            massDefect: -0.808813,//mass excess
            bindingEnergy: 7.750731,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-18
            symbol: "O",
            massNumber: 18,//p+n
            atomicNumber: 8,
            atomicMass: 17.999161001,//atomic weight
            abundance: 0.2,
            massDefect: -0.781522,//mass excess
            bindingEnergy: 7.767025,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-19
            symbol: "O",
            massNumber: 19,//p+n
            atomicNumber: 8,
            atomicMass: 19.00358013,//atomic weight
            abundance: 0.0,
            massDefect: 3.33487,//mass excess
            bindingEnergy: 7.566389,
            halfLife: "26.88s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-20
            symbol: "O",
            massNumber: 20,//p+n
            atomicNumber: 8,
            atomicMass: 20.004076742,//atomic weight
            abundance: 0.0,
            massDefect: 3.797462,//mass excess
            bindingEnergy: 7.568505,
            halfLife: "13.51s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-21
            symbol: "O",
            massNumber: 21,//p+n
            atomicNumber: 8,
            atomicMass: 21.008655886,//atomic weight
            abundance: 0.0,
            massDefect: 8.062906,//mass excess
            bindingEnergy: 7.389332,
            halfLife: "3.42s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-22
            symbol: "O",
            massNumber: 22,//p+n
            atomicNumber: 8,
            atomicMass: 22.009966947,//atomic weight
            abundance: 0.0,
            massDefect: 9.284152,//mass excess
            bindingEnergy: 7.364821,
            halfLife: "2.25s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-23
            symbol: "O",
            massNumber: 23,//p+n
            atomicNumber: 8,
            atomicMass: 23.015687659,//atomic weight
            abundance: 0.0,
            massDefect: 14.61296,//mass excess
            bindingEnergy: 7.16385,
            halfLife: "82ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-24
            symbol: "O",
            massNumber: 24,//p+n
            atomicNumber: 8,
            atomicMass: 24.020472917,//atomic weight
            abundance: 0.0,
            massDefect: 19.0704,//mass excess
            bindingEnergy: 7.015935,
            halfLife: "65ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-25
            symbol: "O",
            massNumber: 25,//p+n
            atomicNumber: 8,
            atomicMass: 25.02946,//atomic weight
            abundance: 0.0,
            massDefect: 27.442,//mass excess
            bindingEnergy: 6.723,
            halfLife: "49.99999999997ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-26
            symbol: "O",
            massNumber: 26,//p+n
            atomicNumber: 8,
            atomicMass: 26.03834,//atomic weight
            abundance: 0.0,
            massDefect: 35.713,//mass excess
            bindingEnergy: 6.457,
            halfLife: "39.99999999998ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-27
            symbol: "O",
            massNumber: 27,//p+n
            atomicNumber: 8,
            atomicMass: 27.04826,//atomic weight
            abundance: 0.0,
            massDefect: 44.954,//mass excess
            bindingEnergy: 6.175,
            halfLife: "260ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Oxygen",//O-28
            symbol: "O",
            massNumber: 28,//p+n
            atomicNumber: 8,
            atomicMass: 28.05781,//atomic weight
            abundance: 0.0,
            massDefect: 53.85,//mass excess
            bindingEnergy: 5.925,
            halfLife: "100ns"
        ));
        #endregion

        #region Fluorine ------------------------------------------------------ Fluorine
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-15
            symbol: "F",
            massNumber: 15,//p+n
            atomicNumber: 9,
            atomicMass: 15.018009103,//atomic weight
            abundance: 0.0,
            massDefect: 16.775372,//mass excess
            bindingEnergy: 6.483551,
            halfLife: "4.562e-13ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-16
            symbol: "F",
            massNumber: 16,//p+n
            atomicNumber: 9,
            atomicMass: 16.011465724,//atomic weight
            abundance: 0.0,
            massDefect: 10.680254,//mass excess
            bindingEnergy: 6.963731,
            halfLife: "1.1405e-11ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-17
            symbol: "F",
            massNumber: 17,//p+n
            atomicNumber: 9,
            atomicMass: 17.002095237,//atomic weight
            abundance: 0.0,
            massDefect: 1.951701,//mass excess
            bindingEnergy: 7.542328,
            halfLife: "1.074833333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-18
            symbol: "F",
            massNumber: 18,//p+n
            atomicNumber: 9,
            atomicMass: 18.000937956,//atomic weight
            abundance: 0.0,
            massDefect: 0.873701,//mass excess
            bindingEnergy: 7.631605,
            halfLife: "1.829516666667h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-19
            symbol: "F",
            massNumber: 19,//p+n
            atomicNumber: 9,
            atomicMass: 18.998403224,//atomic weight
            abundance: 100.0,
            massDefect: -1.487386,//mass excess
            bindingEnergy: 7.779015,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-20
            symbol: "F",
            massNumber: 20,//p+n
            atomicNumber: 9,
            atomicMass: 19.999981315,//atomic weight
            abundance: 0.0,
            massDefect: -0.017404,//mass excess
            bindingEnergy: 7.720131,
            halfLife: "11.07s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-21
            symbol: "F",
            massNumber: 21,//p+n
            atomicNumber: 9,
            atomicMass: 20.999948951,//atomic weight
            abundance: 0.0,
            massDefect: -0.047551,//mass excess
            bindingEnergy: 7.73829,
            halfLife: "4.158s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-22
            symbol: "F",
            massNumber: 22,//p+n
            atomicNumber: 9,
            atomicMass: 22.002998815,//atomic weight
            abundance: 0.0,
            massDefect: 2.793378,//mass excess
            bindingEnergy: 7.624294,
            halfLife: "4.23s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-23
            symbol: "F",
            massNumber: 23,//p+n
            atomicNumber: 9,
            atomicMass: 23.003574631,//atomic weight
            abundance: 0.0,
            massDefect: 3.329747,//mass excess
            bindingEnergy: 7.62041,
            halfLife: "2.23s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-24
            symbol: "F",
            massNumber: 24,//p+n
            atomicNumber: 9,
            atomicMass: 24.008115485,//atomic weight
            abundance: 0.0,
            massDefect: 7.559527,//mass excess
            bindingEnergy: 7.462957,
            halfLife: "390ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-25
            symbol: "F",
            massNumber: 25,//p+n
            atomicNumber: 9,
            atomicMass: 25.012101747,//atomic weight
            abundance: 0.0,
            massDefect: 11.272706,//mass excess
            bindingEnergy: 7.338764,
            halfLife: "50ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-26
            symbol: "F",
            massNumber: 26,//p+n
            atomicNumber: 9,
            atomicMass: 26.019615555,//atomic weight
            abundance: 0.0,
            massDefect: 18.271772,//mass excess
            bindingEnergy: 7.097744,
            halfLife: "9.6ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-27
            symbol: "F",
            massNumber: 27,//p+n
            atomicNumber: 9,
            atomicMass: 27.026760086,//atomic weight
            abundance: 0.0,
            massDefect: 24.92686,//mass excess
            bindingEnergy: 6.887318,
            halfLife: "5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-28
            symbol: "F",
            massNumber: 28,//p+n
            atomicNumber: 9,
            atomicMass: 28.03567,//atomic weight
            abundance: 0.0,
            massDefect: 33.226,//mass excess
            bindingEnergy: 6.633,
            halfLife: "39.99999999998ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-29
            symbol: "F",
            massNumber: 29,//p+n
            atomicNumber: 9,
            atomicMass: 29.04326,//atomic weight
            abundance: 0.0,
            massDefect: 40.296,//mass excess
            bindingEnergy: 6.439,
            halfLife: "2.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-30
            symbol: "F",
            massNumber: 30,//p+n
            atomicNumber: 9,
            atomicMass: 30.0525,//atomic weight
            abundance: 0.0,
            massDefect: 48.903,//mass excess
            bindingEnergy: 6.206,
            halfLife: "260ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Fluorine",//F-31
            symbol: "F",
            massNumber: 31,//p+n
            atomicNumber: 9,
            atomicMass: 31.060429,//atomic weight
            abundance: 0.0,
            massDefect: 56.289,//mass excess
            bindingEnergy: 6.028,
            halfLife: "250ns"
        ));
        #endregion

        #region Neon ------------------------------------------------------ Neon
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-16
            symbol: "Ne",
            massNumber: 16,//p+n
            atomicNumber: 10,
            atomicMass: 16.025761262,//atomic weight
            abundance: 0.0,
            massDefect: 23.996462,//mass excess
            bindingEnergy: 6.082572,
            halfLife: "3.739344262295e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-17
            symbol: "Ne",
            massNumber: 17,//p+n
            atomicNumber: 10,
            atomicMass: 17.017671504,//atomic weight
            abundance: 0.0,
            massDefect: 16.460901,//mass excess
            bindingEnergy: 6.642825,
            halfLife: "109.2ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-18
            symbol: "Ne",
            massNumber: 18,//p+n
            atomicNumber: 10,
            atomicMass: 18.005708213,//atomic weight
            abundance: 0.0,
            massDefect: 5.317166,//mass excess
            bindingEnergy: 7.341282,
            halfLife: "1.672s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-19
            symbol: "Ne",
            massNumber: 19,//p+n
            atomicNumber: 10,
            atomicMass: 19.001880248,//atomic weight
            abundance: 0.0,
            massDefect: 1.75144,//mass excess
            bindingEnergy: 7.567375,
            halfLife: "17.22s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-20
            symbol: "Ne",
            massNumber: 20,//p+n
            atomicNumber: 10,
            atomicMass: 19.99244017542,//atomic weight
            abundance: 90.48,
            massDefect: -7.04193131,//mass excess
            bindingEnergy: 8.03224,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-21
            symbol: "Ne",
            massNumber: 21,//p+n
            atomicNumber: 10,
            atomicMass: 20.993846684,//atomic weight
            abundance: 0.27,
            massDefect: -5.731776,//mass excess
            bindingEnergy: 7.971713,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-22
            symbol: "Ne",
            massNumber: 22,//p+n
            atomicNumber: 10,
            atomicMass: 21.991385113,//atomic weight
            abundance: 9.25,
            massDefect: -8.024715,//mass excess
            bindingEnergy: 8.080465,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-23
            symbol: "Ne",
            massNumber: 23,//p+n
            atomicNumber: 10,
            atomicMass: 22.994466904,//atomic weight
            abundance: 0.0,
            massDefect: -5.154045,//mass excess
            bindingEnergy: 7.955255,
            halfLife: "37.24s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-24
            symbol: "Ne",
            massNumber: 24,//p+n
            atomicNumber: 10,
            atomicMass: 23.993610779,//atomic weight
            abundance: 0.0,
            massDefect: -5.951521,//mass excess
            bindingEnergy: 7.993319,
            halfLife: "3.383333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-25
            symbol: "Ne",
            massNumber: 25,//p+n
            atomicNumber: 10,
            atomicMass: 24.997736888,//atomic weight
            abundance: 0.0,
            massDefect: -2.108075,//mass excess
            bindingEnergy: 7.842701,
            halfLife: "602ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-26
            symbol: "Ne",
            massNumber: 26,//p+n
            atomicNumber: 10,
            atomicMass: 26.000461206,//atomic weight
            abundance: 0.0,
            massDefect: 0.429611,//mass excess
            bindingEnergy: 7.753891,
            halfLife: "192ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-27
            symbol: "Ne",
            massNumber: 27,//p+n
            atomicNumber: 10,
            atomicMass: 27.007589903,//atomic weight
            abundance: 0.0,
            massDefect: 7.069949,//mass excess
            bindingEnergy: 7.519709,
            halfLife: "32ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-28
            symbol: "Ne",
            massNumber: 28,//p+n
            atomicNumber: 10,
            atomicMass: 28.012071575,//atomic weight
            abundance: 0.0,
            massDefect: 11.244601,//mass excess
            bindingEnergy: 7.390315,
            halfLife: "18.9ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-29
            symbol: "Ne",
            massNumber: 29,//p+n
            atomicNumber: 10,
            atomicMass: 29.019385933,//atomic weight
            abundance: 0.0,
            massDefect: 18.057881,//mass excess
            bindingEnergy: 7.178857,
            halfLife: "14.8ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-30
            symbol: "Ne",
            massNumber: 30,//p+n
            atomicNumber: 10,
            atomicMass: 30.024801045,//atomic weight
            abundance: 0.0,
            massDefect: 23.102025,//mass excess
            bindingEnergy: 7.040467,
            halfLife: "7.3ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-31
            symbol: "Ne",
            massNumber: 31,//p+n
            atomicNumber: 10,
            atomicMass: 31.03311,//atomic weight
            abundance: 0.0,
            massDefect: 30.842,//mass excess
            bindingEnergy: 6.824,
            halfLife: "3.4ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-32
            symbol: "Ne",
            massNumber: 32,//p+n
            atomicNumber: 10,
            atomicMass: 32.04002,//atomic weight
            abundance: 0.0,
            massDefect: 37.278,//mass excess
            bindingEnergy: 6.662,
            halfLife: "3.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-33
            symbol: "Ne",
            massNumber: 33,//p+n
            atomicNumber: 10,
            atomicMass: 33.04938,//atomic weight
            abundance: 0.0,
            massDefect: 45.997,//mass excess
            bindingEnergy: 6.44,
            halfLife: "180ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Neon",//Ne-34
            symbol: "Ne",
            massNumber: 34,//p+n
            atomicNumber: 10,
            atomicMass: 34.057028,//atomic weight
            abundance: 0.0,
            massDefect: 53.121,//mass excess
            bindingEnergy: 6.279,
            halfLife: "60.00000000002ns"
        ));
        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Sodium ------------------------------------------------------ Sodium
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-18
            symbol: "Na",
            massNumber: 18,//p+n
            atomicNumber: 11,
            atomicMass: 18.025969,//atomic weight
            abundance: 0.0,
            massDefect: 24.189968,//mass excess
            bindingEnergy: 6.249329,
            halfLife: "1.3e-12ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-19
            symbol: "Na",
            massNumber: 19,//p+n
            atomicNumber: 11,
            atomicMass: 19.013877499,//atomic weight
            abundance: 0.0,
            massDefect: 12.926808,//mass excess
            bindingEnergy: 6.938021,
            halfLife: "39.99999999998ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-20
            symbol: "Na",
            massNumber: 20,//p+n
            atomicNumber: 11,
            atomicMass: 20.007351328,//atomic weight
            abundance: 0.0,
            massDefect: 6.847719,//mass excess
            bindingEnergy: 7.298641,
            halfLife: "447.9ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-21
            symbol: "Na",
            massNumber: 21,//p+n
            atomicNumber: 11,
            atomicMass: 20.997655206,//atomic weight
            abundance: 0.0,
            massDefect: -2.184161,//mass excess
            bindingEnergy: 7.765524,
            halfLife: "22.49s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-22
            symbol: "Na",
            massNumber: 22,//p+n
            atomicNumber: 11,
            atomicMass: 21.994436425,//atomic weight
            abundance: 0.0,
            massDefect: -5.182436,//mass excess
            bindingEnergy: 7.915709,
            halfLife: "2.6027y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-23
            symbol: "Na",
            massNumber: 23,//p+n
            atomicNumber: 11,
            atomicMass: 22.98976928087,//atomic weight
            abundance: 100.0,
            massDefect: -9.52985358,//mass excess
            bindingEnergy: 8.111493,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-24
            symbol: "Na",
            massNumber: 24,//p+n
            atomicNumber: 11,
            atomicMass: 23.990962782,//atomic weight
            abundance: 0.0,
            massDefect: -8.418114,//mass excess
            bindingEnergy: 8.063496,
            halfLife: "14.997h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-25
            symbol: "Na",
            massNumber: 25,//p+n
            atomicNumber: 11,
            atomicMass: 24.989953968,//atomic weight
            abundance: 0.0,
            massDefect: -9.357818,//mass excess
            bindingEnergy: 8.101397,
            halfLife: "59.1s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-26
            symbol: "Na",
            massNumber: 26,//p+n
            atomicNumber: 11,
            atomicMass: 25.992633,//atomic weight
            abundance: 0.0,
            massDefect: -6.862316,//mass excess
            bindingEnergy: 8.00426,
            halfLife: "1.077s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-27
            symbol: "Na",
            massNumber: 27,//p+n
            atomicNumber: 11,
            atomicMass: 26.994076788,//atomic weight
            abundance: 0.0,
            massDefect: -5.517436,//mass excess
            bindingEnergy: 7.956933,
            halfLife: "301ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-28
            symbol: "Na",
            massNumber: 28,//p+n
            atomicNumber: 11,
            atomicMass: 27.998938,//atomic weight
            abundance: 0.0,
            massDefect: -0.989247,//mass excess
            bindingEnergy: 7.799297,
            halfLife: "30.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-29
            symbol: "Na",
            massNumber: 29,//p+n
            atomicNumber: 11,
            atomicMass: 29.002861,//atomic weight
            abundance: 0.0,
            massDefect: 2.665004,//mass excess
            bindingEnergy: 7.682668,
            halfLife: "44.9ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-30
            symbol: "Na",
            massNumber: 30,//p+n
            atomicNumber: 11,
            atomicMass: 30.008976,//atomic weight
            abundance: 0.0,
            massDefect: 8.36109,//mass excess
            bindingEnergy: 7.505754,
            halfLife: "48.4ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-31
            symbol: "Na",
            massNumber: 31,//p+n
            atomicNumber: 11,
            atomicMass: 31.013585452,//atomic weight
            abundance: 0.0,
            massDefect: 12.654768,//mass excess
            bindingEnergy: 7.385492,
            halfLife: "17ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-32
            symbol: "Na",
            massNumber: 32,//p+n
            atomicNumber: 11,
            atomicMass: 32.02046656,//atomic weight
            abundance: 0.0,
            massDefect: 19.064478,//mass excess
            bindingEnergy: 7.206621,
            halfLife: "13.2ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-33
            symbol: "Na",
            massNumber: 33,//p+n
            atomicNumber: 11,
            atomicMass: 33.026719756,//atomic weight
            abundance: 0.0,
            massDefect: 24.889293,//mass excess
            bindingEnergy: 7.056314,
            halfLife: "8ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-34
            symbol: "Na",
            massNumber: 34,//p+n
            atomicNumber: 11,
            atomicMass: 34.03517,//atomic weight
            abundance: 0.0,
            massDefect: 32.761,//mass excess
            bindingEnergy: 6.855,
            halfLife: "5.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-35
            symbol: "Na",
            massNumber: 35,//p+n
            atomicNumber: 11,
            atomicMass: 35.042493,//atomic weight
            abundance: 0.0,
            massDefect: 39.582,//mass excess
            bindingEnergy: 6.695,
            halfLife: "1.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-36
            symbol: "Na",
            massNumber: 36,//p+n
            atomicNumber: 11,
            atomicMass: 36.05148,//atomic weight
            abundance: 0.0,
            massDefect: 47.953,//mass excess
            bindingEnergy: 6.5,
            halfLife: "180ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sodium",//Na-37
            symbol: "Na",
            massNumber: 37,//p+n
            atomicNumber: 11,
            atomicMass: 37.05934,//atomic weight
            abundance: 0.0,
            massDefect: 55.275,//mass excess
            bindingEnergy: 6.345,
            halfLife: "60.00000000002ns"
        ));
        #endregion

        #region Magnesium ------------------------------------------------------ Magnesium
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-20
            symbol: "Mg",
            massNumber: 20,//p+n
            atomicNumber: 12,
            atomicMass: 20.018862545,//atomic weight
            abundance: 0.0,
            massDefect: 17.570348,//mass excess
            bindingEnergy: 6.723392,
            halfLife: "90ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-21
            symbol: "Mg",
            massNumber: 21,//p+n
            atomicNumber: 12,
            atomicMass: 21.01171291,//atomic weight
            abundance: 0.0,
            massDefect: 10.910506,//mass excess
            bindingEnergy: 7.104714,
            halfLife: "122ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-22
            symbol: "Mg",
            massNumber: 22,//p+n
            atomicNumber: 12,
            atomicMass: 21.999573843,//atomic weight
            abundance: 0.0,
            massDefect: -0.396963,//mass excess
            bindingEnergy: 7.662626,
            halfLife: "3.8755s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-23
            symbol: "Mg",
            massNumber: 23,//p+n
            atomicNumber: 12,
            atomicMass: 22.994123669,//atomic weight
            abundance: 0.0,
            massDefect: -5.473766,//mass excess
            bindingEnergy: 7.901126,
            halfLife: "11.317s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-24
            symbol: "Mg",
            massNumber: 24,//p+n
            atomicNumber: 12,
            atomicMass: 23.985041699,//atomic weight
            abundance: 78.99,
            massDefect: -13.933567,//mass excess
            bindingEnergy: 8.260709,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-25
            symbol: "Mg",
            massNumber: 25,//p+n
            atomicNumber: 12,
            atomicMass: 24.985836917,//atomic weight
            abundance: 10.0,
            massDefect: -13.192826,//mass excess
            bindingEnergy: 8.223504,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-26
            symbol: "Mg",
            massNumber: 26,//p+n
            atomicNumber: 12,
            atomicMass: 25.982592929,//atomic weight
            abundance: 11.01,
            massDefect: -16.214582,//mass excess
            bindingEnergy: 8.333872,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-27
            symbol: "Mg",
            massNumber: 27,//p+n
            atomicNumber: 12,
            atomicMass: 26.984340585,//atomic weight
            abundance: 0.0,
            massDefect: -14.586651,//mass excess
            bindingEnergy: 8.263854,
            halfLife: "9.458333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-28
            symbol: "Mg",
            massNumber: 28,//p+n
            atomicNumber: 12,
            atomicMass: 27.983876825,//atomic weight
            abundance: 0.0,
            massDefect: -15.018641,//mass excess
            bindingEnergy: 8.272406,
            halfLife: "20.915h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-29
            symbol: "Mg",
            massNumber: 29,//p+n
            atomicNumber: 12,
            atomicMass: 28.9886,//atomic weight
            abundance: 0.0,
            massDefect: -10.619032,//mass excess
            bindingEnergy: 8.113761,
            halfLife: "1.3s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-30
            symbol: "Mg",
            massNumber: 30,//p+n
            atomicNumber: 12,
            atomicMass: 29.990434,//atomic weight
            abundance: 0.0,
            massDefect: -8.910672,//mass excess
            bindingEnergy: 8.055401,
            halfLife: "335ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-31
            symbol: "Mg",
            massNumber: 31,//p+n
            atomicNumber: 12,
            atomicMass: 30.996546,//atomic weight
            abundance: 0.0,
            massDefect: -3.21738,//mass excess
            bindingEnergy: 7.87226,
            halfLife: "232ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-32
            symbol: "Mg",
            massNumber: 32,//p+n
            atomicNumber: 12,
            atomicMass: 31.998975,//atomic weight
            abundance: 0.0,
            massDefect: -0.954781,//mass excess
            bindingEnergy: 7.807774,
            halfLife: "85ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-33
            symbol: "Mg",
            massNumber: 33,//p+n
            atomicNumber: 12,
            atomicMass: 33.005254,//atomic weight
            abundance: 0.0,
            massDefect: 4.89407,//mass excess
            bindingEnergy: 7.638522,
            halfLife: "90.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-34
            symbol: "Mg",
            massNumber: 34,//p+n
            atomicNumber: 12,
            atomicMass: 34.009456424,//atomic weight
            abundance: 0.0,
            massDefect: 8.808603,//mass excess
            bindingEnergy: 7.536118,
            halfLife: "20.19773057245ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-35
            symbol: "Mg",
            massNumber: 35,//p+n
            atomicNumber: 12,
            atomicMass: 35.01734,//atomic weight
            abundance: 0.0,
            massDefect: 16.152,//mass excess
            bindingEnergy: 7.342,
            halfLife: "70.69205700356ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-36
            symbol: "Mg",
            massNumber: 36,//p+n
            atomicNumber: 12,
            atomicMass: 36.023,//atomic weight
            abundance: 0.0,
            massDefect: 21.424,//mass excess
            bindingEnergy: 7.215,
            halfLife: "3.9ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-37
            symbol: "Mg",
            massNumber: 37,//p+n
            atomicNumber: 12,
            atomicMass: 37.0314,//atomic weight
            abundance: 0.0,
            massDefect: 29.249,//mass excess
            bindingEnergy: 7.027,
            halfLife: "260ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-38
            symbol: "Mg",
            massNumber: 38,//p+n
            atomicNumber: 12,
            atomicMass: 38.03757,//atomic weight
            abundance: 0.0,
            massDefect: 34.996,//mass excess
            bindingEnergy: 6.903,
            halfLife: "260ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-39
            symbol: "Mg",
            massNumber: 39,//p+n
            atomicNumber: 12,
            atomicMass: 39.046772,//atomic weight
            abundance: 0.0,
            massDefect: 43.568,//mass excess
            bindingEnergy: 6.713,
            halfLife: "180ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Magnesium",//Mg-40
            symbol: "Mg",
            massNumber: 40,//p+n
            atomicNumber: 12,
            atomicMass: 40.05393,//atomic weight
            abundance: 0.0,
            massDefect: 50.235,//mass excess
            bindingEnergy: 6.581,
            halfLife: "170ns"
        ));
        #endregion

        #region Aluminum ------------------------------------------------------ Aluminum
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-21
            symbol: "Al",
            massNumber: 21,//p+n
            atomicNumber: 13,
            atomicMass: 21.02804,//atomic weight
            abundance: 0.0,
            massDefect: 26.119,//mass excess
            bindingEnergy: 6.343,
            halfLife: "35.00000000001ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-22
            symbol: "Al",
            massNumber: 22,//p+n
            atomicNumber: 13,
            atomicMass: 22.01952,//atomic weight
            abundance: 0.0,
            massDefect: 18.183,//mass excess
            bindingEnergy: 6.783,
            halfLife: "59ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-23
            symbol: "Al",
            massNumber: 23,//p+n
            atomicNumber: 13,
            atomicMass: 23.007267432,//atomic weight
            abundance: 0.0,
            massDefect: 6.76957,//mass excess
            bindingEnergy: 7.334792,
            halfLife: "470ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-24
            symbol: "Al",
            massNumber: 24,//p+n
            atomicNumber: 13,
            atomicMass: 23.999938865,//atomic weight
            abundance: 0.0,
            massDefect: -0.056946,//mass excess
            bindingEnergy: 7.649919,
            halfLife: "2.053s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-25
            symbol: "Al",
            massNumber: 25,//p+n
            atomicNumber: 13,
            atomicMass: 24.990428095,//atomic weight
            abundance: 0.0,
            massDefect: -8.916172,//mass excess
            bindingEnergy: 8.021144,
            halfLife: "7.183s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-26
            symbol: "Al",
            massNumber: 26,//p+n
            atomicNumber: 13,
            atomicMass: 25.986891692,//atomic weight
            abundance: 0.0,
            massDefect: -12.210309,//mass excess
            bindingEnergy: 8.149771,
            halfLife: "716641.2988331y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-27
            symbol: "Al",
            massNumber: 27,//p+n
            atomicNumber: 13,
            atomicMass: 26.981538627,//atomic weight
            abundance: 100.0,
            massDefect: -17.196658,//mass excess
            bindingEnergy: 8.331545,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-28
            symbol: "Al",
            massNumber: 28,//p+n
            atomicNumber: 13,
            atomicMass: 27.981910306,//atomic weight
            abundance: 0.0,
            massDefect: -16.850441,//mass excess
            bindingEnergy: 8.309886,
            halfLife: "2.241333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-29
            symbol: "Al",
            massNumber: 29,//p+n
            atomicNumber: 13,
            atomicMass: 28.980445046,//atomic weight
            abundance: 0.0,
            massDefect: -18.215322,//mass excess
            bindingEnergy: 8.348725,
            halfLife: "6.566666666667m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-30
            symbol: "Al",
            massNumber: 30,//p+n
            atomicNumber: 13,
            atomicMass: 29.982960256,//atomic weight
            abundance: 0.0,
            massDefect: -15.872419,//mass excess
            bindingEnergy: 8.261381,
            halfLife: "3.6s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-31
            symbol: "Al",
            massNumber: 31,//p+n
            atomicNumber: 13,
            atomicMass: 30.983946619,//atomic weight
            abundance: 0.0,
            massDefect: -14.953628,//mass excess
            bindingEnergy: 8.225611,
            halfLife: "644ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-32
            symbol: "Al",
            massNumber: 32,//p+n
            atomicNumber: 13,
            atomicMass: 31.988124489,//atomic weight
            abundance: 0.0,
            massDefect: -11.061966,//mass excess
            bindingEnergy: 8.099175,
            halfLife: "33ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-33
            symbol: "Al",
            massNumber: 33,//p+n
            atomicNumber: 13,
            atomicMass: 32.990843336,//atomic weight
            abundance: 0.0,
            massDefect: -8.529377,//mass excess
            bindingEnergy: 8.021586,
            halfLife: "41.7ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-34
            symbol: "Al",
            massNumber: 34,//p+n
            atomicNumber: 13,
            atomicMass: 33.996851837,//atomic weight
            abundance: 0.0,
            massDefect: -2.932495,//mass excess
            bindingEnergy: 7.858434,
            halfLife: "42ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-35
            symbol: "Al",
            massNumber: 35,//p+n
            atomicNumber: 13,
            atomicMass: 34.999860235,//atomic weight
            abundance: 0.0,
            massDefect: -0.13019,//mass excess
            bindingEnergy: 7.784451,
            halfLife: "38.6ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-36
            symbol: "Al",
            massNumber: 36,//p+n
            atomicNumber: 13,
            atomicMass: 36.006207204,//atomic weight
            abundance: 0.0,
            massDefect: 5.781974,//mass excess
            bindingEnergy: 7.628193,
            halfLife: "90ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-37
            symbol: "Al",
            massNumber: 37,//p+n
            atomicNumber: 13,
            atomicMass: 37.01067782,//atomic weight
            abundance: 0.0,
            massDefect: 9.946326,//mass excess
            bindingEnergy: 7.527619,
            halfLife: "10.7ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-38
            symbol: "Al",
            massNumber: 38,//p+n
            atomicNumber: 13,
            atomicMass: 38.017231021,//atomic weight
            abundance: 0.0,
            massDefect: 16.050594,//mass excess
            bindingEnergy: 7.381288,
            halfLife: "7.6ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-39
            symbol: "Al",
            massNumber: 39,//p+n
            atomicNumber: 13,
            atomicMass: 39.02297,//atomic weight
            abundance: 0.0,
            massDefect: 21.396417,//mass excess
            bindingEnergy: 7.261909,
            halfLife: "7.6µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-40
            symbol: "Al",
            massNumber: 40,//p+n
            atomicNumber: 13,
            atomicMass: 40.03145,//atomic weight
            abundance: 0.0,
            massDefect: 29.295,//mass excess
            bindingEnergy: 7.085,
            halfLife: "260ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-41
            symbol: "Al",
            massNumber: 41,//p+n
            atomicNumber: 13,
            atomicMass: 41.03833,//atomic weight
            abundance: 0.0,
            massDefect: 35.704,//mass excess
            bindingEnergy: 6.952,
            halfLife: "260ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Aluminum",//Al-42
            symbol: "Al",
            massNumber: 42,//p+n
            atomicNumber: 13,
            atomicMass: 42.04689,//atomic weight
            abundance: 0.0,
            massDefect: 43.678,//mass excess
            bindingEnergy: 6.789,
            halfLife: "170ns"
        ));
        #endregion

        #region Silicon ------------------------------------------------------ Silicon
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-22
            symbol: "Si",
            massNumber: 22,//p+n
            atomicNumber: 14,
            atomicMass: 22.03453,//atomic weight
            abundance: 0.0,
            massDefect: 32.164,//mass excess
            bindingEnergy: 6.111,
            halfLife: "29ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-23
            symbol: "Si",
            massNumber: 23,//p+n
            atomicNumber: 14,
            atomicMass: 23.02552,//atomic weight
            abundance: 0.0,
            massDefect: 23.772,//mass excess
            bindingEnergy: 6.562,
            halfLife: "42.3ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-24
            symbol: "Si",
            massNumber: 24,//p+n
            atomicNumber: 14,
            atomicMass: 24.011545616,//atomic weight
            abundance: 0.0,
            massDefect: 10.754673,//mass excess
            bindingEnergy: 7.166837,
            halfLife: "140ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-25
            symbol: "Si",
            massNumber: 25,//p+n
            atomicNumber: 14,
            atomicMass: 25.004105574,//atomic weight
            abundance: 0.0,
            massDefect: 3.824318,//mass excess
            bindingEnergy: 7.48023,
            halfLife: "220ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-26
            symbol: "Si",
            massNumber: 26,//p+n
            atomicNumber: 14,
            atomicMass: 25.992329921,//atomic weight
            abundance: 0.0,
            massDefect: -7.144632,//mass excess
            bindingEnergy: 7.924847,
            halfLife: "2.234s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-27
            symbol: "Si",
            massNumber: 27,//p+n
            atomicNumber: 14,
            atomicMass: 26.986704905,//atomic weight
            abundance: 0.0,
            massDefect: -12.384301,//mass excess
            bindingEnergy: 8.124334,
            halfLife: "4.16s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-28
            symbol: "Si",
            massNumber: 28,//p+n
            atomicNumber: 14,
            atomicMass: 27.97692653246,//atomic weight
            abundance: 92.23,
            massDefect: -21.492796781,//mass excess
            bindingEnergy: 8.447744,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-29
            symbol: "Si",
            massNumber: 29,//p+n
            atomicNumber: 14,
            atomicMass: 28.9764947,//atomic weight
            abundance: 4.683,
            massDefect: -21.895046,//mass excess
            bindingEnergy: 8.448634,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-30
            symbol: "Si",
            massNumber: 30,//p+n
            atomicNumber: 14,
            atomicMass: 29.973770171,//atomic weight
            abundance: 3.087,
            massDefect: -24.432928,//mass excess
            bindingEnergy: 8.520653,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-31
            symbol: "Si",
            massNumber: 31,//p+n
            atomicNumber: 14,
            atomicMass: 30.975363227,//atomic weight
            abundance: 0.0,
            massDefect: -22.949006,//mass excess
            bindingEnergy: 8.45829,
            halfLife: "2.621666666667h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-32
            symbol: "Si",
            massNumber: 32,//p+n
            atomicNumber: 14,
            atomicMass: 31.974148082,//atomic weight
            abundance: 0.0,
            massDefect: -24.080907,//mass excess
            bindingEnergy: 8.481569,
            halfLife: "153y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-33
            symbol: "Si",
            massNumber: 33,//p+n
            atomicNumber: 14,
            atomicMass: 32.97800022,//atomic weight
            abundance: 0.0,
            massDefect: -20.492662,//mass excess
            bindingEnergy: 8.360402,
            halfLife: "6.11s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-34
            symbol: "Si",
            massNumber: 34,//p+n
            atomicNumber: 14,
            atomicMass: 33.978575524,//atomic weight
            abundance: 0.0,
            massDefect: -19.95677,//mass excess
            bindingEnergy: 8.336138,
            halfLife: "2.77s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-35
            symbol: "Si",
            massNumber: 35,//p+n
            atomicNumber: 14,
            atomicMass: 34.984583575,//atomic weight
            abundance: 0.0,
            massDefect: -14.360307,//mass excess
            bindingEnergy: 8.168673,
            halfLife: "780ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-36
            symbol: "Si",
            massNumber: 36,//p+n
            atomicNumber: 14,
            atomicMass: 35.986599477,//atomic weight
            abundance: 0.0,
            massDefect: -12.482507,//mass excess
            bindingEnergy: 8.113807,
            halfLife: "450ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-37
            symbol: "Si",
            massNumber: 37,//p+n
            atomicNumber: 14,
            atomicMass: 36.992936087,//atomic weight
            abundance: 0.0,
            massDefect: -6.579998,//mass excess
            bindingEnergy: 7.953132,
            halfLife: "90ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-38
            symbol: "Si",
            massNumber: 38,//p+n
            atomicNumber: 14,
            atomicMass: 37.995633601,//atomic weight
            abundance: 0.0,
            massDefect: -4.067274,//mass excess
            bindingEnergy: 7.890118,
            halfLife: "1µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-39
            symbol: "Si",
            massNumber: 39,//p+n
            atomicNumber: 14,
            atomicMass: 39.002070013,//atomic weight
            abundance: 0.0,
            massDefect: 1.928205,//mass excess
            bindingEnergy: 7.741034,
            halfLife: "47.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-40
            symbol: "Si",
            massNumber: 40,//p+n
            atomicNumber: 14,
            atomicMass: 40.0058691213,//atomic weight
            abundance: 0.0,
            massDefect: 5.467052,//mass excess
            bindingEnergy: 7.66081,
            halfLife: "33ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-41
            symbol: "Si",
            massNumber: 41,//p+n
            atomicNumber: 14,
            atomicMass: 41.01456,//atomic weight
            abundance: 0.0,
            massDefect: 13.562553,//mass excess
            bindingEnergy: 7.47338,
            halfLife: "20ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-42
            symbol: "Si",
            massNumber: 42,//p+n
            atomicNumber: 14,
            atomicMass: 42.01979,//atomic weight
            abundance: 0.0,
            massDefect: 18.434,//mass excess
            bindingEnergy: 7.372,
            halfLife: "12.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-43
            symbol: "Si",
            massNumber: 43,//p+n
            atomicNumber: 14,
            atomicMass: 43.02866,//atomic weight
            abundance: 0.0,
            massDefect: 26.697,//mass excess
            bindingEnergy: 7.196,
            halfLife: "60.00000000002ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Silicon",//Si-44
            symbol: "Si",
            massNumber: 44,//p+n
            atomicNumber: 14,
            atomicMass: 44.03526,//atomic weight
            abundance: 0.0,
            massDefect: 32.844,//mass excess
            bindingEnergy: 7.076,
            halfLife: "360.6737602222ns"
        ));
        #endregion

        #region Phosphorus ------------------------------------------------------ Phosphorus
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-25
            symbol: "P",
            massNumber: 25,//p+n
            atomicNumber: 15,
            atomicMass: 25.02026,//atomic weight
            abundance: 0.0,
            massDefect: 18.872,//mass excess
            bindingEnergy: 6.847,
            halfLife: "29.99999999998ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-26
            symbol: "P",
            massNumber: 26,//p+n
            atomicNumber: 15,
            atomicMass: 26.01178,//atomic weight
            abundance: 0.0,
            massDefect: 10.973,//mass excess
            bindingEnergy: 7.198,
            halfLife: "43.7ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-27
            symbol: "P",
            massNumber: 27,//p+n
            atomicNumber: 15,
            atomicMass: 26.999230236,//atomic weight
            abundance: 0.0,
            massDefect: -0.71703,//mass excess
            bindingEnergy: 7.663237,
            halfLife: "260ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-28
            symbol: "P",
            massNumber: 28,//p+n
            atomicNumber: 15,
            atomicMass: 27.992314761,//atomic weight
            abundance: 0.0,
            massDefect: -7.158753,//mass excess
            bindingEnergy: 7.907873,
            halfLife: "270.3ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-29
            symbol: "P",
            massNumber: 29,//p+n
            atomicNumber: 15,
            atomicMass: 28.981800606,//atomic weight
            abundance: 0.0,
            massDefect: -16.952626,//mass excess
            bindingEnergy: 8.251228,
            halfLife: "4.142s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-30
            symbol: "P",
            massNumber: 30,//p+n
            atomicNumber: 15,
            atomicMass: 29.978313789,//atomic weight
            abundance: 0.0,
            massDefect: -20.200575,//mass excess
            bindingEnergy: 8.353496,
            halfLife: "2.498333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-31
            symbol: "P",
            massNumber: 31,//p+n
            atomicNumber: 15,
            atomicMass: 30.973761629,//atomic weight
            abundance: 100.0,
            massDefect: -24.440885,//mass excess
            bindingEnergy: 8.481178,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-32
            symbol: "P",
            massNumber: 32,//p+n
            atomicNumber: 15,
            atomicMass: 31.973907274,//atomic weight
            abundance: 0.0,
            massDefect: -24.305218,//mass excess
            bindingEnergy: 8.46413,
            halfLife: "14.262d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-33
            symbol: "P",
            massNumber: 33,//p+n
            atomicNumber: 15,
            atomicMass: 32.971725543,//atomic weight
            abundance: 0.0,
            massDefect: -26.337486,//mass excess
            bindingEnergy: 8.513811,
            halfLife: "25.33564814815d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-34
            symbol: "P",
            massNumber: 34,//p+n
            atomicNumber: 15,
            atomicMass: 33.973636257,//atomic weight
            abundance: 0.0,
            massDefect: -24.557669,//mass excess
            bindingEnergy: 8.448449,
            halfLife: "12.43s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-35
            symbol: "P",
            massNumber: 35,//p+n
            atomicNumber: 15,
            atomicMass: 34.973314117,//atomic weight
            abundance: 0.0,
            massDefect: -24.85774,//mass excess
            bindingEnergy: 8.446247,
            halfLife: "47.3s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-36
            symbol: "P",
            massNumber: 36,//p+n
            atomicNumber: 15,
            atomicMass: 35.97825968,//atomic weight
            abundance: 0.0,
            massDefect: -20.250977,//mass excess
            bindingEnergy: 8.307866,
            halfLife: "5.6s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-37
            symbol: "P",
            massNumber: 37,//p+n
            atomicNumber: 15,
            atomicMass: 36.979608946,//atomic weight
            abundance: 0.0,
            massDefect: -18.994145,//mass excess
            bindingEnergy: 8.267505,
            halfLife: "2.31s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-38
            symbol: "P",
            massNumber: 38,//p+n
            atomicNumber: 15,
            atomicMass: 37.984156827,//atomic weight
            abundance: 0.0,
            massDefect: -14.75782,//mass excess
            bindingEnergy: 8.15086,
            halfLife: "640ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-39
            symbol: "P",
            massNumber: 39,//p+n
            atomicNumber: 15,
            atomicMass: 38.986179475,//atomic weight
            abundance: 0.0,
            massDefect: -12.873735,//mass excess
            bindingEnergy: 8.10051,
            halfLife: "280ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-40
            symbol: "P",
            massNumber: 40,//p+n
            atomicNumber: 15,
            atomicMass: 39.991296951,//atomic weight
            abundance: 0.0,
            massDefect: -8.106838,//mass excess
            bindingEnergy: 7.980608,
            halfLife: "125ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-41
            symbol: "P",
            massNumber: 41,//p+n
            atomicNumber: 15,
            atomicMass: 40.994335435,//atomic weight
            abundance: 0.0,
            massDefect: -5.276508,//mass excess
            bindingEnergy: 7.913788,
            halfLife: "100ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-42
            symbol: "P",
            massNumber: 42,//p+n
            atomicNumber: 15,
            atomicMass: 42.001007913,//atomic weight
            abundance: 0.0,
            massDefect: 0.938865,//mass excess
            bindingEnergy: 7.769554,
            halfLife: "48.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-43
            symbol: "P",
            massNumber: 43,//p+n
            atomicNumber: 15,
            atomicMass: 43.00619,//atomic weight
            abundance: 0.0,
            massDefect: 5.765948,//mass excess
            bindingEnergy: 7.664314,
            halfLife: "36.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-44
            symbol: "P",
            massNumber: 44,//p+n
            atomicNumber: 15,
            atomicMass: 44.01299,//atomic weight
            abundance: 0.0,
            massDefect: 12.1,//mass excess
            bindingEnergy: 7.53,
            halfLife: "18.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-45
            symbol: "P",
            massNumber: 45,//p+n
            atomicNumber: 15,
            atomicMass: 45.01922,//atomic weight
            abundance: 0.0,
            massDefect: 17.903,//mass excess
            bindingEnergy: 7.413,
            halfLife: "200ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Phosphorus",//P-46
            symbol: "P",
            massNumber: 46,//p+n
            atomicNumber: 15,
            atomicMass: 46.02738,//atomic weight
            abundance: 0.0,
            massDefect: 25.504,//mass excess
            bindingEnergy: 7.262,
            halfLife: "200ns"
        ));
        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Sulfur ------------------------------------------------------ Sulfur
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-26
            symbol: "S",
            massNumber: 26,//p+n
            atomicNumber: 16,
            atomicMass: 26.02788,//atomic weight
            abundance: 0.0,
            massDefect: 25.97,//mass excess
            bindingEnergy: 6.591,
            halfLife: "10ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-27
            symbol: "S",
            massNumber: 27,//p+n
            atomicNumber: 16,
            atomicMass: 27.018833,//atomic weight
            abundance: 0.0,
            massDefect: 17.543,//mass excess
            bindingEnergy: 6.958,
            halfLife: "15.5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-28
            symbol: "S",
            massNumber: 28,//p+n
            atomicNumber: 16,
            atomicMass: 28.004372763,//atomic weight
            abundance: 0.0,
            massDefect: 4.073203,//mass excess
            bindingEnergy: 7.47879,
            halfLife: "125ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-29
            symbol: "S",
            massNumber: 29,//p+n
            atomicNumber: 16,
            atomicMass: 28.996608049,//atomic weight
            abundance: 0.0,
            massDefect: -3.159582,//mass excess
            bindingEnergy: 7.748629,
            halfLife: "187ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-30
            symbol: "S",
            massNumber: 30,//p+n
            atomicNumber: 16,
            atomicMass: 29.984903249,//atomic weight
            abundance: 0.0,
            massDefect: -14.062532,//mass excess
            bindingEnergy: 8.122817,
            halfLife: "1.178s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-31
            symbol: "S",
            massNumber: 31,//p+n
            atomicNumber: 16,
            atomicMass: 30.979554728,//atomic weight
            abundance: 0.0,
            massDefect: -19.044648,//mass excess
            bindingEnergy: 8.281869,
            halfLife: "2.572s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-32
            symbol: "S",
            massNumber: 32,//p+n
            atomicNumber: 16,
            atomicMass: 31.972070999,//atomic weight
            abundance: 95.02,
            massDefect: -26.015697,//mass excess
            bindingEnergy: 8.493134,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-33
            symbol: "S",
            massNumber: 33,//p+n
            atomicNumber: 16,
            atomicMass: 32.971458759,//atomic weight
            abundance: 0.75,
            massDefect: -26.585994,//mass excess
            bindingEnergy: 8.497634,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-34
            symbol: "S",
            massNumber: 34,//p+n
            atomicNumber: 16,
            atomicMass: 33.9678669029,//atomic weight
            abundance: 4.21,
            massDefect: -29.931788,//mass excess
            bindingEnergy: 8.583501,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-35
            symbol: "S",
            massNumber: 35,//p+n
            atomicNumber: 16,
            atomicMass: 34.969032161,//atomic weight
            abundance: 0.0,
            massDefect: -28.846356,//mass excess
            bindingEnergy: 8.537855,
            halfLife: "87.51157407407d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-36
            symbol: "S",
            massNumber: 36,//p+n
            atomicNumber: 16,
            atomicMass: 35.96708076,//atomic weight
            abundance: 0.0,
            massDefect: -30.664075,//mass excess
            bindingEnergy: 8.575387,
            halfLife: "Stable"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-37
            symbol: "S",
            massNumber: 37,//p+n
            atomicNumber: 16,
            atomicMass: 36.971125567,//atomic weight
            abundance: 0.0,
            massDefect: -26.89636,//mass excess
            bindingEnergy: 8.459934,
            halfLife: "5.05m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-38
            symbol: "S",
            massNumber: 38,//p+n
            atomicNumber: 16,
            atomicMass: 37.971163317,//atomic weight
            abundance: 0.0,
            massDefect: -26.861197,//mass excess
            bindingEnergy: 8.448782,
            halfLife: "2.838888888889h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-39
            symbol: "S",
            massNumber: 39,//p+n
            atomicNumber: 16,
            atomicMass: 38.975134306,//atomic weight
            abundance: 0.0,
            massDefect: -23.162245,//mass excess
            bindingEnergy: 8.344258,
            halfLife: "11.5s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-40
            symbol: "S",
            massNumber: 40,//p+n
            atomicNumber: 16,
            atomicMass: 39.975451728,//atomic weight
            abundance: 0.0,
            massDefect: -22.866568,//mass excess
            bindingEnergy: 8.330043,
            halfLife: "8.8s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-41
            symbol: "S",
            massNumber: 41,//p+n
            atomicNumber: 16,
            atomicMass: 40.979582149,//atomic weight
            abundance: 0.0,
            massDefect: -19.019105,//mass excess
            bindingEnergy: 8.229892,
            halfLife: "1.99s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-42
            symbol: "S",
            massNumber: 42,//p+n
            atomicNumber: 16,
            atomicMass: 41.981022419,//atomic weight
            abundance: 0.0,
            massDefect: -17.677503,//mass excess
            bindingEnergy: 8.194173,
            halfLife: "1.013s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-43
            symbol: "S",
            massNumber: 43,//p+n
            atomicNumber: 16,
            atomicMass: 42.98715479,//atomic weight
            abundance: 0.0,
            massDefect: -11.965235,//mass excess
            bindingEnergy: 8.058473,
            halfLife: "280ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-44
            symbol: "S",
            massNumber: 44,//p+n
            atomicNumber: 16,
            atomicMass: 43.99021339,//atomic weight
            abundance: 0.0,
            massDefect: -9.116168,//mass excess
            bindingEnergy: 7.994013,
            halfLife: "100ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-45
            symbol: "S",
            massNumber: 45,//p+n
            atomicNumber: 16,
            atomicMass: 44.996508112,//atomic weight
            abundance: 0.0,
            massDefect: -3.252672,//mass excess
            bindingEnergy: 7.865431,
            halfLife: "68ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-46
            symbol: "S",
            massNumber: 46,//p+n
            atomicNumber: 16,
            atomicMass: 46.00075,//atomic weight
            abundance: 0.0,
            massDefect: 0.699,//mass excess
            bindingEnergy: 7.784,
            halfLife: "50ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-47
            symbol: "S",
            massNumber: 47,//p+n
            atomicNumber: 16,
            atomicMass: 47.00859,//atomic weight
            abundance: 0.0,
            massDefect: 8.002,//mass excess
            bindingEnergy: 7.635,
            halfLife: "20.19773057245ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-48
            symbol: "S",
            massNumber: 48,//p+n
            atomicNumber: 16,
            atomicMass: 48.01417,//atomic weight
            abundance: 0.0,
            massDefect: 13.199,//mass excess
            bindingEnergy: 7.536,
            halfLife: "200ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Sulfur",//S-49
            symbol: "S",
            massNumber: 49,//p+n
            atomicNumber: 16,
            atomicMass: 49.023619,//atomic weight
            abundance: 0.0,
            massDefect: 22.001,//mass excess
            bindingEnergy: 7.367,
            halfLife: "200ns"
        ));
        #endregion

        #region Chlorine ------------------------------------------------------ Chlorine

        #endregion

        #region Argon ------------------------------------------------------ Argon

        #endregion

        #region Potassium ------------------------------------------------------ Potassium

        #endregion

        #region Calcium ------------------------------------------------------ Calcium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Scandium ------------------------------------------------------ Scandium

        #endregion

        #region Titanium ------------------------------------------------------ Titanium

        #endregion

        #region Vanadium ------------------------------------------------------ Vanadium

        #endregion

        #region Chromium ------------------------------------------------------ Chromium

        #endregion

        #region Manganese ------------------------------------------------------ Manganese

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Iron ------------------------------------------------------ Iron

        #endregion

        #region Cobalt ------------------------------------------------------ Cobalt

        #endregion

        #region Nickel ------------------------------------------------------ Nickel

        #endregion

        #region Copper ------------------------------------------------------ Copper

        #endregion

        #region Zinc ------------------------------------------------------ Zinc

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Gallium ------------------------------------------------------ Gallium

        #endregion

        #region Germanium ------------------------------------------------------ Germanium

        #endregion

        #region Arsenic ------------------------------------------------------ Arsenic

        #endregion

        #region Selenium ------------------------------------------------------ Selenium

        #endregion

        #region Bromine ------------------------------------------------------ Bromine

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Krypton ------------------------------------------------------ Krypton

        #endregion

        #region Rubidium ------------------------------------------------------ Rubidium

        #endregion

        #region Strontium ------------------------------------------------------ Strontium

        #endregion

        #region Yttrium ------------------------------------------------------ Yttrium

        #endregion

        #region Zirconium ------------------------------------------------------ Zirconium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Niobium ------------------------------------------------------ Niobium

        #endregion

        #region Molybdenum ------------------------------------------------------ Molybdenum

        #endregion

        #region Technetium ------------------------------------------------------ Technetium

        #endregion

        #region Ruthenium ------------------------------------------------------ Ruthenium

        #endregion

        #region Palladium ------------------------------------------------------ Palladium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Silver ------------------------------------------------------ Silver

        #endregion

        #region Cadmium ------------------------------------------------------ Cadmium

        #endregion

        #region Indium ------------------------------------------------------ Indium

        #endregion

        #region Tin ------------------------------------------------------ Tin

        #endregion

        #region Antimony ------------------------------------------------------ Antimony

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Tellerium ------------------------------------------------------ Tellerium

        #endregion

        #region Iodine ------------------------------------------------------ Iodine

        #endregion

        #region Xenon ------------------------------------------------------ Xenon

        #endregion

        #region Cesium ------------------------------------------------------ Cesium

        #endregion

        #region Barium ------------------------------------------------------ Barium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Lanthanum ------------------------------------------------------ Lanthanum

        #endregion

        #region Cerium ------------------------------------------------------ Cerium

        #endregion

        #region Praseodymium ------------------------------------------------------ Praseodymium

        #endregion

        #region Neodymium ------------------------------------------------------ Neodymium

        #endregion

        #region Promethium ------------------------------------------------------ Promethium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Samarium ------------------------------------------------------ Samarium

        #endregion

        #region Europium ------------------------------------------------------ Europium

        #endregion

        #region Gadolinium ------------------------------------------------------ Gadolinium

        #endregion

        #region Terbium ------------------------------------------------------ Terbium

        #endregion

        #region Dysprosium ------------------------------------------------------ Dysprosium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Holmium ------------------------------------------------------ Holmium

        #endregion

        #region Erbium ------------------------------------------------------ Erbium

        #endregion

        #region Thulium ------------------------------------------------------ Thulium

        #endregion

        #region Ytterbium ------------------------------------------------------ Ytterbium

        #endregion

        #region Lutetium ------------------------------------------------------ Lutetium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Hafnium ------------------------------------------------------ Hafnium

        #endregion

        #region Tantalum ------------------------------------------------------ Tantalum

        #endregion

        #region Tungsten ------------------------------------------------------ Tungsten

        #endregion

        #region Rhenium ------------------------------------------------------ Rhenium

        #endregion

        #region Osmium ------------------------------------------------------ Osmium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Iridium ------------------------------------------------------ Iridium

        #endregion

        #region Platinum ------------------------------------------------------ Platinum

        #endregion

        #region Gold ------------------------------------------------------ Gold

        #endregion

        #region Mercury ------------------------------------------------------ Mercury

        #endregion

        #region Thallium ------------------------------------------------------ Thallium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Lead ------------------------------------------------------ Lead

        #endregion

        #region Scandium ------------------------------------------------------ 

        #endregion

        #region Bismuth ------------------------------------------------------ Bismuth

        #endregion

        #region Polonium ------------------------------------------------------ Polonium

        #endregion

        #region Astatine ------------------------------------------------------ Astatine

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Radon ------------------------------------------------------ Radon

        #endregion

        #region Francium ------------------------------------------------------ Francium

        #endregion

        #region Radium ------------------------------------------------------ Radium

        #endregion

        #region Actinium ------------------------------------------------------ Actinium

        #endregion

        #region Scandium ------------------------------------------------------ 

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Thorium ------------------------------------------------------ Thorium
        elementsToAdd.Add(
        new Particle(
            elementName: "Thorium",//Th-234
            symbol: "Th",
            massNumber: 234,//p+n
            atomicNumber: 90,
            atomicMass: 234.04360123,//atomic weight
            abundance: 0.0,
            massDefect: 40.614285,//mass excess
            bindingEnergy: 7.596849,
            halfLife: "24.07407407407d"
        ));
        #endregion

        #region Protactinium ------------------------------------------------------ Protactinium

        #endregion

        #region Uranium ------------------------------------------------------ Uranium
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-217
            symbol: "U",
            massNumber: 217,//p+n
            atomicNumber: 92,
            atomicMass: 217.024368791,//atomic weight
            abundance: 0.0,
            massDefect: 22.699383,//mass excess
            bindingEnergy: 7.635026,
            halfLife: "16ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-218
            symbol: "U",
            massNumber: 218,//p+n
            atomicNumber: 92,
            atomicMass: 218.023535671,//atomic weight
            abundance: 0.0,
            massDefect: 21.923337,//mass excess
            bindingEnergy: 7.640587,
            halfLife: "510µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-219
            symbol: "U",
            massNumber: 219,//p+n
            atomicNumber: 92,
            atomicMass: 219.02491916,//atomic weight
            abundance: 0.0,
            massDefect: 23.212048,//mass excess
            bindingEnergy: 7.636669,
            halfLife: "42µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-220
            symbol: "U",
            massNumber: 220,//p+n
            atomicNumber: 92,
            atomicMass: 220.024723,//atomic weight
            abundance: 0.0,
            massDefect: 23.029,//mass excess
            bindingEnergy: 7.639,
            halfLife: "60.00000000002ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-221
            symbol: "U",
            massNumber: 221,//p+n
            atomicNumber: 92,
            atomicMass: 221.026399,//atomic weight
            abundance: 0.0,
            massDefect: 24.591,//mass excess
            bindingEnergy: 7.634,
            halfLife: "700ns"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-222
            symbol: "U",
            massNumber: 222,//p+n
            atomicNumber: 92,
            atomicMass: 222.026086,//atomic weight
            abundance: 0.0,
            massDefect: 24.299,//mass excess
            bindingEnergy: 7.638,
            halfLife: "1µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-223
            symbol: "U",
            massNumber: 223,//p+n
            atomicNumber: 92,
            atomicMass: 223.0277386,//atomic weight
            abundance: 0.0,
            massDefect: 25.83834,//mass excess
            bindingEnergy: 7.632688,
            halfLife: "18µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-224
            symbol: "U",
            massNumber: 224,//p+n
            atomicNumber: 92,
            atomicMass: 224.027604778,//atomic weight
            abundance: 0.0,
            massDefect: 25.713685,//mass excess
            bindingEnergy: 7.635203,
            halfLife: "900µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-225
            symbol: "U",
            massNumber: 225,//p+n
            atomicNumber: 92,
            atomicMass: 225.029390717,//atomic weight
            abundance: 0.0,
            massDefect: 27.377277,//mass excess
            bindingEnergy: 7.629747,
            halfLife: "84ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-226
            symbol: "U",
            massNumber: 226,//p+n
            atomicNumber: 92,
            atomicMass: 226.029338702,//atomic weight
            abundance: 0.0,
            massDefect: 27.328826,//mass excess
            bindingEnergy: 7.631916,
            halfLife: "350ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-227
            symbol: "U",
            massNumber: 227,//p+n
            atomicNumber: 92,
            atomicMass: 227.031156367,//atomic weight
            abundance: 0.0,
            massDefect: 29.02197,//mass excess
            bindingEnergy: 7.626393,
            halfLife: "1.1m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-228
            symbol: "U",
            massNumber: 228,//p+n
            atomicNumber: 92,
            atomicMass: 228.031374006,//atomic weight
            abundance: 0.0,
            massDefect: 29.224699,//mass excess
            bindingEnergy: 7.627455,
            halfLife: "9.166666666667m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-229
            symbol: "U",
            massNumber: 229,//p+n
            atomicNumber: 92,
            atomicMass: 229.033505939,//atomic weight
            abundance: 0.0,
            massDefect: 31.210582,//mass excess
            bindingEnergy: 7.620721,
            halfLife: "58.33333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-230
            symbol: "U",
            massNumber: 230,//p+n
            atomicNumber: 92,
            atomicMass: 230.033939784,//atomic weight
            abundance: 0.0,
            massDefect: 31.614706,//mass excess
            bindingEnergy: 7.620923,
            halfLife: "20.83333333333d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-231
            symbol: "U",
            massNumber: 231,//p+n
            atomicNumber: 92,
            atomicMass: 231.036293704,//atomic weight
            abundance: 0.0,
            massDefect: 33.807368,//mass excess
            bindingEnergy: 7.613381,
            halfLife: "4.166666666667d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-232
            symbol: "U",
            massNumber: 232,//p+n
            atomicNumber: 92,
            atomicMass: 232.037156152,//atomic weight
            abundance: 0.0,
            massDefect: 34.610734,//mass excess
            bindingEnergy: 7.611892,
            halfLife: "68.81024860477y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-233
            symbol: "U",
            massNumber: 233,//p+n
            atomicNumber: 92,
            atomicMass: 233.039635207,//atomic weight
            abundance: 0.0,
            massDefect: 36.919958,//mass excess
            bindingEnergy: 7.603953,
            halfLife: "159200y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-234
            symbol: "U",
            massNumber: 234,//p+n
            atomicNumber: 92,
            atomicMass: 234.040952088,//atomic weight
            abundance: 0.0054,
            massDefect: 38.1466258,//mass excess
            bindingEnergy: 7.600708,
            halfLife: "245500y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-235
            symbol: "U",
            massNumber: 235,//p+n
            atomicNumber: 92,
            atomicMass: 235.043929918,//atomic weight
            abundance: 0.7204,
            massDefect: 40.920456,//mass excess
            bindingEnergy: 7.590907,
            halfLife: "7.039573820396e8y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-236
            symbol: "U",
            massNumber: 236,//p+n
            atomicNumber: 92,
            atomicMass: 236.045568006,//atomic weight
            abundance: 0.0,
            massDefect: 42.446325,//mass excess
            bindingEnergy: 7.586477,
            halfLife: "2.342e7y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-237
            symbol: "U",
            massNumber: 237,//p+n
            atomicNumber: 92,
            atomicMass: 237.048730184,//atomic weight
            abundance: 0.0,
            massDefect: 45.391875,//mass excess
            bindingEnergy: 7.576094,
            halfLife: "6.747685185185d"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-238
            symbol: "U",
            massNumber: 238,//p+n
            atomicNumber: 92,
            atomicMass: 238.050788247,//atomic weight
            abundance: 99.2742,
            massDefect: 47.308948,//mass excess
            bindingEnergy: 7.57012,
            halfLife: "4.471080669711e10y"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-239
            symbol: "U",
            massNumber: 239,//p+n
            atomicNumber: 92,
            atomicMass: 239.054293299,//atomic weight
            abundance: 0.0,
            massDefect: 50.573883,//mass excess
            bindingEnergy: 7.558557,
            halfLife: "23.45m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-240
            symbol: "U",
            massNumber: 240,//p+n
            atomicNumber: 92,
            atomicMass: 240.056591988,//atomic weight
            abundance: 0.0,
            massDefect: 52.715098,//mass excess
            bindingEnergy: 7.551771,
            halfLife: "14.11111111111h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-241
            symbol: "U",
            massNumber: 241,//p+n
            atomicNumber: 92,
            atomicMass: 241.06033,//atomic weight
            abundance: 0.0,
            massDefect: 56.197,//mass excess
            bindingEnergy: 7.539,
            halfLife: "5m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Uranium",//U-242
            symbol: "U",
            massNumber: 242,//p+n
            atomicNumber: 92,
            atomicMass: 242.062931,//atomic weight
            abundance: 0.0,
            massDefect: 58.62,//mass excess
            bindingEnergy: 7.532,
            halfLife: "16.83333333333m"
        ));
        #endregion

        #region Neptunium ------------------------------------------------------ Neptunium

        #endregion

        #region Plutonium ------------------------------------------------------ Plutonium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Americium ------------------------------------------------------ Americium

        #endregion

        #region Curium ------------------------------------------------------ Curium

        #endregion

        #region Berkelium ------------------------------------------------------ Berkelium

        #endregion

        #region Californium ------------------------------------------------------ Californium

        #endregion

        #region Einsteinium ------------------------------------------------------ Einsteinium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Fermium ------------------------------------------------------ Fermium

        #endregion

        #region Mendelevium ------------------------------------------------------ Mendelevium

        #endregion

        #region Nobelium ------------------------------------------------------ Nobelium

        #endregion

        #region Lawrencium ------------------------------------------------------ Lawrencium

        #endregion

        #region Rutherfordium ------------------------------------------------------ Rutherfordium

        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Dubnium ------------------------------------------------------ Dubnium

        #endregion

        #region Seaborgium ------------------------------------------------------ Seaborgium

        #endregion

        #region Bohrium ------------------------------------------------------ Bohrium
        /*elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-263
            symbol: "Hs",
            massNumber: 263,//p+n
            atomicNumber: 108,
            atomicMass: 263.128558,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 119.751,//mass excess
            bindingEnergy: 7.295,
            halfLife: "1ms"
        ));*/
        #endregion

        #region Hassium ------------------------------------------------------ Hassium
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-263
            symbol: "Hs",
            massNumber: 263,//p+n
            atomicNumber: 108,
            atomicMass: 263.128558,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 119.751,//mass excess
            bindingEnergy: 7.295,
            halfLife: "1ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-264
            symbol: "Hs",
            massNumber: 264,//p+n
            atomicNumber: 108,
            atomicMass: 264.128394885,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 119.599066,//mass excess
            bindingEnergy: 7.298239,
            halfLife: "800µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-265
            symbol: "Hs",
            massNumber: 265,//p+n
            atomicNumber: 108,
            atomicMass: 265.130085,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 121.173,//mass excess
            bindingEnergy: 7.2959,
            halfLife: "2ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-266
            symbol: "Hs",
            massNumber: 266,//p+n
            atomicNumber: 108,
            atomicMass: 266.130097,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 121.185,//mass excess
            bindingEnergy: 7.298,
            halfLife: "2.3ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-267
            symbol: "Hs",
            massNumber: 267,//p+n
            atomicNumber: 108,
            atomicMass: 267.131789,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 122.761,//mass excess
            bindingEnergy: 7.295,
            halfLife: "52ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-268
            symbol: "Hs",
            massNumber: 268,//p+n
            atomicNumber: 108,
            atomicMass: 268.132162,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 123.108,//mass excess
            bindingEnergy: 7.297,
            halfLife: "2s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-269
            symbol: "Hs",
            massNumber: 269,//p+n
            atomicNumber: 108,
            atomicMass: 269.134056,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 124.872,//mass excess
            bindingEnergy: 7.293,
            halfLife: "27s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-270
            symbol: "Hs",
            massNumber: 270,//p+n
            atomicNumber: 108,
            atomicMass: 270.13465,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 125.426,//mass excess
            bindingEnergy: 7.294,
            halfLife: "3.6s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-271
            symbol: "Hs",
            massNumber: 271,//p+n
            atomicNumber: 108,
            atomicMass: 271.137657,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 128.226,//mass excess
            bindingEnergy: 7.286,
            halfLife: "40s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-272
            symbol: "Hs",
            massNumber: 272,//p+n
            atomicNumber: 108,
            atomicMass: 272.139052,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 129.526,//mass excess
            bindingEnergy: 7.284,
            halfLife: "40s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-273
            symbol: "Hs",
            massNumber: 273,//p+n
            atomicNumber: 108,
            atomicMass: 273.141986,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 132.259,//mass excess
            bindingEnergy: 7.277,
            halfLife: "50s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-274
            symbol: "Hs",
            massNumber: 274,//p+n
            atomicNumber: 108,
            atomicMass: 274.143131,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 133.325,//mass excess
            bindingEnergy: 7.276,
            halfLife: "1m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-275
            symbol: "Hs",
            massNumber: 275,//p+n
            atomicNumber: 108,
            atomicMass: 275.145952,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 135.953,//mass excess
            bindingEnergy: 7.27,
            halfLife: "30m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-276
            symbol: "Hs",
            massNumber: 276,//p+n
            atomicNumber: 108,
            atomicMass: 276.147208,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 137.123,//mass excess
            bindingEnergy: 7.268,
            halfLife: "1.111111111111h"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Hassium",//Hs-277
            symbol: "Hs",
            massNumber: 277,//p+n
            atomicNumber: 108,
            atomicMass: 277.149841,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 139.576,//mass excess
            bindingEnergy: 7.262,
            halfLife: "40m"
        ));
        #endregion

        #region Meitnerium ------------------------------------------------------ Mietnerium
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-265
            symbol: "Mt",
            massNumber: 265,//p+n
            atomicNumber: 109,
            atomicMass: 265.136151,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 126.824,//mass excess
            bindingEnergy: 7.271,
            halfLife: "2ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-266
            symbol: "Mt",
            massNumber: 266,//p+n
            atomicNumber: 109,
            atomicMass: 266.137299,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 127.893,//mass excess
            bindingEnergy: 7.27,
            halfLife: "1.2ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-267
            symbol: "Mt",
            massNumber: 267,//p+n
            atomicNumber: 109,
            atomicMass: 267.137307,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 127.901,//mass excess
            bindingEnergy: 7.273,
            halfLife: "9.954595782134ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-268
            symbol: "Mt",
            massNumber: 268,//p+n
            atomicNumber: 109,
            atomicMass: 268.138728,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 129.224,//mass excess
            bindingEnergy: 7.271,
            halfLife: "53ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-269
            symbol: "Mt",
            massNumber: 269,//p+n
            atomicNumber: 109,
            atomicMass: 269.139055,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 129.529,//mass excess
            bindingEnergy: 7.273,
            halfLife: "200ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-270
            symbol: "Mt",
            massNumber: 270,//p+n
            atomicNumber: 109,
            atomicMass: 270.140657,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 131.021,//mass excess
            bindingEnergy: 7.27,
            halfLife: "2s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-271
            symbol: "Mt",
            massNumber: 271,//p+n
            atomicNumber: 109,
            atomicMass: 271.141139,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 131.47,//mass excess
            bindingEnergy: 7.272,
            halfLife: "5s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-272
            symbol: "Mt",
            massNumber: 272,//p+n
            atomicNumber: 109,
            atomicMass: 272.143738,//atomic weight
            abundance: 6.67,//good luck finding this
            massDefect: 133.891,//mass excess
            bindingEnergy: 7.266,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-273
            symbol: "Mt",
            massNumber: 273,//p+n
            atomicNumber: 109,
            atomicMass: 273.144913,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 134.986,//mass excess
            bindingEnergy: 7.264,
            halfLife: "20s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-274
            symbol: "Mt",
            massNumber: 274,//p+n
            atomicNumber: 109,
            atomicMass: 274.147492,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 137.388,//mass excess
            bindingEnergy: 7.259,
            halfLife: "20s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-275
            symbol: "Mt",
            massNumber: 275,//p+n
            atomicNumber: 109,
            atomicMass: 275.148647,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 138.463,//mass excess
            bindingEnergy: 7.258,
            halfLife: "30s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-276
            symbol: "Mt",
            massNumber: 276,//p+n
            atomicNumber: 109,
            atomicMass: 276.151156,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 140.801,//mass excess
            bindingEnergy: 7.252,
            halfLife: "40s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-277
            symbol: "Mt",
            massNumber: 277,//p+n
            atomicNumber: 109,
            atomicMass: 277.15242,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 141.978,//mass excess
            bindingEnergy: 7.251,
            halfLife: "1m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-278
            symbol: "Mt",
            massNumber: 278,//p+n
            atomicNumber: 109,
            atomicMass: 278.154812,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 144.207,//mass excess
            bindingEnergy: 7.246,
            halfLife: "30m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Meitnerium",//Mt-279
            symbol: "Mt",
            massNumber: 279,//p+n
            atomicNumber: 109,
            atomicMass: 279.156193,//atomic weight
            abundance: 6.66,//good luck finding this
            massDefect: 145.493,//mass excess
            bindingEnergy: 7.244,
            halfLife: "6.666666666667m"
        ));
        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Darmstadtium ------------------------------------------------------ Darmstadtium
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-267
            symbol: "Ds",
            massNumber: 267,//p+n
            atomicNumber: 110,
            atomicMass: 267.144341,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 134.453,//mass excess
            bindingEnergy: 7.245,
            halfLife: "10µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-268
            symbol: "Ds",
            massNumber: 268,//p+n
            atomicNumber: 110,
            atomicMass: 268.143795,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 133.944,//mass excess
            bindingEnergy: 7.25,
            halfLife: "100µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-269
            symbol: "Ds",
            massNumber: 269,//p+n
            atomicNumber: 110,
            atomicMass: 269.145124,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 135.183,//mass excess
            bindingEnergy: 7.249,
            halfLife: "230µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-270
            symbol: "Ds",
            massNumber: 270,//p+n
            atomicNumber: 110,
            atomicMass: 270.14472,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 134.806,//mass excess
            bindingEnergy: 7.253,
            halfLife: "100µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-271
            symbol: "Ds",
            massNumber: 271,//p+n
            atomicNumber: 110,
            atomicMass: 271.146062,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 136.056,//mass excess
            bindingEnergy: 7.252,
            halfLife: "1.62ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-272
            symbol: "Ds",
            massNumber: 272,//p+n
            atomicNumber: 110,
            atomicMass: 272.146317,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 136.293,//mass excess
            bindingEnergy: 7.254,
            halfLife: "1s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-273
            symbol: "Ds",
            massNumber: 273,//p+n
            atomicNumber: 110,
            atomicMass: 273.148863,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 138.665,//mass excess
            bindingEnergy: 7.248,
            halfLife: "170µs"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-274
            symbol: "Ds",
            massNumber: 274,//p+n
            atomicNumber: 110,
            atomicMass: 274.149492,//atomic weight
            abundance: 8.34,//good luck finding this
            massDefect: 139.251,//mass excess
            bindingEnergy: 7.249,
            halfLife: "2s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-275
            symbol: "Ds",
            massNumber: 275,//p+n
            atomicNumber: 110,
            atomicMass: 275.1521762,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 141.751,//mass excess
            bindingEnergy: 7.243,
            halfLife: "2s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-276
            symbol: "Ds",
            massNumber: 276,//p+n
            atomicNumber: 110,
            atomicMass: 276.153034,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 142.551,//mass excess
            bindingEnergy: 7.243,
            halfLife: "5s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-277
            symbol: "Ds",
            massNumber: 277,//p+n
            atomicNumber: 110,
            atomicMass: 277.155647,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 144.984,//mass excess
            bindingEnergy: 7.237,
            halfLife: "5s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-278
            symbol: "Ds",
            massNumber: 278,//p+n
            atomicNumber: 110,
            atomicMass: 278.156469,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 145.75,//mass excess
            bindingEnergy: 7.237,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-279
            symbol: "Ds",
            massNumber: 279,//p+n
            atomicNumber: 110,
            atomicMass: 279.158861,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 147.978,//mass excess
            bindingEnergy: 7.232,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-280
            symbol: "Ds",
            massNumber: 280,//p+n
            atomicNumber: 110,
            atomicMass: 280.159795,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 148.848,//mass excess
            bindingEnergy: 7.232,
            halfLife: "11s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Darmstadtium",//Ds-281
            symbol: "Ds",
            massNumber: 281,//p+n
            atomicNumber: 110,
            atomicMass: 281.162061,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 150.959,//mass excess
            bindingEnergy: 7.228,
            halfLife: "4m"
        ));
        #endregion

        #region Roentgenium ------------------------------------------------------ Roentgenium
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-272
            symbol: "Rg",
            massNumber: 272,//p+n
            atomicNumber: 111,
            atomicMass: 272.153615,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 156.878,//mass excess
            bindingEnergy: 7.21,
            halfLife: "10m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-273
            symbol: "Rg",
            massNumber: 273,//p+n
            atomicNumber: 111,
            atomicMass: 273.153682,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 143.154,//mass excess
            bindingEnergy: 7.229,
            halfLife: "5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-274
            symbol: "Rg",
            massNumber: 274,//p+n
            atomicNumber: 111,
            atomicMass: 274.155713,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 145.046,//mass excess
            bindingEnergy: 7.225,
            halfLife: "5ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-275
            symbol: "Rg",
            massNumber: 275,//p+n
            atomicNumber: 111,
            atomicMass: 275.1561423,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 145.445,//mass excess
            bindingEnergy: 7.227,
            halfLife: "9.954595782134ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-276
            symbol: "Rg",
            massNumber: 276,//p+n
            atomicNumber: 111,
            atomicMass: 276.158493,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 147.636,//mass excess
            bindingEnergy: 7.222,
            halfLife: "100ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-277
            symbol: "Rg",
            massNumber: 277,//p+n
            atomicNumber: 111,
            atomicMass: 277.159519,//atomic weight
            abundance: 8.34,//good luck finding this
            massDefect: 148.591,//mass excess
            bindingEnergy: 7.221,
            halfLife: "1s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-278
            symbol: "Rg",
            massNumber: 278,//p+n
            atomicNumber: 111,
            atomicMass: 278.161604,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 150.533,//mass excess
            bindingEnergy: 7.217,
            halfLife: "1s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-279
            symbol: "Rg",
            massNumber: 279,//p+n
            atomicNumber: 111,
            atomicMass: 279.162468,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 151.338,//mass excess
            bindingEnergy: 7.218,
            halfLife: "3s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-280
            symbol: "Rg",
            massNumber: 280,//p+n
            atomicNumber: 111,
            atomicMass: 280.164473,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 153.206,//mass excess
            bindingEnergy: 7.214,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-281
            symbol: "Rg",
            massNumber: 281,//p+n
            atomicNumber: 111,
            atomicMass: 281.165372,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 154.043,//mass excess
            bindingEnergy: 7.214,
            halfLife: "1m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-282
            symbol: "Rg",
            massNumber: 282,//p+n
            atomicNumber: 111,
            atomicMass: 282.167486,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 156.012,//mass excess
            bindingEnergy: 7.21,
            halfLife: "3.333333333333m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Roentgenium",//Rg-283
            symbol: "Rg",
            massNumber: 283,//p+n
            atomicNumber: 111,
            atomicMass: 283.168415,//atomic weight
            abundance: 8.33,//good luck finding this
            massDefect: 156.878,//mass excess
            bindingEnergy: 7.21,
            halfLife: "10m"
        ));
        #endregion

        #region Copernicium ------------------------------------------------------ Copernicium
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-277
            symbol: "Cn",
            massNumber: 277,//p+n
            atomicNumber: 112,
            atomicMass: 277.163943,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 152.712,//mass excess
            bindingEnergy: 7.204,
            halfLife: "1.1ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-278
            symbol: "Cn",
            massNumber: 278,//p+n
            atomicNumber: 112,
            atomicMass: 278.164312,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 153.056,//mass excess
            bindingEnergy: 7.206,
            halfLife: "9.954595782134ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-279
            symbol: "Cn",
            massNumber: 279,//p+n
            atomicNumber: 112,
            atomicMass: 279.166546,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 155.136,//mass excess
            bindingEnergy: 7.201,
            halfLife: "100ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-280
            symbol: "Cn",
            massNumber: 280,//p+n
            atomicNumber: 112,
            atomicMass: 280.167039,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 155.596,//mass excess
            bindingEnergy: 7.203,
            halfLife: "1s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-281
            symbol: "Cn",
            massNumber: 281,//p+n
            atomicNumber: 112,
            atomicMass: 281.169286,//atomic weight
            abundance: 11.12,//good luck finding this
            massDefect: 157.689,//mass excess
            bindingEnergy: 7.198,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-282
            symbol: "Cn",
            massNumber: 282,//p+n
            atomicNumber: 112,
            atomicMass: 282.169765,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 158.135,//mass excess
            bindingEnergy: 7.2,
            halfLife: "30s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-283
            symbol: "Cn",
            massNumber: 283,//p+n
            atomicNumber: 112,
            atomicMass: 283.171792,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 160.023,//mass excess
            bindingEnergy: 7.196,
            halfLife: "4.166666666667m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-284
            symbol: "Cn",
            massNumber: 284,//p+n
            atomicNumber: 112,
            atomicMass: 284.172384,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 160.574,//mass excess
            bindingEnergy: 7.197,
            halfLife: "31s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Copernicium",//Cn-285
            symbol: "Cn",
            massNumber: 285,//p+n
            atomicNumber: 112,
            atomicMass: 285.174105,//atomic weight
            abundance: 11.11,//good luck finding this
            massDefect: 162.177,//mass excess
            bindingEnergy: 7.195,
            halfLife: "40m"
        ));
        #endregion

        #region Nihonium ------------------------------------------------------ Nihonium
        elementsToAdd.Add(
        new Particle(
            elementName: "Nihonium",//Nh-283
            symbol: "Nh",
            massNumber: 283,//p+n
            atomicNumber: 113,
            atomicMass: 283.176451,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 164.363,//mass excess
            bindingEnergy: 7.178,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nihonium",//Nh-284
            symbol: "Nh",
            massNumber: 284,//p+n
            atomicNumber: 113,
            atomicMass: 284.17808,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 165.8813,//mass excess
            bindingEnergy: 7.176,
            halfLife: "1m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nihonium",//Nh-285
            symbol: "Nh",
            massNumber: 285,//p+n
            atomicNumber: 113,
            atomicMass: 285.178732,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 166.488,//mass excess
            bindingEnergy: 7.177,
            halfLife: "1.666666666667m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nihonium",//Nh-286
            symbol: "Nh",
            massNumber: 286,//p+n
            atomicNumber: 113,
            atomicMass: 286.180481,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 168.117,//mass excess
            bindingEnergy: 7.174,
            halfLife: "5m"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Nihonium",//Nh-287
            symbol: "Nh",
            massNumber: 287,//p+n
            atomicNumber: 113,
            atomicMass: 287.181045,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 168.643,//mass excess
            bindingEnergy: 7.176,
            halfLife: "20m"
        ));
        #endregion

        #region Flerovium ------------------------------------------------------ Flerovium
        elementsToAdd.Add(
        new Particle(
            elementName: "Flerovium",//Fl-285
            symbol: "Fl",
            massNumber: 285,//p+n
            atomicNumber: 114,
            atomicMass: 285.183698,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 171.114,//mass excess
            bindingEnergy: 7.158,
            halfLife: "5s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Flerovium",//Fl-286
            symbol: "Fl",
            massNumber: 286,//p+n
            atomicNumber: 114,
            atomicMass: 286.183855,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 171.26,//mass excess
            bindingEnergy: 7.161,
            halfLife: "5s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Flerovium",//Fl-287
            symbol: "Fl",
            massNumber: 287,//p+n
            atomicNumber: 114,
            atomicMass: 287.185599,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 172.884,//mass excess
            bindingEnergy: 7.15,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Flerovium",//Fl-288
            symbol: "Fl",
            massNumber: 288,//p+n
            atomicNumber: 114,
            atomicMass: 288.185689,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 172.968,//mass excess
            bindingEnergy: 7.161,
            halfLife: "2.8s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Flerovium",//Fl-289
            symbol: "Fl",
            massNumber: 289,//p+n
            atomicNumber: 114,
            atomicMass: 289.187279,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 174.449,//mass excess
            bindingEnergy: 7.159,
            halfLife: "1.333333333333m"
        ));
        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();

        #region Moscovium ------------------------------------------------------ Moscovium
        elementsToAdd.Add(
        new Particle(
            elementName: "Moscovium",//Mc-287
            symbol: "Mc",
            massNumber: 287,//p+n
            atomicNumber: 115,
            atomicMass: 287.191186,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 178.088,//mass excess
            bindingEnergy: 7.137,
            halfLife: "500ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Moscovium",//Mc-288
            symbol: "Mc",
            massNumber: 288,//p+n
            atomicNumber: 115,
            atomicMass: 288.192492,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 179.305,//mass excess
            bindingEnergy: 7.136,
            halfLife: "1s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Moscovium",//Mc-289
            symbol: "Mc",
            massNumber: 289,//p+n
            atomicNumber: 115,
            atomicMass: 289.1927152,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 179.513,//mass excess
            bindingEnergy: 7.139,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Moscovium",//Mc-290
            symbol: "Mc",
            massNumber: 290,//p+n
            atomicNumber: 115,
            atomicMass: 290.194141,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 180.842,//mass excess
            bindingEnergy: 7.137,
            halfLife: "9.9s"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Moscovium",//Mc-291
            symbol: "Mc",
            massNumber: 291,//p+n
            atomicNumber: 115,
            atomicMass: 291.194384,//atomic weight
            abundance: 20.0,//good luck finding this
            massDefect: 181.068,//mass excess
            bindingEnergy: 7.14,
            halfLife: "1m"
        ));
        #endregion

        #region Livermorium ------------------------------------------------------ Livermorium
        elementsToAdd.Add(
        new Particle(
            elementName: "Livermorium",//Lv-289
            symbol: "Lv",
            massNumber: 289,//p+n
            atomicNumber: 116,
            atomicMass: 289.198862,//atomic weight
            abundance: 25.0,//good luck finding this
            massDefect: 185.239,//mass excess
            bindingEnergy: 7.116,
            halfLife: "9.954595782134ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Livermorium",//Lv-290
            symbol: "Lv",
            massNumber: 290,//p+n
            atomicNumber: 116,
            atomicMass: 290.19859,//atomic weight
            abundance: 25.0,//good luck finding this
            massDefect: 184.985,//mass excess
            bindingEnergy: 7.12,
            halfLife: "15ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Livermorium",//Lv-291
            symbol: "Lv",
            massNumber: 291,//p+n
            atomicNumber: 116,
            atomicMass: 291.200011,//atomic weight
            abundance: 25.0,//good luck finding this
            massDefect: 186.309,//mass excess
            bindingEnergy: 7.119,
            halfLife: "6.3ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Livermorium",//Lv-292
            symbol: "Lv",
            massNumber: 292,//p+n
            atomicNumber: 116,
            atomicMass: 292.199786,//atomic weight
            abundance: 25.0,//good luck finding this
            massDefect: 186.1,//mass excess
            bindingEnergy: 7.123,
            halfLife: "18ms"
        ));
        #endregion

        #region Tennessine ------------------------------------------------------ Tennessine
        elementsToAdd.Add(
        new Particle(
            elementName: "Tennessine",//Ts-291
            symbol: "Ts",
            massNumber: 291,//p+n
            atomicNumber: 117,
            atomicMass: 291.206564,//atomic weight
            abundance: 50.0,//good luck finding this
            massDefect: 192.413,//mass excess
            bindingEnergy: 7.096,
            halfLife: "9.954595782134ms"
        ));
        elementsToAdd.Add(
        new Particle(
            elementName: "Tennessine",//Ts-292
            symbol: "Ts",
            massNumber: 292,//p+n
            atomicNumber: 117,
            atomicMass: 292.207549,//atomic weight
            abundance: 50.0,//good luck finding this
            massDefect: 193.33,//mass excess
            bindingEnergy: 7.096,
            halfLife: "50ms"
        ));
        #endregion

        #region Oganesson ------------------------------------------------------ Oganesson
        elementsToAdd.Add(
        new Particle(
            elementName: "Oganesson",//Og-293
            symbol: "Og",
            massNumber: 293,//p+n
            atomicNumber: 118,
            atomicMass: 293.21467,//atomic weight
            abundance: 100.0,//good luck finding this
            massDefect: 199.964,//mass excess
            bindingEnergy: 7.074,
            halfLife: "5ms"
        ));
        #endregion

        DataBaseInteract.UpdateElementData(elementsToAdd);
        elementsToAdd.Clear();
    }
}