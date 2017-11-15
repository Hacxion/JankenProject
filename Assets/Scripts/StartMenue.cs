using UnityEngine;
using System.Collections;

public class StartMenue : Singleton<StartMenue>{
	public GameObject own;
	public void Up(){
		own.SetActive(true);
	}
	public void Down(){
		own.SetActive(false);
	}
}
