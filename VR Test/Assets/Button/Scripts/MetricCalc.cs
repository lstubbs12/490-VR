using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MetricCalc : MonoBehaviour
{

    ArrayList row1 = new ArrayList();
    ArrayList row2 = new ArrayList();
    ArrayList row3 = new ArrayList();
    ArrayList row4 = new ArrayList();
    ArrayList row5 = new ArrayList();
    ArrayList row6 = new ArrayList();
    ArrayList row7 = new ArrayList();
    ArrayList row8 = new ArrayList();

    ArrayList lists = new ArrayList();
   
    ArrayList pressed = new ArrayList();

    int numMistakes = 0;
    int rowNumber = 1;
    int count = 0;

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
    private void Start()
    {
        row1.Add("T");
        row1.Add("Z");

        row2.Add("P");
        row2.Add("T");
        row2.Add("O");
        row2.Add("C");

        row3.Add("Z");
        row3.Add("L");
        row3.Add("P");
        row3.Add("E");
        row3.Add("D");

        row4.Add("E");
        row4.Add("T");
        row4.Add("O");
        row4.Add("D");
        row4.Add("C");
        row4.Add("F");

        row5.Add("D");
        row5.Add("P");
        row5.Add("C");
        row5.Add("Z");
        row5.Add("L");
        row5.Add("F");
        row5.Add("T");

        row6.Add("C");
        row6.Add("F");
        row6.Add("D");
        row6.Add("T");
        row6.Add("E");
        row6.Add("O");
        row6.Add("P");
        row6.Add("L");
       
        row7.Add("L");
        row7.Add("D");
        row7.Add("C");
        row7.Add("Z");
        row7.Add("O");
        row7.Add("T");
        row7.Add("E");
        row7.Add("P");
       
        row8.Add("P");
        row8.Add("F");
        row8.Add("C");
        row8.Add("D");
        row8.Add("T");
        row8.Add("Z");
        row8.Add("L");
        row8.Add("E");

        lists.Add(row1);
        lists.Add(row2);
        lists.Add(row3);
        lists.Add(row4);
        lists.Add(row5);
        lists.Add(row6);
        lists.Add(row7);
        lists.Add(row8);
    }

    public void DoLogic(int rowNum)
    {

        if (rowNumber == 1)
            count = 2;
        if (rowNumber == 2)
            count = 4;
        if (rowNumber == 3)
            count = 5;
        if (rowNumber == 4)
            count = 6;
        if (rowNumber == 5)
            count = 7;
        if (rowNumber == 6)
            count = 8;
        if (rowNumber == 7)
            count = 8;
        if (rowNumber == 8)
            count = 8;

        for (int j = 1; j < 8; j++)
        {
            if(j == rowNumber)
            {   
                if (pressed.Count == count)
                {
                    Debug.Log("Count == " + count);
                    if (numMistakes <= 2)
                    {
                        Debug.Log("Mistakes <= 2");
                        for (int i = 0; i < pressed.Count; i++)
                        {
                            Debug.Log(pressed[i].ToString());
                            if (pressed.Equals(lists[i])) //got to this line, didn't go further.
                            {
                                Debug.Log("Correct");
                                pressed.Clear();
                                rowNumber++;
                            }
                            else
                            {
                                numMistakes++;
                            }
                        }
                    }
                    else
                    {
                        Debug.Log("Failed");
                        numMistakes = 0;
                    }

                }
            }
            
        }
    }

    public void TakeInLetter(string letter)
    {
        pressed.Add(letter);
        DoLogic(rowNumber);

        
        // for(int i = 0; i < pressed.Count; i++){
        //     Debug.Log(pressed[i]);
        // }
        foreach (var let in pressed)
            Debug.Log(let.ToString());
        Debug.Log(pressed.Count);

    }
}
