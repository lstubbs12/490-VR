using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetricCalc2 : MonoBehaviour{
    public GameObject displayText;

    /*
    4 first     T Z C O
    5 second    L D P O F
    6 third     P T O C E T
    7 fourth    Z L P E D T C
    7 fifth     D P C Z L F T
    7 sixth     C F D T E O P
    7 seventh   L D C Z O T E
    7 eighth    P F C D T Z L
    
    */
    List<string> correct = new List<string>() {
        "T", "Z", "C", "O",
        "L", "D", "P", "O", "F",
        "P", "T", "O", "C", "E", "T",
        "Z", "L", "P", "E", "D", "T", "C",
        "D", "P", "C", "Z", "L", "F", "T",
        "C", "F", "D", "T", "E", "O", "P",
        "L", "D", "C", "Z", "O", "T", "E",
        "P", "F", "C", "D", "T", "Z", "L",
    };

    List<string> entered = new List<string>();

    int count = 0;
    int countWithMistakes = 0;
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

        if (countWithMistakes <= 4)
            rowNumber = 1;
        if (countWithMistakes > 4 && countWithMistakes <= 9)
            rowNumber = 2;
        if (countWithMistakes > 9 && countWithMistakes <= 15)
            rowNumber = 3;
        if (countWithMistakes > 15 && countWithMistakes <= 22)
            rowNumber = 4;
        if (countWithMistakes > 22 && countWithMistakes <= 29)
            rowNumber = 5;
        if (countWithMistakes > 29 && countWithMistakes <= 36)
            rowNumber = 6;
        if (countWithMistakes > 36 && countWithMistakes <= 43)
            rowNumber = 7;
        if (countWithMistakes > 43 && countWithMistakes <= 50)
            rowNumber = 8;

        
        if (letter != correct[count])
        {
            Debug.Log("Letter: " + letter);
            Debug.Log("Correct Letter: " + correct[count]);
            Debug.Log("COUNT " + count);

            mistakes++;
            Debug.Log("Mistakes: " + mistakes);
            if(mistakes > 2){
                Debug.Log("Failed at " + rowNumber);
                if(rowNumber == 1)
                    displayText.GetComponent<TextMesh>().text = "20/100";
                if (rowNumber == 2)
                    displayText.GetComponent<TextMesh>().text = "20/60";
                if (rowNumber == 3)
                    displayText.GetComponent<TextMesh>().text = "20/50";
                if (rowNumber == 4)
                    displayText.GetComponent<TextMesh>().text = "20/40";
                if (rowNumber == 5)
                    displayText.GetComponent<TextMesh>().text = "20/30";
                if (rowNumber == 6)
                    displayText.GetComponent<TextMesh>().text = "20/25";
                if (rowNumber == 7)
                    displayText.GetComponent<TextMesh>().text = "20/20";
                if (rowNumber == 1)
                    displayText.GetComponent<TextMesh>().text = "20/16";
                mistakes = 0;
                rowNumber = 1;
                count = -1;
                countWithMistakes = 0;
                entered.Clear();
            }
            
            count++;
            countWithMistakes++;
        }else{
            count++;
            countWithMistakes++;
        }
        


    }
}

