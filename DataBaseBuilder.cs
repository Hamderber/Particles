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

        DataBaseInteract.UpdateElementData(elementsToAdd);
    }
}
