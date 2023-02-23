using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NameGenerator : MonoBehaviour
{
    [SerializeField]Text nameText;
    string consChar2;
    string consChar3;
    string consChar;
   
    
    
    public void NameGenerate()
    {
        
        
        
            int consValue = Random.Range(1, 105 + 1);
            int consValue2 = Random.Range(1, 105 + 1);
            int consValue3 = Random.Range(1,105 + 1);

        #region consonants
        consChar = consValue == 1 ? "BA"
            : consValue == 2 ? "BE"
            : consValue == 3 ? "BI"
            : consValue == 4 ? "BO"
            : consValue == 5 ? "BU"

            : consValue == 6 ? "CA"
            : consValue == 7 ? "CE"
            : consValue == 8 ? "CI"
            : consValue == 9 ? "CO"
            : consValue == 10 ? "CU"

            : consValue == 11 ? "DA"
            : consValue == 12 ? "DE"
            : consValue == 13 ? "DI"
            : consValue == 14 ? "DO"
            : consValue == 15 ? "DU"

            : consValue == 16 ? "FA"
            : consValue == 17 ? "FE"
            : consValue == 18 ? "FI"
            : consValue == 19 ? "FO"
            : consValue == 20 ? "FU"

            : consValue == 21 ? "GA"
            : consValue == 22 ? "GE"
            : consValue == 23 ? "GI"
            : consValue == 24 ? "GO"
            : consValue == 25 ? "GU"

            : consValue == 26 ? "HA"
            : consValue == 27 ? "HE"
            : consValue == 28 ? "HI"
            : consValue == 29 ? "HO"
            : consValue == 30 ? "HU"

            : consValue == 31 ? "JA"
            : consValue == 32 ? "JE"
            : consValue == 33 ? "JI"
            : consValue == 34 ? "JO"
            : consValue == 35 ? "JU"

            : consValue == 36 ? "KA"
            : consValue == 37 ? "KE"
            : consValue == 38 ? "KI"
            : consValue == 39 ? "KO"
            : consValue == 40 ? "KU"

            : consValue == 41 ? "LA"
            : consValue == 42 ? "LE"
            : consValue == 43 ? "LI"
            : consValue == 44 ? "LO"
            : consValue == 45 ? "LU"

            : consValue == 46 ? "MA"
            : consValue == 47 ? "ME"
            : consValue == 48 ? "MI"
            : consValue == 49 ? "MO"
            : consValue == 50 ? "MU"

            : consValue == 51 ? "NA"
            : consValue == 52 ? "NE"
            : consValue == 53 ? "NI"
            : consValue == 54 ? "NO"
            : consValue == 55 ? "NU"

            : consValue == 56 ? "PA"
            : consValue == 57 ? "PE"
            : consValue == 58 ? "PI"
            : consValue == 59 ? "PO"
            : consValue == 60 ? "PU"

            : consValue == 61 ? "QA"
            : consValue == 62 ? "QE"
            : consValue == 63 ? "QI"
            : consValue == 64 ? "QO"
            : consValue == 65 ? "QU"

            : consValue == 66 ? "RA"
            : consValue == 67 ? "RE"
            : consValue == 68 ? "RI"
            : consValue == 69 ? "RO"
            : consValue == 70 ? "RU"

            : consValue == 71 ? "SA"
            : consValue == 72 ? "SE"
            : consValue == 73 ? "SI"
            : consValue == 74 ? "SO"
            : consValue == 75 ? "SU"

            : consValue == 76 ? "TA"
            : consValue == 77 ? "TE"
            : consValue == 78 ? "TI"
            : consValue == 79 ? "TO"
            : consValue == 80 ? "TU"

            : consValue == 81 ? "VA"
            : consValue == 82 ? "VE"
            : consValue == 83 ? "VI"
            : consValue == 84 ? "VO"
            : consValue == 85 ? "VU"

            : consValue == 86 ? "WA"
            : consValue == 87 ? "WE"
            : consValue == 88 ? "WI"
            : consValue == 89 ? "WO"
            : consValue == 90 ? "WU"

            : consValue == 91 ? "XA"
            : consValue == 92 ? "XE"
            : consValue == 93 ? "XI"
            : consValue == 94 ? "XO"
            : consValue == 95 ? "XU"

            : consValue == 96 ? "YA"
            : consValue == 97 ? "YE"
            : consValue == 98 ? "YI"
            : consValue == 99 ? "YO"
            : consValue == 100 ? "YU"

            : consValue == 101 ? "ZA"
            : consValue == 102 ? "ZE"
            : consValue == 103 ? "ZI"
            : consValue == 104 ? "ZO"
            : consValue == 105 ? "ZU"
            : " ";

        #endregion

        #region consonants2
        consChar2 = consValue2 == 1 ? "BA"
                : consValue2 == 2 ? "BE"
                : consValue2 == 3 ? "BI"
                : consValue2 == 4 ? "BO"
                : consValue2 == 5 ? "BU"

                : consValue2 == 6 ? "CA"
                : consValue2 == 7 ? "CE"
                : consValue2 == 8 ? "CI"
                : consValue2 == 9 ? "CO"
                : consValue2 == 10 ? "CU"

                : consValue2 == 11 ? "DA"
                : consValue2 == 12 ? "DE"
                : consValue2 == 13 ? "DI"
                : consValue2 == 14 ? "DO"
                : consValue2 == 15 ? "DU"

                : consValue2 == 16 ? "FA"
                : consValue2 == 17 ? "FE"
                : consValue2 == 18 ? "FI"
                : consValue2 == 19 ? "FO"
                : consValue2 == 20 ? "FU"

                : consValue2 == 21 ? "GA"
                : consValue2 == 22 ? "GE"
                : consValue2 == 23 ? "GI"
                : consValue2 == 24 ? "GO"
                : consValue2 == 25 ? "GU"

                : consValue2 == 26 ? "HA"
                : consValue2 == 27 ? "HE"
                : consValue2 == 28 ? "HI"
                : consValue2 == 29 ? "HO"
                : consValue2 == 30 ? "HU"

                : consValue2 == 31 ? "JA"
                : consValue2 == 32 ? "JE"
                : consValue2 == 33 ? "JI"
                : consValue2 == 34 ? "JO"
                : consValue2 == 35 ? "JU"

                : consValue2 == 36 ? "KA"
                : consValue2 == 37 ? "KE"
                : consValue2 == 38 ? "KI"
                : consValue2 == 39 ? "KO"
                : consValue2 == 40 ? "KU"

                : consValue2 == 41 ? "LA"
                : consValue2 == 42 ? "LE"
                : consValue2 == 43 ? "LI"
                : consValue2== 44 ? "LO"
                : consValue2 == 45 ? "LU"

                : consValue2 == 46 ? "MA"
                : consValue2 == 47 ? "ME"
                : consValue2 == 48 ? "MI"
                : consValue2 == 49 ? "MO"
                : consValue2 == 50 ? "MU"

                : consValue2 == 51 ? "NA"
                : consValue2 == 52 ? "NE"
                : consValue2 == 53 ? "NI"
                : consValue2 == 54 ? "NO"
                : consValue2 == 55 ? "NU"

                : consValue2 == 56 ? "PA"
                : consValue2 == 57 ? "PE"
                : consValue2 == 58 ? "PI"
                : consValue2 == 59 ? "PO"
                : consValue2 == 60 ? "PU"

                : consValue2 == 61 ? "QA"
                : consValue2 == 62 ? "QE"
                : consValue2 == 63 ? "QI"
                : consValue2 == 64 ? "QO"
                : consValue2 == 65 ? "QU"

                : consValue2 == 66 ? "RA"
                : consValue2 == 67 ? "RE"
                : consValue2 == 68 ? "RI"
                : consValue2 == 69 ? "RO"
                : consValue2 == 70 ? "RU"

                : consValue2 == 71 ? "SA"
                : consValue2 == 72 ? "SE"
                : consValue2 == 73 ? "SI"
                : consValue2 == 74 ? "SO"
                : consValue2 == 75 ? "SU"

                : consValue2 == 76 ? "TA"
                : consValue2 == 77 ? "TE"
                : consValue2 == 78 ? "TI"
                : consValue2 == 79 ? "TO"
                : consValue2 == 80 ? "TU"

                : consValue2 == 81 ? "VA"
                : consValue2 == 82 ? "VE"
                : consValue2 == 83 ? "VI"
                : consValue2 == 84 ? "VO"
                : consValue2 == 85 ? "VU"

                : consValue2 == 86 ? "WA"
                : consValue2 == 87 ? "WE"
                : consValue2 == 88 ? "WI"
                : consValue2 == 89 ? "WO"
                : consValue2 == 90 ? "WU"

                : consValue2 == 91 ? "XA"
                : consValue2 == 92 ? "XE"
                : consValue2 == 93 ? "XI"
                : consValue2 == 94 ? "XO"
                : consValue2 == 95 ? "XU"

                : consValue2 == 96 ? "YA"
                : consValue2 == 97 ? "YE"
                : consValue2 == 98 ? "YI"
                : consValue2 == 99 ? "YO"
                : consValue2 == 100 ? "YU"

                : consValue2 == 101 ? "ZA"
                : consValue2 == 102 ? "ZE"
                : consValue2 == 103 ? "ZI"
                : consValue2 == 104 ? "ZO"
                : consValue2 == 105 ? "ZU"
                : " ";



        #endregion

        #region consonants3
        consChar3 = consValue3 == 1 ? "BA"
            : consValue3 == 2 ? "BE"
            : consValue3 == 3 ? "BI"
            : consValue3 == 4 ? "BO"
            : consValue3 == 5 ? "BU"

            : consValue3 == 6 ? "CA"
            : consValue3 == 7 ? "CE"
            : consValue3 == 8 ? "CI"
            : consValue3 == 9 ? "CO"
            : consValue3 == 10 ? "CU"

            : consValue3 == 11 ? "DA"
            : consValue3 == 12 ? "DE"
            : consValue3 == 13 ? "DI"
            : consValue3 == 14 ? "DO"
            : consValue3 == 15 ? "DU"

            : consValue3 == 16 ? "FA"
            : consValue3 == 17 ? "FE"
            : consValue3 == 18 ? "FI"
            : consValue3 == 19 ? "FO"
            : consValue3 == 20 ? "FU"

            : consValue3 == 21 ? "GA"
            : consValue3 == 22 ? "GE"
            : consValue3 == 23 ? "GI"
            : consValue3 == 24 ? "GO"
            : consValue3 == 25 ? "GU"

            : consValue3 == 26 ? "HA"
            : consValue3 == 27 ? "HE"
            : consValue3 == 28 ? "HI"
            : consValue3 == 29 ? "HO"
            : consValue3 == 30 ? "HU"

            : consValue3 == 31 ? "JA"
            : consValue3 == 32 ? "JE"
            : consValue3 == 33 ? "JI"
            : consValue3 == 34 ? "JO"
            : consValue3 == 35 ? "JU"

            : consValue3 == 36 ? "KA"
            : consValue3 == 37 ? "KE"
            : consValue3 == 38 ? "KI"
            : consValue3 == 39 ? "KO"
            : consValue3 == 40 ? "KU"

            : consValue3 == 41 ? "LA"
            : consValue3 == 42 ? "LE"
            : consValue3 == 43 ? "LI"
            : consValue3 == 44 ? "LO"
            : consValue3 == 45 ? "LU"

            : consValue3 == 46 ? "MA"
            : consValue3 == 47 ? "ME"
            : consValue3 == 48 ? "MI"
            : consValue3 == 49 ? "MO"
            : consValue3 == 50 ? "MU"

            : consValue3 == 51 ? "NA"
            : consValue3 == 52 ? "NE"
            : consValue3 == 53 ? "NI"
            : consValue3 == 54 ? "NO"
            : consValue3 == 55 ? "NU"

            : consValue3 == 56 ? "PA"
            : consValue3 == 57 ? "PE"
            : consValue3 == 58 ? "PI"
            : consValue3 == 59 ? "PO"
            : consValue3 == 60 ? "PU"

            : consValue3 == 61 ? "QA"
            : consValue3 == 62 ? "QE"
            : consValue3 == 63 ? "QI"
            : consValue3 == 64 ? "QO"
            : consValue3 == 65 ? "QU"

            : consValue3 == 66 ? "RA"
            : consValue3 == 67 ? "RE"
            : consValue3 == 68 ? "RI"
            : consValue3 == 69 ? "RO"
            : consValue3 == 70 ? "RU"

            : consValue3 == 71 ? "SA"
            : consValue3 == 72 ? "SE"
            : consValue3 == 73 ? "SI"
            : consValue3 == 74 ? "SO"
            : consValue3 == 75 ? "SU"

            : consValue3 == 76 ? "TA"
            : consValue3 == 77 ? "TE"
            : consValue3 == 78 ? "TI"
            : consValue3 == 79 ? "TO"
            : consValue3 == 80 ? "TU"

            : consValue3 == 81 ? "VA"
            : consValue3 == 82 ? "VE"
            : consValue3 == 83 ? "VI"
            : consValue3 == 84 ? "VO"
            : consValue3 == 85 ? "VU"

            : consValue3 == 86 ? "WA"
            : consValue3 == 87 ? "WE"
            : consValue3 == 88 ? "WI"
            : consValue3 == 89 ? "WO"
            : consValue3 == 90 ? "WU"

            : consValue3 == 91 ? "XA"
            : consValue3 == 92 ? "XE"
            : consValue3 == 93 ? "XI"
            : consValue3 == 94 ? "XO"
            : consValue3 == 95 ? "XU"

            : consValue3 == 96 ? "YA"
            : consValue3 == 97 ? "YE"
            : consValue3 == 98 ? "YI"
            : consValue3 == 99 ? "YO"
            : consValue3 == 100 ? "YU"

            : consValue3 == 101 ? "ZA"
            : consValue3 == 102 ? "ZE"
            : consValue3 == 103 ? "ZI"
            : consValue3 == 104 ? "ZO"
            : consValue3 == 105 ? "ZU"
            : " ";

        #endregion 



        nameText.text = consChar + consChar2 + consChar3;
        







    }

    
}
