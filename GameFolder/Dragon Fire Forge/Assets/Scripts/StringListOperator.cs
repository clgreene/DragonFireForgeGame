using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This is a brain-class script that organizes and loads in correct dialogue for an NPCs dialogue trigger scripts. It needs the DialogueTrigger script, IntData and StringListData Scriptable Objects

public class StringListOperator : MonoBehaviour
{

    //establishing the dialogue #, a currentList for to load into the text, and all the available dialogue options
    public IntData dialogue;
    public StringListData currentList;
    public StringListData listOne;
    public StringListData listTwo;
    public StringListData listThree;
    public StringListData listFour;
    public StringListData listFive;
    public StringListData listSix;
    public StringListData listSeven;
    public StringListData listEight;
    public StringListData listNine;

    //establishing a returnValue string for dialogue statements, and an integer that will cycle through all statements in a single dialogue option
    public string returnValue;
    public int i = 0;

    //Logic for which dialogue option is loaded via switch statement
    public void SetDialogueList(Text obj)
    {
        
            switch (dialogue.value)
            {
                case 1:
                    currentList = listOne;
                    break;
                case 2:
                    currentList = listTwo;
                    
                    break;
                case 3:
                    currentList = listThree;
                    break;
                case 4:
                    currentList = listFour;
                    break;
                case 5:
                    currentList = listFive;
                    break;
            }

        returnValue = currentList.stringList[i];

        obj.text = returnValue;

    }

    //cycle through statement and update the returnValue as you go
    public void GetNextDialogue(Text obj)
    {
        if (i >= currentList.stringList.Count - 1)
        {
            ExitTextUI(obj);
        }

        else
        {
            i = (i + 1);

            returnValue = currentList.stringList[i];

            obj.text = returnValue;
        }


    }

    //resetting dialogue text to first text option
    public void ExitTextUI(Text obj)
    {
        obj.text = null;
        i = 0;
    }

}
