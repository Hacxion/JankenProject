using UnityEngine;
using System.Collections;

public class Janken : MonoBehaviour {

	public const int GU = 0, CHOKI = 1, PA = 2;
	public const int DRAW = 0, WIN = 1, LOSE = 2;

	public static string HandToString(int hand){
		if (hand == GU)
			return "ぐー";
		else if (hand == CHOKI)
			return "ちょき";
		else
			return "ぱー";
	}

	public static int Judge(int firstHand,int secondHand){
		int key = firstHand - secondHand;
		if (key == 0) {
			return DRAW;
		} else if (key == -1 || key == 2) {
			return WIN;
		} else {
			return LOSE;
		}
	}
	
		
}
