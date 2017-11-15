using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SystemText : MonoBehaviour {
	public GameObject own;
	Text text;
	// Use this for initialization
	void Start () {
		text = own.GetComponent<Text> ();
	}
	
	public void UpdateText(){
	}
}
