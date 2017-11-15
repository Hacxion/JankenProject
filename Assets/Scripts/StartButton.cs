using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour {

	public void Push(){
		Manager.Instance.GameStart ();
		StartMenue.Instance.Down ();

	}

}
