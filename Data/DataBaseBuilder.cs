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

        DataBaseInteract.UpdateElementData(elementsToAdd);
    }
}
