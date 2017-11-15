using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JankenButton : MonoBehaviour {

	public GameObject own;
	Button button;

	void Start(){
		button = own.GetComponent<Button> ();
	}

		
	public void On(){
		button.interactable = true;
	}

	public void Off(){
		button.interactable = false;
	}

	public void Push(){
		StartMenue.Instance.Up ();
	}

	public void Gu(){
		Manager.Instance.ChoiceHand (Janken.GU);
	}

	public void Choki(){
		Manager.Instance.ChoiceHand (Janken.CHOKI);
	}

	public void Pa(){
		Manager.Instance.ChoiceHand (Janken.PA);
	}

}
