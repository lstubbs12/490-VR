using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MetricCalc : MonoBehaviour
{
    public GameObject displayText;

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
    //maybe add reset values in this list, if the reset value shows up, reset mistakes. adjust row number values

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

        if (countWithMistakes <= 2)
        {
            rowNumber++;
        }

        if (countWithMistakes > 2 && countWithMistakes <= 6)
        {
            rowNumber++;
        }

        if (countWithMistakes > 6 && countWithMistakes <= 11)
        {
            rowNumber++;

        }

        if (countWithMistakes > 11 && countWithMistakes <= 17)
        {
            rowNumber++;
        }

        if (countWithMistakes > 17 && countWithMistakes <= 24)
        {
            rowNumber++;
        }

        if (countWithMistakes > 24 && countWithMistakes <= 32)
        {
            rowNumber++;

        }

        if (countWithMistakes > 32 && countWithMistakes <= 40)
        {
            rowNumber++;

        }

        if (countWithMistakes > 40 && countWithMistakes <= 48)
        {
            rowNumber++;

        }

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
            //if row number changed, reset mistakes.
        }
        


    }
}
