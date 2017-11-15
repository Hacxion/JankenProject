using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : Singleton<Manager> {
	int cpuHand,playerHand;
	Text cpuText;
	Text systemText;
	public JankenButton[] jButtons;

	void Start () {
		cpuText = GameObject.Find ("CpuText").GetComponent<Text> ();
		systemText = GameObject.Find ("SystemText").GetComponent<Text> ();
	}
		
	/*
	 *　スタートメニューをくぐったら呼ばれる関数。	
	 * cpuの手はこの段階で決めてしまう
	 */
	public void GameStart(){
		//各テキスト更新
		cpuText.text = "じゃんけん・・・";
		systemText.text = "出す手を選んでください。";

		cpuHand = Random.Range (0, 3); 	//整数の0～2の乱数を入れる。
	}

	/*
	 * プレイヤーが出す手を選んだ時に呼ばれるメソッド。
	 * 引数はプレイヤーの手。
	 */
	public void ChoiceHand(int hand){
		playerHand = hand; //引数をプレイヤーの手に設定。

		//各テキスト更新
		cpuText.text = Janken.HandToString (cpuHand) + "!";
		systemText.text = "あなたの手：" + Janken.HandToString (playerHand);

		//数秒待ってから次のメソッドを呼び出し。
		Invoke ("Judge", 2.0f);
	}


	/*
	 * スタートメニュー呼び出し
	 */
	void Back(){
		StartMenue.Instance.Up ();
	}

	/*
	 * ジャンケンの結果判定
	 */
	public void Judge(){
		//ジャンケンクラス内のジャッジ関数を使って判定を出す
		int result = Janken.Judge (playerHand, cpuHand);

		//判定を元にテキスト更新
		if (result == Janken.DRAW) {
			cpuText.text = "むむむ、もう一度!";
			systemText.text = "引き分けです";
			//数秒待ってからメニューに戻る
			Invoke ("GameStart", 2.0f);
		}
		else{
			if(result == Janken.WIN){
				cpuText.text = "まいりました・・・";
				systemText.text = "あなたの勝ちです";
			} 
			else {
				cpuText.text = "やったぜ。";
				systemText.text = "あなたの負けです";
			}
			Invoke ("Back", 3.0f);
		}


	}


	void ActivateButtons(){
	}
		



}
