using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MetricCalc : MonoBehaviour
{
    /*
    2 first     T Z
    4 second    P T O C
    5 third     Z L P E D
    6 fourth    E T O D C F
    7 fifth     D P C Z L F T
    8 sixth     C F D T E O P L
    8 seventh   L D C Z O T E P
    8 eighth    P F C D T Z L E
    */
    List<string> correct = new List<string>() {
        "T", "Z",
        "P", "T", "O", "C",
        "Z", "L", "P", "E", "D",
        "E", "T", "O", "D", "C", "F",
        "D", "P", "C", "Z", "L", "F", "T",
        "C", "F", "D", "T", "E", "O", "P", "L",
        "L", "D", "C", "Z", "O", "T", "E", "P",
        "P", "F", "C", "D", "T", "Z", "L", "E",
    };

    List<string> entered = new List<string>();

    int count = 0;
    int rowNumber = 1;
    int mistakes = 0;


    private void Start()
    {
        /*foreach (var c in correct)
        {
            Debug.Log(c);
        }*/

    }

    public void TakeInLetter(string letter)
    {
        entered.Add(letter);
        if (count <= 2)
            rowNumber = 1;
        if (count <= 6)
            rowNumber = 2;
        if (count <= 11)
            rowNumber = 3;
        if (count <= 17)
            rowNumber = 4;
        if (count <= 24)
            rowNumber = 5;
        if (count <= 32)
            rowNumber = 6;
        if (count <= 40)
            rowNumber = 7;
        if (count <= 48)
            rowNumber = 8;

        
        if (letter != correct[count])
        {
            Debug.Log("Letter: " + letter);
            Debug.Log("Correct Letter: " + correct[count]);

            mistakes++;
            Debug.Log("Mistakes: " + mistakes);
        }
        count++;


    }
}
