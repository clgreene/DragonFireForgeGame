using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//This is a dialogue trigger script to be used with my StringListOperator script, and StringListData and IntData scriptable objects.
//This script triggers a certain NPCs dialogue, as long at the object entering is the Player and is tagged correctly.

public class DialogueTrigger : MonoBehaviour
{

	//establishing Unity Events for dialogue events
	public UnityEvent TriggerCycleEvent, TriggerExitEvent, TriggerSetEvent;



	//Setting the correct dialogue for where you're at in the game.
	public void startDialogue()
	{
		TriggerSetEvent.Invoke();
		
	}


	//Cycling through and updating the UI with the dialogue loaded in from above;
	public void cycleDialogue()
	{
		
		TriggerCycleEvent.Invoke();
		
		
	}


	//resetting dialogue to begining of cycle
	public void endDialogue()
	{
		TriggerExitEvent.Invoke();
	}


}
